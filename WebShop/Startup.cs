using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebShop.Startup))]
namespace WebShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase());

        //    services.AddMvc();
        //}
    }
}
