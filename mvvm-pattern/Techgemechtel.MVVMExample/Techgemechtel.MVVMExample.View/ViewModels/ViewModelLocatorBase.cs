using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Techgemechtel.MVVMExample.View.Services;
using Techgemechtel.MVVMExample.View.Services.Interfaces;

namespace Techgemechtel.MVVMExample.View.ViewModels
{
    public class ViewModelLocatorBase
    {
        public ViewModelLocatorBase()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<IDataService, DataService>();
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel MainViewModel => SimpleIoc.Default.GetInstance<MainViewModel>();
    }
}
