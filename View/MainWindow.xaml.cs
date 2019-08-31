namespace MVVM_Serilog.View
{
    using MVVM_Serilog.ViewModel;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IClosable
    {
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => 
            {
                ViewModelLocator.Cleanup();

                Serilog.Log.Information("Application Closing");
            };
        }
    }
}
