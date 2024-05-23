using Bai1.dao;
using System;
using Bai1.Base;

namespace Bai1.demo
{
    public class DatabaseDemo
    {
        const int initSize = 10;
        private Database db;
        public int InsertTableTest(string name, BaseRow row)
        {
            return db.InsertTable(name, row);
        }
        public Array SelectTableTest(string name, BaseRow row)
        {
            return db.SelectTable(name, row);
        }
        public int UpdateTableTest(string name, BaseRow row)
        {
            return db.UpdateTable(name, row);
        }
        public Boolean DeleteTableTest(string name, BaseRow row)
        {
            return db.DeleteTable(name, row);
        }
        public void TruncateTableTest(string name)
        {
           db.TruncateTable(name);
        }

        public void InitDatabase()
        {
            //db = new Database(initSize);
            db = Database.InitializeDatabase(initSize);
        }

        public void PrintTableTest()
        {
            for (int i = 0; i < db.categoryTable.Length; i++)
            {
                db.categoryTable[i].PrintData();
            }

            for (int i = 0; i < db.accessoryTable.Length; i++)
            {
                db.accessoryTable[i].PrintData();
            }

            for (int i = 0; i < db.productTable.Length; i++)
            {
                db.productTable[i].PrintData();
            }
        }
    }
}
