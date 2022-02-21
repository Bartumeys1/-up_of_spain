using Home.Data.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-N7HVJ0G\SQLEXPRESS;Database=Home_Meny-Meny;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasOne(p => p.Team)
                .WithMany(t => t.Players)
                .HasForeignKey(f => f.TeamId);

            modelBuilder.Entity<Match>().Property(m => m.Date).HasColumnType("Date");
            //modelBuilder.Entity<Match>()
            //     .HasOne(m => m.Team1)
            //     .WithMany()
            //     .OnDelete(DeleteBehavior.ClientNoAction);

            //modelBuilder.Entity<Match>()
            //    .HasOne(m => m.Team2)
            //    .WithMany()
            //    .OnDelete(DeleteBehavior.ClientNoAction);

        }
    }
}
