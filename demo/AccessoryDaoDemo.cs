using System;
using Bai1.Base;

namespace Bai1.demo
{
    public class AccessoryDaoDemo : AccessoryDAO
    {
        public int InsertTest(Accessory row)
        {
            return base.Insert(row);
        }

        public int UpdateTest(Accessory row)
        {
            return base.Update(row);
        }

        public bool DeleteTest(Accessory row)
        {
            return base.Delete(row);
        }

        public Array FindAllTest(Accessory row)
        {
            return base.FindAll(row);
        }

        public object FindByIdTest(int id,BaseRow row)
        {
            return base.FindById(id,row);
        }

        public object FindByNameTest(string name,BaseRow row)
        {
            return base.FindByName(name,row);
        }
    }
}
