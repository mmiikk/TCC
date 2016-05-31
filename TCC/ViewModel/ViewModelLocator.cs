/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:TCC"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using TCC.Services;

namespace TCC.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}
         //   SimpleIoc.Default.Register<IDataAccessService, DataAccessService>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<SettingsViewModel>();
            SimpleIoc.Default.Register<ThinClientConnectViewModel>();
            SimpleIoc.Default.Register<ElementsGridViewModel>();
            SimpleIoc.Default.Register<ElementParametersViewModel>();
            SimpleIoc.Default.Register<ElementValuesViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public SettingsViewModel Settings
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SettingsViewModel>();
            }
        }
        public ElementParametersViewModel ElementParameters
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ElementParametersViewModel>();
            }
        }

        public ThinClientConnectViewModel ThinClientConnect
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ThinClientConnectViewModel>();
            }
        }

        public ElementsGridViewModel ElementsGrid
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ElementsGridViewModel>();
            }
        }

        public ElementValuesViewModel ElementValues
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ElementValuesViewModel>();
            }
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}