namespace MVVM_Template.Model
{
    using System;

    /// <summary>
    /// MainService data services
    /// </summary>
    public class AboutService : IAboutService
    {
        /// <summary>
        /// Get the relative data. Notice the Action and callback parameters.
        /// NOTE: Look at the MainViewModel on how this is used.
        /// </summary>
        /// <param name="callback"></param>
        public void GetData(Action<AboutItem, Exception> callback)
        {
            var item = new AboutItem("This is the About component!");
            callback(item, null);
        }
    }
}