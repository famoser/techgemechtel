using Techgemechtel.MVVMExample.View.Services.Interfaces;

namespace Techgemechtel.MVVMExample.Presentation.Platform
{
    public class PlatformInformations : IPlatformInformations
    {
        public string GetPlatformInformations()
        {
            return "Universal Application";
        }
    }
}
