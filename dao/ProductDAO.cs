using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai1.dao;

namespace Bai1.demo
{
    internal class ProductDAO
    {
        Database db;
        public ProductDAO()
        {
            db = new Database(1);
            db.productTable[0] = new Product(1, "product1",1);
        }
        public int Insert(Product row) => db.InsertTable("product", row);
        public int Update(Product row) => db.UpdateTable("product", row);
        public bool Delete(Product row) => db.DeleteTable("product", row);
        public Array FindAll() => db.SelectTable("product", null);
        
        public object FindById(string name)
        {
            for (int i = 0; i < db.productTable.Length; i++)
            {
                if (db.productTable[i].name.Equals(string.Empty)) continue;
                if (db.productTable[i].GetId().Equals(int.Parse(name)))
                    return db.productTable[i];
            }
            return null;
        }
        public object FindByName(string name)
        {
            for (int i = 0; i < db.productTable.Length; i++)
            {
                if (db.productTable[i].name.Equals(string.Empty)) continue;
                if (db.productTable[i].name.Equals(name))
                    return db.productTable[i];
            }
            return null;
        }
    }
}
