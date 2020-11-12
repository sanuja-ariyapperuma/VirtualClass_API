using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ChapterRepository : RepositoryBase<Chapter>, IChapterRepository
    {
        public ChapterRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
