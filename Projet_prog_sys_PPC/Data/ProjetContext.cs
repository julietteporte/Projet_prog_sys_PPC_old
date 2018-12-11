using Microsoft.EntityFrameworkCore;
using Projet_prog_sys_PPC.Data.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_prog_sys_PPC.Data
{
    public class ProjetContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=207.154.226.196;User Id=sa;Password=UPYbMz62;Database=projet_prog_sys_PPCD;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data.DAO.Compose>().HasKey(i => new { i.Id_Scenario, i.Id });
        }

        public DbSet<Scenario> Scenario { get; set; }
        public DbSet<Compose> Compose { get; set; }
        public DbSet<Actions> Actions { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
      
    }
}
