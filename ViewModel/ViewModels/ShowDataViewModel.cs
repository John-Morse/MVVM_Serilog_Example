namespace MVVM_Template.ViewModel
{
    using GalaSoft.MvvmLight;
    using MVVM_Template.Model;
    using System.Collections.ObjectModel;
    
    /// <summary>
    /// ShowDataViewModel Object
    /// </summary>
    public class ShowDataViewModel : ViewModelBase
    {
        //set the logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //set _dataService property to interface
        private readonly IDataService _dataService;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public ShowDataViewModel(IDataService dataService)
        {
            //go get and set the data collection
            _dataService = dataService;

            //go get the data
            _dataService.GetData(
                (item, error) =>
                {
                    DataCollection = item;
                });

            //log some info
            log.Info("ShowDataViewModel Initialized");
        }

        //Data collection property
        private ObservableCollection<DataItem> dataCollection;
        public ObservableCollection<DataItem> DataCollection
        {
            get
            {
                return dataCollection;
            }
            set
            {
                dataCollection = value;
                RaisePropertyChanged("DataCollection");
            }
        }
    }
}