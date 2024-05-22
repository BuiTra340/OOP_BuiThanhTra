using System;
using Bai1.Base;

namespace Bai1.dao
{
    public class Database
    {
        public Product[] productTable;
        public Category[] categoryTable;
        public Accessory[] accessoryTable;

        private int CurrentProductSize = 0;
        private int CurrentCategorySize = 0;
        private int CurrentAccessorySize = 0;
        public static Database instance;
        const string ProductName = "product";
        const string CategoryName = "category";
        const string AccessoryName = "accessory";
        public Database() {}
        public Database(int initSize)
        {
            instance = this;
            productTable = new Product[initSize];
            categoryTable = new Category[initSize];
            accessoryTable = new Accessory[initSize];
            for (int i = 0; i < initSize; i++)
            {
                productTable[i] = new Product(i+1, ProductName + (i+1), i+1);
                categoryTable[i] = new Category(i+1, CategoryName + (i+1));
                accessoryTable[i] = new Accessory(i+1, AccessoryName + (i+1));
                CurrentAccessorySize++;
                CurrentCategorySize++;
                CurrentProductSize++;
            }
        }

        public static Database InitializeDatabase(int size)
        {
            if (instance == null)
                instance = new Database(size);
            return instance;
        }

        /// <summary>
        /// Add object to database.
        /// </summary>
        /// <param name="row">Object to add</param>
        /// <param name="name">Type of object to add</param>
        /// <returns>The number of objects have been added to the database</returns>
        public int InsertTable(string name, BaseRow row)
        {
            switch (name)
            {
                case ProductName:
                    Array.Resize(ref productTable, productTable.Length + 1);
                    productTable[CurrentProductSize] = (Product)row;
                    CurrentProductSize++;
                    return productTable.Length;

                case CategoryName:
                    Array.Resize(ref categoryTable, categoryTable.Length + 1);
                    categoryTable[CurrentCategorySize] = (Category)row;
                    CurrentCategorySize++;
                    return categoryTable.Length;

                case AccessoryName:
                    Array.Resize(ref accessoryTable, accessoryTable.Length + 1);
                    accessoryTable[CurrentAccessorySize] = (Accessory)row;
                    CurrentAccessorySize++;
                    return accessoryTable.Length;
            }
            return 0;
        }

        /// <summary>
        /// Select an array of object to database.
        /// </summary>
        /// <param name="name">Type of object to add</param>
        /// <returns>An array of matching objects</returns>
        public Array SelectTable(string name, BaseRow row)
        {
            switch (name)
            {
                case ProductName:
                    return productTable;
                case CategoryName:
                    return categoryTable;
                case AccessoryName:
                    return accessoryTable;
            }
            return null;
        }

        /// <summary>
        /// Update object to database.
        /// </summary>
        /// <param name="row">The object is updated into the array</param>
        /// <param name="name">Type of object to update</param>
        /// <returns>The number of objects have been updated to the database</returns>
        public int UpdateTable(string name, BaseRow row)
        {
            int count = 0;
            switch (name)
            {
                case ProductName:
                    Product currentProduct = (Product)row;
                    for (int i = 0; i < productTable.Length; i++)
                    {
                        if (productTable[i].GetId() == currentProduct.GetId())
                        {
                            productTable[i] = currentProduct;
                            count++;
                        }
                    }
                    return count;
                case CategoryName:
                    Category currentCategory = (Category)row;
                    for (int i = 0; i < categoryTable.Length; i++)
                    {
                        if (categoryTable[i].GetId() == currentCategory.GetId())
                        {
                            categoryTable[i] = currentCategory;
                            count++;
                        }
                    }
                    return count;
                case AccessoryName:
                    Accessory currentAccessory = (Accessory)row;
                    for (int i = 0; i < accessoryTable.Length; i++)
                    {
                        if (accessoryTable[i].GetId() == currentAccessory.GetId())
                        {
                            accessoryTable[i] = currentAccessory;
                            count++;
                        }
                    }
                    return count;
            }
            return 0;
        }

        /// <summary>
        /// Delete object to database.
        /// </summary>
        /// <param name="row">Use the id of object to delete elements in the array</param>
        /// <param name="name">Type of object to delete</param>
        /// <returns>True if object deletion is successful, false if object deletion fails</returns>
        public Boolean DeleteTable(string name, BaseRow row)
        {
            bool result = false;
            switch (name)
            {
                case ProductName:
                    Product currentProduct = (Product)row;
                    for (int i = 0; i < productTable.Length; i++)
                    {
                        if (productTable[i].GetId() == currentProduct.GetId())
                        {
                            productTable[i] = new Product();
                            result = true;
                        }
                    }
                    return result;
                case CategoryName:
                    Category currentCategory = (Category)row;
                    for (int i = 0; i < categoryTable.Length; i++)
                    {
                        if (categoryTable[i].GetId() == currentCategory.GetId())
                        {
                            categoryTable[i] = new Category();
                            result = true;
                        }
                    }
                    return result;
                case AccessoryName:
                    Accessory currentAccessory = (Accessory)row;
                    for (int i = 0; i < accessoryTable.Length; i++)
                    {
                        if (accessoryTable[i].GetId() == currentAccessory.GetId())
                        {
                            accessoryTable[i] = new Accessory();
                            result = true;
                        }
                    }
                    return result;
            }
            return result;
        }

        /*
         * Delete all elements in database
         */
        public void TruncateTable(string name)
        {
            switch (name)
            {
                case ProductName: Array.Resize(ref productTable, 0); break;
                case CategoryName: Array.Resize(ref categoryTable, 0); break;
                case AccessoryName: Array.Resize(ref accessoryTable, 0); break;
                default:
                    Console.WriteLine("name input is invalid");
                    break;
            }
        }

        /// <summary>
        /// Update object to database.
        /// </summary>
        /// <param name="row">Use the id of object to update elements in the array</param>
        /// <param name="name">Type of object to update</param>
        public void UpdateTableById(int id, BaseRow row)
        {
            for (int i = 0; i < productTable.Length; i++)
            {
                if (!(row is Product)) continue;
                if (productTable[i].GetId() == id)
                {
                    productTable[i] = (Product)row;
                }
            }
            for (int i = 0; i < categoryTable.Length; i++)
            {
                if (!(row is Category)) continue;
                if (categoryTable[i].GetId() == id)
                {
                    categoryTable[i] = (Category)row;
                }
            }
            for (int i = 0; i < accessoryTable.Length; i++)
            {
                if (!(row is Accessory)) continue;
                if (accessoryTable[i].GetId() == id)
                {
                    accessoryTable[i] = (Accessory)row;
                }
            }
        }

        public string GetObjectTypeName(BaseRow row)
        {
            if (row is Product) return "product";
            else if (row is Category) return "category";
            else if (row is Accessory) return "accessory";
            return string.Empty;
        }
    }
}
