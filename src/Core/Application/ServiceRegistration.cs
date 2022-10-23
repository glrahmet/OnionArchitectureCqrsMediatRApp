using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationRegistration(this IServiceCollection servicesCollection)
        {
            var assembly = Assembly.GetExecutingAssembly();
            
            servicesCollection.AddAutoMapper(assembly);
            servicesCollection.AddMediatR(assembly);
        }
    }
}
