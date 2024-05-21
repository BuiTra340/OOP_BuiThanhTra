using System;
using Bai1.Base;

namespace Bai1.dao
{
    internal class Database
    {
        public Product[] productTable;
        public Category[] categoryTable;
        public Accessory[] accessoryTable;

        int currentProductSize;
        int currentCategorySize;
        int currentAccessorySize;
        public static Database instance;
        const string product = "product";
        const string category = "category";
        const string accessory = "accessory";
        public Database() { }
        public Database(int _size)
        {
            if (instance == null)
                instance = this;
            else return;

            productTable = new Product[_size];
            categoryTable = new Category[_size];
            accessoryTable = new Accessory[_size];
            currentAccessorySize = 0;
            currentCategorySize = 0;
            currentProductSize = 0;
        }
        public int InsertTable(string name, BaseRow row)
        {
            switch (name)
            {
                case product:
                    if (!productTable[currentProductSize].name.Equals(string.Empty))
                        currentProductSize++;

                    if (currentProductSize >= productTable.Length)
                        Array.Resize(ref productTable, productTable.Length + 1);
                    productTable[currentProductSize] = (Product)row;
                    return productTable.Length;
                case category:
                    if (!categoryTable[currentCategorySize].name.Equals(string.Empty))
                        currentCategorySize++;

                    if (currentCategorySize >= categoryTable.Length)
                        Array.Resize(ref categoryTable, categoryTable.Length + 1);
                    categoryTable[currentCategorySize] = (Category)row;
                    return categoryTable.Length;
                case accessory:
                    if (!accessoryTable[currentAccessorySize].name.Equals(string.Empty))
                        currentAccessorySize++;

                    if (currentAccessorySize >= accessoryTable.Length)
                        Array.Resize(ref accessoryTable, accessoryTable.Length + 1);
                    accessoryTable[currentAccessorySize] = (Accessory)row;
                    return accessoryTable.Length;
            }
            return 0;
        }
        public Array SelectTable(string name, BaseRow row)
        {
            switch (name)
            {
                case product:
                    return productTable;
                case category:
                    return categoryTable;
                case accessory:
                    return accessoryTable;
            }
            return null;
        }
        public int UpdateTable(string name, BaseRow row)
        {
            int count = 0;
            switch (name)
            {
                case product:
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
                case category:
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
                case accessory:
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
        public Boolean DeleteTable(string name, BaseRow row)
        {
            bool result = false;
            switch (name)
            {
                case product:
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
                case category:
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
                case accessory:
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
        public void TruncateTable(string name)
        {
            switch (name)
            {
                case product: Array.Resize(ref productTable, 0); break;
                case category: Array.Resize(ref categoryTable, 0); break;
                case accessory: Array.Resize(ref accessoryTable, 0); break;
                default:
                    Console.WriteLine("name input is invalid");
                    break;
            }
        }

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
    }
}
