using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int counter = 1;
            EfProductDal efProductDal = new EfProductDal();
            ProductManager productManager = new ProductManager(efProductDal);
            foreach (var product in productManager.GetAllByUnitPrice(200,500))
            {
                Console.WriteLine(counter+ "-" +product.ProductName+"------------->"+product.UnitPrice);
                counter++;
            }
            
      
        
        }
    }
}
