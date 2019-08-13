namespace MVVM_Template.Model
{
    /// <summary>
    /// MaineItem model
    /// </summary>
    public class MainItem
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
        public MainItem(string title)
        {
            Title = title;
        }
    }
}