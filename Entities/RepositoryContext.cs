﻿using Entities.Models;
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
    }
}
