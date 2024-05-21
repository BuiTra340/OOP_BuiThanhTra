using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1.demo
{
    internal class ProductDaoDemo
    {
        ProductDAO productDAO = new ProductDAO();
        public int InsertTest(Product row) => productDAO.Insert(row);

        public int UpdateTest(Product row) => productDAO.Update(row);

        public bool DeleteTest(Product row) => productDAO.Delete(row);

        public Array FindAllTest() => productDAO.FindAll();

        public object FindByIdTest(string name) => productDAO.FindById(name);

        public object FindByNameTest(string name) => productDAO.FindByName(name);
    }
}
