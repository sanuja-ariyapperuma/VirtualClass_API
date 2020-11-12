using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class MaterialTypeRepository : RepositoryBase<MaterialType>, IMaterialTypeRepository
    {
        public MaterialTypeRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
