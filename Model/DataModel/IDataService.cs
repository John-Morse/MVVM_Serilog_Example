namespace MVVM_Template.Model
{
    using System;
    using System.Collections.ObjectModel;

    /// <summary>
    /// MainService interface
    /// </summary>
    public interface IDataService
    {
        void GetData(Action<ObservableCollection<DataItem>, Exception> callback);
    }
}
