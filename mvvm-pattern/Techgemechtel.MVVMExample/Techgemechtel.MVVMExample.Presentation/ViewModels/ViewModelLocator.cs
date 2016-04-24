using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Techgemechtel.MVVMExample.Presentation.Platform;
using Techgemechtel.MVVMExample.View.Services.Interfaces;
using Techgemechtel.MVVMExample.View.ViewModels;

namespace Techgemechtel.MVVMExample.Presentation.ViewModels
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        /// <summary>
        /// register platform specific implementations in SimpleIoc
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<IPlatformInformations, PlatformInformations>();
        }
    }
}
