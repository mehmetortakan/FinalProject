// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var product in productManager.GetAllByCategoryId(1))
{
    Console.WriteLine(product.ProductName);
}

Console.WriteLine("----------------------------------------------------------------------");

foreach (var item in productManager.GetByUnitPrice(10,15))
{
    Console.WriteLine(item.ProductId);
}



