using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1.dao
{
    internal class CategoryDAO
    {
        Database db;
        public CategoryDAO() {
            db = new Database(1);
            db.categoryTable[0] = new Category(1,"category1");
        }
        public int Insert(Category row) => db.InsertTable("category", row);
        public int Update(Category row) => db.UpdateTable("category", row);
        public bool Delete(Category row) => db.DeleteTable("category", row);
        public Array FindAll() => db.SelectTable("category", null);
        public object FindByIdName(string name)
        {
            for(int i=0;i<db.categoryTable.Length; i++)
            {
                if (db.categoryTable[i].name.Equals(string.Empty)) continue;
                if (db.categoryTable[i].name.Equals(name))
                    return db.categoryTable[i];
            }
            return null;
        }
    }
}
