using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
