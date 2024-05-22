using Bai1.dao;
using System;
using Bai1.Base;

namespace Bai1.demo
{
    public class DatabaseDemo
    {
        const int InitSize = 10;
        private Database db = Database.instance;
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
            db = new Database(InitSize);
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

        public void UpdateTableTest(int id, BaseRow row)
        {
            db.UpdateTableById(id, row);
            PrintTableTest();
        }

        public int InsertTest(string name, BaseRow row)
        {
            return db.InsertTable(name, row);
        }

        public bool DeleteTest(string name, BaseRow row)
        {
            return db.DeleteTable(name, row);
        }

        public Array SelectTest(string name, BaseRow row)
        {
            return db.SelectTable(name, row);
        }

        public void TruncateTest(string name)
        {
            db.TruncateTable(name);
        }
    }
}
