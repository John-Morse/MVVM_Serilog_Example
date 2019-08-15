namespace MVVM_Template.ViewModel
{
    using GalaSoft.MvvmLight;
    using MVVM_Template.Model;

    /// <summary>
    /// AboutViewModel object
    /// </summary>
    public class AboutViewModel : ViewModelBase
    {
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