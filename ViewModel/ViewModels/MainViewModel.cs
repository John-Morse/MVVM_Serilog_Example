namespace MVVM_Template.ViewModel
{
    using CommonServiceLocator;
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.CommandWpf;
    using MVVM_Template.Model;

    /// <summary>
    /// MainViewModel Object
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        //set the logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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

            //log some info
            log.Info("MainViewModel Initialized");
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

        //About Command instance
        private RelayCommand _aboutCommand;
        public RelayCommand AboutCommand
        {
            get
            {
                if (_aboutCommand == null)
                {
                    _aboutCommand = new RelayCommand(() =>
                    {
                        this.CurrentContentView = ServiceLocator.Current.GetInstance<AboutViewModel>();
                    });
                }
                return _aboutCommand;
            }
        }

        //ShowData Command instance
        private RelayCommand _showDataCommand;
        public RelayCommand ShowDataCommand
        {
            get
            {
                if (_showDataCommand == null)
                {
                    _showDataCommand = new RelayCommand(() =>
                    {
                        this.CurrentContentView = ServiceLocator.Current.GetInstance<ShowDataViewModel>();
                    });
                }
                return _showDataCommand;
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