using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BackendAdminApp.Host
{
    public class BrandingProvider : IBrandingProvider, ISingletonDependency
    {
        public string AppName => "Backend Admin App";
        public string LogoUrl => null;

        public string LogoReverseUrl => null;
    }
}
