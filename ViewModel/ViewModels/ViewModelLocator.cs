namespace MVVM_Serilog.ViewModel
{
    using CommonServiceLocator;
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Ioc;
    using MVVM_Serilog.Model;

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

            if (ViewModelBase.IsInDesignModeStatic)
            {
                // Create design time view services and models
                //SimpleIoc.Default.Register<IDataService, DesignDataService>();
            }
            else
            {
                // Create run time view services and models
                SimpleIoc.Default.Register<IMainService, MainService>();
            }

            SimpleIoc.Default.Register<MainViewModel>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }      
        
        public static void Cleanup()
        {
            // Clear the ViewModels
            SimpleIoc.Default.Unregister<MainViewModel>();
        }
    }
}