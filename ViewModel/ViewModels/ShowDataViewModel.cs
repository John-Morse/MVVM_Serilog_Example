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
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public ShowDataViewModel()
        {
            //go get and set the data collection
            this.dataCollection = new DataService().GetData();
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