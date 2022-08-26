namespace Isp
{
    //Ara yüzlerin ayrılığı ilkesi.
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            productManager.ProductGetAll();
        }

        interface IRepository
        {
            void Add();
        }
        interface IProductRepository:IRepository
        {
            void ProductGetAll();
        }

        interface ICategoryRepository:IRepository
        {
            void CategoryGetAll();
        }
        class ProductManager : IProductRepository
        {
            public void Add()
            {
                Console.WriteLine("Ürün eklendi");
            }

            public void ProductGetAll()
            {
                Console.WriteLine("Tüm ürünler");
            }
        }

        class CategoryManager : ICategoryRepository
        {
            public void Add()
            {
                Console.WriteLine("Kategori eklendi");
            }

            public void CategoryGetAll()
            {
                Console.WriteLine("Tüm kategoriler");
            }
        }
    }
}