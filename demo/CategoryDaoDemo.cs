using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai1.dao;

namespace Bai1.demo
{
    internal class CategoryDaoDemo 
    {
        CategoryDAO categoryDAO = new CategoryDAO();
        public int InsertTest(Category row) => categoryDAO.Insert(row);

        public int IpdateTest(Category row) => categoryDAO.Update(row);

        public bool DeleteTest(Category row) => categoryDAO.Delete(row);

        public Array SelectTest() => categoryDAO.FindAll();

        public object TruncateTest(string name) => categoryDAO.FindByIdName(name);
    }
}
