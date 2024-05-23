using Bai1.dao;
using System;

namespace Bai1.Base
{
    public abstract class BaseDao
    {
        /// <summary>
        /// Add object to database.
        /// </summary>
        /// <param name="row">Object to add</param>
        /// <returns>The number of objects have been added to the database</returns>
        protected virtual int Insert(BaseRow row)
        {
            return Database.instance.InsertTable(Database.instance.GetObjectTypeName(row), row);
        }

        /// <summary>
        /// Update object in database.
        /// </summary>
        /// <param name="row">The object is updated into the array</param>
        /// <returns>The number of objects have been updated in database</returns>
        protected virtual int Update(BaseRow row)
        {
            return Database.instance.UpdateTable(Database.instance.GetObjectTypeName(row), row);
        }

        /// <summary>
        /// Delete object in database.
        /// </summary>
        /// <param name="row">Object to delete</param>
        /// <returns>True if object deletion is successful, false if object deletion fails</returns>
        protected virtual Boolean Delete(BaseRow row)
        {
            return Database.instance.DeleteTable(Database.instance.GetObjectTypeName(row), row);
        }

        /// <summary>
        /// Find all object in database.
        /// </summary>
        /// <param name="row">Object to find</param>
        /// <returns>Suitable object</returns>
        protected virtual Array FindAll(BaseRow row)
        {
            return Database.instance.SelectTable(Database.instance.GetObjectTypeName(row), null);
        }

        /// <summary>
        /// Find object in database with id input.
        /// </summary>
        /// <param name="row">Object type to find</param>
        /// <param name="id">id to find</param>
        /// <returns>All suitable object</returns>
        protected virtual object FindById(int id, BaseRow row)
        {
            BaseRow[] baseRows = FindElementInBaseRows(row);
            for (int i = 0; i < baseRows.Length; i++)
            {
                if (baseRows[i].id == id)
                    return baseRows[i];
            }
            return null;
        }

        /// <summary>
        /// Find object in database with name input.
        /// </summary>
        /// <param name="row">Object type to find</param>
        /// <param name="name">name to find</param>
        /// <returns>Suitable object</returns>
        protected virtual object FindByName(string name, BaseRow row)
        {
            BaseRow[] baseRows = FindElementInBaseRows(row);
            for (int i = 0; i < baseRows.Length; i++)
            {
                if (baseRows[i].name.Equals(string.Empty)) continue;
                if (baseRows[i].name.Equals(name))
                    return baseRows[i];
            }
            return null;
        }

        /// <summary>
        /// Find an array of objects belonging to the class.
        /// </summary>
        /// <param name="row">Object type to find</param>
        /// <returns>An Array object fits in the BaseRow class</returns>
        private BaseRow[] FindElementInBaseRows(BaseRow row)
        {
            BaseRow[] baseRows = null;
            if (row.GetType() == typeof(Product)) baseRows = Database.instance.productTable;
            else if (row.GetType() == typeof(Accessory)) baseRows = Database.instance.accessoryTable;
            else if (row.GetType() == typeof(Category)) baseRows = Database.instance.categoryTable;
            return baseRows;
        }
    }
}
