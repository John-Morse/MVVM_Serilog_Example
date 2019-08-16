namespace MVVM_Template.ViewModel
{
    using GalaSoft.MvvmLight;
    using MVVM_Template.Model;

    /// <summary>
    /// AboutViewModel object
    /// </summary>
    public class AboutViewModel : ViewModelBase
    {
        //set the logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //set _dataService property to interface
        private readonly IAboutService _dataService;

        /// <summary>
        /// Initializes a new instance of the AboutViewModel class.
        /// </summary>
        public AboutViewModel(IAboutService dataService)
        {
            _dataService = dataService;

            //go get the data
            _dataService.GetData(
                (item, error) =>
                {
                    AboutTitle = item.Title;
                });

            //log some info
            log.Info("AboutViewModel Initialized");
        }

        //About title properties
        private string aboutTitle;
        public string AboutTitle
        {
            get
            {
                return aboutTitle;
            }
            set
            {
                aboutTitle = value;
                RaisePropertyChanged("AboutTitle");
            }
        }
    }
}