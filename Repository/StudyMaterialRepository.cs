using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class StudyMaterialRepository : RepositoryBase<StudyMaterial>, IStudyMaterialRepository
    {
        public StudyMaterialRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
