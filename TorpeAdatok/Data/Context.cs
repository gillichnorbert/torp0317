using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorpeAdatok.Models;

namespace TorpeAdatok.Data
{
    public class Context :DbContext
    {
        public DbSet<KiHolDolgozott> KiHolDolgozott { get; set; }

        public Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Torpikek;Trusted_Connection=True;");
        }
    }
}
