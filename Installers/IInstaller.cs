using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FestivalVar.Installers
{
    public interface IInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}