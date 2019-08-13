namespace MVVM_Template.Model
{
    using System;
    using System.Collections.ObjectModel;

    /// <summary>
    /// DataService for DataItem model
    /// </summary>
    public class DataService
    {
        /// <summary>
        /// Get the DataItem data collection
        /// </summary>
        /// <returns>DataItem collection</returns>
        public ObservableCollection<DataItem> GetData()
        {
            return new ObservableCollection<DataItem>()
            {
                new DataItem { Id = 1001, Name = "John", Profession = "Software Engineer", TimeStamp = DateTime.Now },
                new DataItem { Id = 1002, Name = "Bosco", Profession = "Being a feral cat", TimeStamp = DateTime.Now },
                new DataItem { Id = 1003, Name = "Louie", Profession = "Being a feral cat", TimeStamp = DateTime.Now },
                new DataItem { Id = 1004, Name = "Rippin Rick Reese", Profession = "Footbagger", TimeStamp = DateTime.Now },
                new DataItem { Id = 1005, Name = "Treva", Profession = "Massage Therapist", TimeStamp = DateTime.Now },
                new DataItem { Id = 1006, Name = "Dan", Profession = "Mechanic", TimeStamp = DateTime.Now },
                new DataItem { Id = 1007, Name = "Rocci", Profession = "Orthopedic Surgeon", TimeStamp = DateTime.Now }
            };
        }
    }
}