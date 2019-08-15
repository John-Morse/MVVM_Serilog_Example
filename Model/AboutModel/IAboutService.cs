namespace MVVM_Template.Model
{
    using System;

    /// <summary>
    /// MainService interface
    /// </summary>
    public interface IAboutService
    {
        void GetData(Action<AboutItem, Exception> callback);
    }
}
