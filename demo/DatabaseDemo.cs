using Bai1.dao;
using System;
using Bai1.Base;

namespace Bai1.demo
{
    internal class DatabaseDemo
    {
        const string product = "product";
        const string category = "category";
        const string accessory = "accessory";
        const int initSize = 10;
        Database db = Database.instance;
        public int InsertTableTest(string name,BaseRow row) => db.InsertTable(name, row);
        public Array SelectTableTest(string name, BaseRow row) => db.SelectTable(name, row);
        public int UpdateTableTest(string name, BaseRow row) => db.UpdateTable(name, row);
        public Boolean DeleteTableTest(string name, BaseRow row) => db.DeleteTable(name, row);
        public void TruncateTableTest(string name) => db.TruncateTable(name);

        public void InitDatabase()
        {
            db = new Database(initSize);
            for (int i = 0; i < initSize; i++)
            {
                db.productTable[i] = new Product(i, product + i, i);
                db.categoryTable[i] = new Category(i, category + i);
                db.accessoryTable[i] = new Accessory(i, accessory + i);
            }
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

        public int InsertTest(string name, BaseRow row) => db.InsertTable(name, row);

        public bool DeleteTest(string name, BaseRow row) => db.DeleteTable(name, row);

        public Array SelectTest(string name, BaseRow row) => db.SelectTable(name, row);

        public void TruncateTest(string name) => db.TruncateTable(name);
    }
}
