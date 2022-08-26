namespace Dip
{

    //Dependency Inversion Prensibi bağımlılıkları en aza indirmemizi sağlar. Kutu modeline neye bağımlı olduğumuxu
    //söyler ayrıcana kodda her yerde değiştirmemize gerek kalmaz.
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeIndex();
        }

        static void HomeIndex()
        {
            Container container = new Container();
            container.GetInstance().GetCategories();
        }
        static void Index1()
        {
            Container container = new Container();
            container.GetInstance().GetCategories();
        }
        static void Index2()
        {
            Container container = new Container();
            container.GetInstance().GetCategories();
        }

        class Container
        {
            public IRepository GetInstance()
            {
                return new IPeppositoryDp();
            }
        }

        interface IRepository
        {
            void GetCategories();
        }

        class IRepositoryEf : IRepository
        {
            public void GetCategories()
            {
                Console.WriteLine("Ef ile getirildi.");
            }
        }

        class IPeppositoryDp : IRepository
        {
            public void GetCategories()
            {
                Console.WriteLine("Dapper ile getirildi.");
            }
        }
    }
}