namespace MVVM_Serilog.ViewModel
{
    using CommonServiceLocator;
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.CommandWpf;
    using MVVM_Serilog.Model;

    /// <summary>
    /// MainViewModel Object
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        //set _dataService property to interface
        private readonly IMainService _dataService;
        
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// Notice we are doing dependency injection with this one.
        /// If we wanted to write unit tests for this, we would inject a fake/mock DataService in here.
        /// </summary>
        public MainViewModel(IMainService dataService)
        {
            _dataService = dataService;

            //go get the data
            _dataService.GetData(
                (item, error) =>
                {
                    WelcomeTitle = item.Title;
                });

           this.CurrentContentView = this;
        }

        //WelcomeTitle property
        private string _welcomeTitle;
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                _welcomeTitle = value;
                RaisePropertyChanged("WelcomeTitle");
            }
        }

        //ContentView ViewModel holder
        private ViewModelBase currentContentView;
        public ViewModelBase CurrentContentView
        {
            get
            {
                return currentContentView;
            }
            set
            {
                currentContentView = value;
                RaisePropertyChanged("CurrentContentView");
            }
        }

        //CloseWindow Command instance (notice IClosable data type)
        private RelayCommand<IClosable> _closeWindowCommand;
        public RelayCommand<IClosable> CloseWindowCommand
        {
            get
            {
                if (_closeWindowCommand == null)
                {
                    _closeWindowCommand = new RelayCommand<IClosable>((IClosable window) =>
                    {
                        if (window != null)
                        {
                            window.Close();
                        }
                    });
                }
                return _closeWindowCommand;
            }
        }
    }
}