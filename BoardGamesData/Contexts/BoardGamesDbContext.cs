using BoardGamesData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesData.Contexts
{
    public class BoardGamesDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public BoardGamesDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=BoardGames2;Trusted_Connection=True;TrustServerCertificate=true;");
        }
    }
}
