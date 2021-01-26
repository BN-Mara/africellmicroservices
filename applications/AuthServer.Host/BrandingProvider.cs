using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AuthServer.Host
{
    public class BrandingProvider : IBrandingProvider, ISingletonDependency
    {
        public string AppName => "Authentication Server";
        public string LogoUrl => null;

        public string LogoReverseUrl => null;
    }
}
