namespace MVVM_Serilog.View
{
    using GalaSoft.MvvmLight.Threading;
    using MVVM_Serilog.CrossCutting;
    using System.Windows;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {        
        static App()
        {
            //configure logging (only set once)
            Logging.ConfigureSerilog();

            DispatcherHelper.Initialize();

            Serilog.Log.Information("Application Initialized");
        }
    }
}
