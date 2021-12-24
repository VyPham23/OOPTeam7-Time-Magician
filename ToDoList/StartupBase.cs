using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDoList.Infastructure;

namespace TodoList
{
    public class StartupBase
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<ToDoContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ToDoContext")))
        }
    }
}