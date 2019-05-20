using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LcvDB.Models;

namespace LcvDB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LcvDB.Models.Person> Person { get; set; }
        public DbSet<LcvDB.Models.Document> Document { get; set; }
        public DbSet<LcvDB.Models.Interaction> Interaction { get; set; }
        public DbSet<LcvDB.Models.Company> Company { get; set; }
    }
}
