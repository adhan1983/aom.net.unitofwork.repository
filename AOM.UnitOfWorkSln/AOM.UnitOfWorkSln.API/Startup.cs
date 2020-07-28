using AOM.UnitOfWorkSln.API.Data;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using AOM.UnitOfWorkSln.API.Interfaces;
using AOM.UnitOfWorkSln.API.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AOM.UnitOfWorkSln.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("database"));

            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
