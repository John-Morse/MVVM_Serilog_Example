namespace MVVM_Template.Model
{
    using System;

    /// <summary>
    /// MainService data services
    /// </summary>
    public class MainService : IMainService
    {
        /// <summary>
        /// Get the relative data. Notice the Action and callback parameters.
        /// NOTE: Look at the MainViewModel on how this is used.
        /// </summary>
        /// <param name="callback"></param>
        public void GetData(Action<MainItem, Exception> callback)
        {
            var item = new MainItem("This is a MVVM Light Template!");
            callback(item, null);
        }
    }
}