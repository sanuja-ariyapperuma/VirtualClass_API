using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class SubjectCatogaryRepository : RepositoryBase<SubjectCatogary>, ISubjectCatogaryRepository
    {
        public SubjectCatogaryRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}