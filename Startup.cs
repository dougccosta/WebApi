using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoApi.Models;

namespace TodoApi
{
    public class Startup
    {       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            var connection = @"Server=BNU-DOUGLASC\SQLEXPRESS;Database=teste;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<TodoContext>(options => options.UseSqlServer(connection));
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}