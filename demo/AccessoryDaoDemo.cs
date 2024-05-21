using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1.demo
{
    internal class AccessoryDaoDemo
    {
        AccessoryDAO accessoryDAO = new AccessoryDAO();
        public int InsertTest(Accessory row) => accessoryDAO.Insert(row);

        public int UpdateTest(Accessory row) => accessoryDAO.Update(row);

        public bool DeleteTest(Accessory row) => accessoryDAO.Delete(row);

        public Array FindAllTest() => accessoryDAO.FindAll();

        public object FindByIdTest(string name) => accessoryDAO.FindById(name);

        public object FindByNameTest(string name) => accessoryDAO.FindByName(name);
    }
}
