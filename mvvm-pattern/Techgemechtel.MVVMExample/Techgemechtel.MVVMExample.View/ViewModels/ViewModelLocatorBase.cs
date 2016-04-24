using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Techgemechtel.MVVMExample.View.Services;
using Techgemechtel.MVVMExample.View.Services.Interfaces;

namespace Techgemechtel.MVVMExample.View.ViewModels
{
    public class ViewModelLocatorBase
    {
        /// <summary>
        /// register services and all object to be resolved by SimpleIoc 
        /// </summary>
        public ViewModelLocatorBase()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<IDataService, DataService>();
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel MainViewModel => SimpleIoc.Default.GetInstance<MainViewModel>();
    }
}
