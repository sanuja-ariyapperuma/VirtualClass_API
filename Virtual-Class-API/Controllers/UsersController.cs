using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Virtual_Class_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly ILoggerManager _logger;
        public IConfiguration _configuration { get; }
        private IRepositoryWrapper _repoWrapper;
        //private UserManager<User> _userManager;
        private IHttpClientFactory _clientFactory;

        public UsersController(
            ILoggerManager logger,
            IRepositoryWrapper repoWrapper,
            IConfiguration config,
            IHttpClientFactory clientFactory
            )
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
            _configuration = config;
            _clientFactory = clientFactory;
        }

        

        [HttpGet, Authorize]
        public async Task<IEnumerable<User>> GetInnitialDataAsync()
        {
            //Save this value in DB is user not exsits
            var nameIdentifier = User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;

            var accessToken = GetAccessToken();

            await GetUserProfileAsync(accessToken, nameIdentifier);

            //var users = _repoWrapper.User.FindAll().ToList();
            return null;
        }

        private async Task GetUserProfileAsync(string accessToken,string userId) 
        {

            var domain = _configuration["Auth0:Authority"];
            var URL = String.Concat(domain, "/api/v2/users/", userId);
            var request = new HttpRequestMessage(HttpMethod.Get, URL);

            var bearerToken = "Bearer " + accessToken;
            request.Headers.Add("authorization", bearerToken);

            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var userDetailsJson = response.Content.ReadAsStringAsync();
            }
            else
            {
                var code = response.Content.ReadAsStringAsync(); ;
                var msg = response.Content;
            }

            
        }

        private String GetAccessToken() 
        {

            return _configuration["Auth0:API_Management_Token"];

            //try
            //{
            //    var domain = _configuration["Auth0:Authority"];
            //    var URL = String.Concat(domain, "/oauth/token");
            //    var clientId = _configuration["Auth0:ClientId"];
            //    var clientSecret = _configuration["Auth0:ClientSecret"];
            //    var audiance = _configuration["Auth0:Audience"];

            //    //URL = String.Concat(URL, "?grant_type=client_credentials&client_id=", clientId, "&client_secret=", clientSecret, "&audience=", audiance);

            //    var dict = new Dictionary<string, string>();
            //    dict.Add("grant_type", "client_credentials");
            //    dict.Add("client_id", clientId);
            //    dict.Add("client_secret", clientSecret);
            //    dict.Add("audience", audiance);


            //    var request = new HttpRequestMessage(HttpMethod.Post, URL) { Content = new FormUrlEncodedContent(dict) };
            //    //request.Headers.Accept.Add("content-type", "application/x-www-form-urlencoded");

            //    var client = _clientFactory.CreateClient();
            //    var response = await client.SendAsync(request);
            //    //string result;

            //    if (response.IsSuccessStatusCode)
            //    {
            //        var jsonString = response.Content.ReadAsStringAsync();
            //        var authorizeDetails = JsonConvert.DeserializeObject<AccessCredentials>(jsonString.Result);

            //        return authorizeDetails.access_token;
            //    }
            //    else
            //    {
            //        var code = response.StatusCode;
            //        var msg = response.Content;

            //        return "-1";
            //    }

            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}

        }


    }
}
