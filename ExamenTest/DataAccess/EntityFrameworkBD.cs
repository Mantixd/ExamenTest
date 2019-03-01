using ExamenTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenTest.DataAccess
{
    public class EntityFrameworkBD : DbContext
    {
        public EntityFrameworkBD(DbContextOptions<EntityFrameworkBD> options) : base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Users> Users { get; set; }
    }
}
