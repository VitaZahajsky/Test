using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JmenoTestu
{
    internal class SkDbContext : DbContext
    {
        public DbSet<Skladba> Skladba { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("User ID=postgres;Password=MasterPassword;Host=localhost;Port=5432;Database=JeMiToJedno;");
        }
    }
}
