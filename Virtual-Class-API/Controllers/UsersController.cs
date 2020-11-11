using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Virtual_Class_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private IRepositoryWrapper _repoWrapper;

        public UsersController(
            ILoggerManager logger,
            IRepositoryWrapper repoWrapper
            )
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
        }

        [HttpGet, Authorize]
        public IEnumerable<User> GetInnitialData()
        {
            //var domesticAccounts = _repoWrapper.User.FindByCondition(x => x.AccountType.Equals("Domestic"));
            var users = _repoWrapper.User.FindAll().ToList();
            return users;
        }


    }
}
