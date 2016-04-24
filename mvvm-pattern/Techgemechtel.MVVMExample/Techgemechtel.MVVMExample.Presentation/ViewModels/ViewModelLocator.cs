using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Techgemechtel.MVVMExample.Presentation.Platform;
using Techgemechtel.MVVMExample.View.Services;
using Techgemechtel.MVVMExample.View.Services.Interfaces;
using Techgemechtel.MVVMExample.View.ViewModels;

namespace Techgemechtel.MVVMExample.Presentation.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<IPlatformInformations, PlatformInformations>();
        }
    }
}
