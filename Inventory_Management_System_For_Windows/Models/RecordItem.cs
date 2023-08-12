using Inventory_Management_System_For_Windows.Utilities;
using SQLite;
using System;
using PrimaryKeyAttribute = SQLite.PrimaryKeyAttribute;

namespace Inventory_Management_System_For_Windows.Models
{
    public class RecordItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public long Time { get; set; }

        public RecordItem(string productName, string from, string to, decimal price, decimal count, DateTime time)
        {
            ProductName = productName;
            From = from;
            To = to;
            Price = price;
            Count = count;
            Time = Utility.DateTimeToTimeStamp(time);
        }

    }
}
