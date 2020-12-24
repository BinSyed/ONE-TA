using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ONE_TA.Application.Interfaces;
using ONE_TA.Domain.Settings;
using ONE_TA.Infrastructure.Shared.Services;

namespace ONE_TA.Infrastructure.Shared
{
    public static class ServiceRegistration
    {
        public static void AddSharedInfrastructure(this IServiceCollection services, IConfiguration _config)
        {
            services.Configure<MailSettings>(_config.GetSection("MailSettings"));
            services.AddTransient<IDateTimeService, DateTimeService>();
            services.AddTransient<IEmailService, EmailService>();
        }
    }
}
