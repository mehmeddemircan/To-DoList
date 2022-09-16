using Microsoft.EntityFrameworkCore;
using To_DoList.DataAccess.Concrete.Contexts;

namespace To_DoList.WebApi
{
    public class Startup
    {
        protected readonly IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
