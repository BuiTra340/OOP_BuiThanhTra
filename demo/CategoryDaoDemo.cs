using System;
using Bai1.Base;
using Bai1.dao;

namespace Bai1.demo
{
    public class CategoryDaoDemo : CategoryDAO
    {
        public int InsertTest(Category row)
        {
            return base.Insert(row);
        }

        public int UpdateTest(Category row)
        {
            return base.Update(row);
        }

        public bool DeleteTest(Category row)
        {
            return base.Delete(row);
        }

        public Array FindAllTest(BaseRow row)
        {
            return base.FindAll(row);
        }
        public object FindByIdTest(int id, BaseRow row)
        {
            return base.FindById(id, row);
        }
    }
}
