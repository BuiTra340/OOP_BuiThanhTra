using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Category
    {
        public int id;
        public string name;
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Category() {
            id = 0;
            name = "category";
        }
        public int getId() => id;
        public void setId(int _id) => id = _id;
    }
}
