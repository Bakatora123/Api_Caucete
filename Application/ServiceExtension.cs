using Microsoft.Extensions.DependencyInjection;


namespace Application
{
    static public class ServiceExtension
    {
        public static IServiceCollection ConfigureApplication(this IServiceCollection services)
        {

            return services;
        }
    }
}
