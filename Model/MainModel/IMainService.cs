namespace MVVM_Serilog.Model
{
    using System;

    /// <summary>
    /// MainService interface
    /// </summary>
    public interface IMainService
    {
        void GetData(Action<MainItem, Exception> callback);
    }
}
