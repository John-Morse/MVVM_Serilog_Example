namespace MVVM_Template.Model
{
    using System;

    /// <summary>
    /// DataItem model
    /// </summary>
    public class DataItem
    {
        public DataItem()
        {  }

        public long Id { get; set; }

        public string Name { get; set; }

        public string Profession { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}