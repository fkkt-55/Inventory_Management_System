using Inventory_Management_System_For_Windows.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory_Management_System_For_Windows.Utilities
{
    public class DatabaseUtility
    {
        private static DatabaseUtility? instance;
        private static readonly string TableName = "main";
        private static readonly string DBPath = Path.Combine(@"./", @"database");
        private SQLiteConnection connection;
        public static DatabaseUtility GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseUtility();
            }
            return instance;
        }
        private DatabaseUtility()
        {
            CreateSQLConnection();
        }

        private void CreateSQLConnection(string dbName = "Record.db")
        {
            if (!string.IsNullOrEmpty(DBPath) && !Directory.Exists(DBPath))
            {
                Directory.CreateDirectory(DBPath);
            }
            dbName = dbName == null ? "database.db" : dbName;
            string dbFilePath = Path.Combine(DBPath, dbName);
            connection = new SQLiteConnection(dbFilePath);
            connection.CreateTable<RecordItem>();
            Add(new RecordItem("产品", "来自", "买家", 10, 10, DateTime.Now));
        }

        public void Add(RecordItem item)
        {
            connection.Insert(item);
        }

        public void Delete()
        {

        }

        public void Update() { }

        public void DeleteAll() { }

        public void Close()
        {
            connection.Close();
        }

    }
}
