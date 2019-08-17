namespace MVVM_Template.View
{
    using GalaSoft.MvvmLight.Threading;
    using MVVM_Template.CrossCutting;
    using System.Windows;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            //configure logging (only set once)
            Logging.ConfigureLog4Net();

            DispatcherHelper.Initialize();
        }
    }
}
