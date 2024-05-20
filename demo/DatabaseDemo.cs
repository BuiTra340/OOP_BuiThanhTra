using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai1.dao;

namespace Bai1.demo
{
    internal class DatabaseDemo 
    {
        Database db = Database.instance;
        public int insertTableTest(string name, object row) => db.insertTable(name, row);
        public Array selectTableTest(string name, object row) => db.selectTable(name, row);
        public int updateTableTest(string name, object row) => db.updateTable(name, row);
        public Boolean deleteTableTest(string name, object row) => db.deleteTable(name, row);
        public void truncateTableTest(string name) => db.truncateTable(name);
        public void initDatabase()
        {
            db = new Database(10);
            for(int i=0;i<10;i++)
            {
                db.productTable[i] = new Product();
                db.categoryTable[i] = new Category();
                db.accessoryTable[i] = new Accessory();
            }
        }
        public void printTableTest()
        {
            //for(int i = 0;i<db.productTable.Length;i++)
            //{
            //    Console.WriteLine(db.productTable[i].)
            //}
        }
    }
}
