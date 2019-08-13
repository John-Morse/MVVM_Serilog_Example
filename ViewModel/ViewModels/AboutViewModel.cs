namespace MVVM_Template.ViewModel
{
    using GalaSoft.MvvmLight;
    using MVVM_Template.Model;

    /// <summary>
    /// AboutViewModel object
    /// </summary>
    public class AboutViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the AboutViewModel class.
        /// </summary>
        public AboutViewModel()
        {
            //set the title here with AboutItem
            this.aboutTitle = new AboutItem("This is the About component.").Title;
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