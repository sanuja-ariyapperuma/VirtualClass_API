using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class UserVirtualClassRepository : RepositoryBase<UserVirtualClass>, IUserVirtualClassRepository
    {
        public UserVirtualClassRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
    {
    }
}
}