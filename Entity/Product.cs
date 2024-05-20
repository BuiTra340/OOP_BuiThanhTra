using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Product
    {
        public int id;
        public string name;
        public int category;
        public Product(int _id,string _name,int _category)
        {
            id = _id;
            name = _name;
            category = _category;
        }
        public Product() {
            id = 0;
            name = "product";
            category = 0;
        }
        public int getId()
        {
            return id;
        }
        public void setId(int _id) { id = _id; }
    }
}
