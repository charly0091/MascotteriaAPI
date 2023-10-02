using Mascotteria.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mascotteria.DAL.Repositorios.Contrato;
using Mascotteria.DAL.Repositorios;
using Mascotteria.Utility;

namespace Mascotteria.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencias(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<DbmascotteriaContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("cadenaSQL"));
            });

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IVentaRepository, VentaRepositorio>();

            services.AddAutoMapper(typeof(AutoMapperProfile));
        }
    }
}
