using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1.Base
{
    public interface IDao
    {
        /*
         * Add object of class BaseRow
         */
        int Insert(BaseRow row);

        /*
         * Update object of class BaseRow
         */
        int Update(BaseRow row);

        /*
         * Delete object of class BaseRow
         */
        Boolean Delete(BaseRow row);

        /*
         * Find all object of class BaseRow
         */
        Array FindAll(BaseRow row);

        /*
         * Find object of class BaseRow with id input
         */
        object FindById(int id, BaseRow row);

        /*
         * Find object of class BaseRow with name input
         */
        object FindByName(string name, BaseRow row);
    }
}
