using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Accessory
    {
        public int id;
        public string name;
        public Accessory(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Accessory() {
            id = 0;
            name = "accessory";
        }
        public int getId() => id;
        public void setId(int _id) => id = _id;
    }
}
