using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Database() { }
        public Database(int _size)
        {
            productTable = new Product[_size];
            categoryTable = new Category[_size];
            accessoryTable = new Accessory[_size];
            currentAccessorySize = 0;
            currentCategorySize = 0;
            currentProductSize = 0;
            Database.instance = this;
        }
        public int insertTable(string name, object row)
        {
            switch (name)
            {
                case "product":
                    if (currentProductSize >= productTable.Length)
                        Array.Resize(ref productTable, productTable.Length + 1);

                    productTable[currentProductSize] = (Product)row;
                    currentProductSize++;
                    return productTable.Length;
                case "category":
                    if (currentCategorySize >= categoryTable.Length)
                        Array.Resize(ref categoryTable, categoryTable.Length + 1);
                    categoryTable[currentCategorySize] = (Category)row;
                    currentCategorySize++;
                    return categoryTable.Length;
                case "accessory":
                    if (currentAccessorySize >= accessoryTable.Length)
                        Array.Resize(ref accessoryTable, accessoryTable.Length + 1);
                    accessoryTable[currentAccessorySize] = (Accessory)row;
                    currentAccessorySize++;
                    return accessoryTable.Length;
            }
            return 0;
        }
        public Array selectTable(string name, object row)
        {
            switch (name)
            {
                case "product":
                    return productTable;
                case "category":
                    return categoryTable;
                case "accessory":
                    return accessoryTable;
            }
            return null;
        }
        public int updateTable(string name, object row)
        {
            int count = 0;
            switch (name)
            {
                case "product":
                    Product product = (Product)row;
                    for (int i = 0; i < productTable.Length; i++)
                    {
                        if (productTable[i].id == product.id)
                        {
                            productTable[i] = product;
                            count++;
                        }
                    }
                    return count;
                case "category":
                    Category category = (Category)row;
                    for (int i = 0; i < categoryTable.Length; i++)
                    {
                        if (categoryTable[i].id == category.id)
                        {
                            categoryTable[i] = category;
                            count++;
                        }
                    }
                    return count;
                case "accessory":
                    Accessory accessory = (Accessory)row;
                    for (int i = 0; i < accessoryTable.Length; i++)
                    {
                        if (accessoryTable[i].id == accessory.id)
                        {
                            accessoryTable[i] = accessory;
                            count++;
                        }
                    }
                    return count;
            }
            return 0;
        }
        public Boolean deleteTable(string name, object row)
        {
            bool result = false;
            switch (name)
            {
                case "product":
                    Product product = (Product)row;
                    foreach (var item in productTable)
                    {
                        if (item.id == product.id)
                        {
                            Product newUpdate = item;
                            newUpdate = null;
                            result = true;
                        }
                    }
                    return result;
                case "category":
                    Category category = (Category)row;
                    foreach (var item in categoryTable)
                    {
                        if (item.id == category.id)
                        {
                            Category newUpdate = item;
                            newUpdate = null;
                            result = true;
                        }
                    }
                    return result;
                case "accessory":
                    Accessory accessory = (Accessory)row;
                    foreach (var item in accessoryTable)
                    {
                        if (item.id == accessory.id)
                        {
                            Accessory newUpdate = item;
                            newUpdate = null;
                            result = true;
                        }
                    }
                    return result;
            }
            return result;
        }
        public void truncateTable(string name)
        {
            switch (name)
            {
                case "product": Array.Resize(ref productTable, 0); break;
                case "category": Array.Resize(ref categoryTable, 0); break;
                case "accessory": Array.Resize(ref accessoryTable, 0); break;
                default:
                    Console.WriteLine("name input is invalid");
                    break;
            }
        }
    }
}
