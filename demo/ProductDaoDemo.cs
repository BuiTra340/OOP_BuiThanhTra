using System;
using Bai1.Base;

namespace Bai1.demo
{
    public class ProductDaoDemo : ProductDAO
    {
        public int InsertTest(Product row)
        {
            return base.Insert(row);
        }

        public int UpdateTest(Product row)
        {
            return base.Update(row);
        }

        public bool DeleteTest(Product row)
        {
            return base.Delete(row);
        }

        public Array FindAllTest(Product row)
        {
            return base.FindAll(row);
        }

        public object FindByIdTest(int id, BaseRow row)
        {
            return base.FindById(id, row);
        }

        public object FindByNameTest(string name, BaseRow row)
        {
            return base.FindByName(name,row);
        }
    }
}
