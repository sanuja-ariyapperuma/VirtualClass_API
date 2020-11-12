using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ContactNumberRepository : RepositoryBase<ContactNumber>, IContactNumberRepository
    {
        public ContactNumberRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
