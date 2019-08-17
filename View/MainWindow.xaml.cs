namespace MVVM_Template.View
{
    using MVVM_Template.ViewModel;
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
            };
        }
    }
}
