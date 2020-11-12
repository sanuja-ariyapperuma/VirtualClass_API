using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Chapter> Chapter { get; set; }
        public DbSet<ContactNumber> ContactNumber { get; set; }
        public DbSet<MaterialType> MaterialType { get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<StudyMaterial> StudyMaterial { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<SubjectCatogary> SubjectCatogary { get; set; }
        public DbSet<UserVirtualClass> UserVirtualClass { get; set; }
        public DbSet<VirtualClass> VitualClass { get; set; }

    }
}
