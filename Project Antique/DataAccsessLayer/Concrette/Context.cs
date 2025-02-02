using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrette
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=s;Database=Antique;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True; integrated security=true;");
        }
        public DbSet<Home>? Homes { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<Menu>? Menus { get; set; }
        public DbSet<MenuRight> MenuRights { get; set; }
    }
}
