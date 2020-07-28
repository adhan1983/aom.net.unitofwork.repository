using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using AOM.UnitOfWorkSln.API.Data;
//using Microsoft.Extensions.Hosting;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;

//using AOM.UnitOfWorkSln.API.Interfaces;
//using AOM.UnitOfWorkSln.API.Repositories;
using Microsoft.Extensions.Configuration;

namespace AOM.UnitOfWorkSln.CrossCutting
{
    public static class PipelineConfigureServices
    {
        public static void BuildPipelineConfigureServices(IServiceCollection services) 
        {
            services.AddControllers();
            //services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("database"));

            //services.AddTransient<ICustomerRepository, CustomerRepository>();
            //services.AddTransient<IOrderRepository, OrderRepository>();
            //services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
