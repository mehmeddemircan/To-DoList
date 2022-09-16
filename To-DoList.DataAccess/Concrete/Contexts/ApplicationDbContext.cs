using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Entities.Concrete;

namespace To_DoList.DataAccess.Concrete.Contexts
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=ToDoList;User Id=postgres;Password=Sd635241;");
        }

        public DbSet<Mission> Missions { get; set; }

        public DbSet<Group> Groups { get; set; }


        public DbSet<Color> Colors { get; set; }
        public DbSet<Theme> Themes { get; set; }
    }

}
