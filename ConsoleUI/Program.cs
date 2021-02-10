using Business.Concrete;
using System;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            ICategoryService categoryService = new CategoryManager(new EfCategoryDal()); //IoC
            foreach (var category in categoryService.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetByUnitPrice(50, 100))
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
