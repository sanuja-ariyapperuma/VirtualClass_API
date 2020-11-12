using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class VirtualClassRepository : RepositoryBase<VirtualClass>, IVitualClassRepository
    {
        public VirtualClassRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}