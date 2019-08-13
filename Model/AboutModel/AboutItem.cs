namespace MVVM_Template.Model
{
    /// <summary>
    /// AboutItem model
    /// </summary>
    public class AboutItem
    {
        /// <summary>
        /// Title property
        /// </summary>
        public string Title
        {
            get;
            private set;
        }

        /// <summary>
        /// Constructor to set the title string
        /// </summary>
        /// <param name="title">Title string</param>
        public AboutItem(string title)
        {
            Title = title;
        }
    }
}