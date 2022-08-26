namespace Srp
{

    /* her nesnesin bir sorumluluğu olmalıdır.
    Farklı sorumluluklar verilerek prensibe aykırı davranılmamalıdır.*/ 
    internal class Program
    {
        static void Main(string[] args)
        {
           Customer customer = new Customer();
           customer.Name="Yusuf";

            CustomerManager customerManager= new CustomerManager();
            customerManager.CustomerAdd(customer);

            CustomerValidator customerValidator= new CustomerValidator();   
            customerValidator.Validator(customer);
        }
    }


     internal class Customer
    {
        public string Name { get; set; }
    }


     internal class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.Name+" adlı müşteri eklendi");
        }
    }

    internal class CustomerValidator
    {
       public void Validator(Customer customer)
        {
            Console.WriteLine("Merhaba "+customer.Name+" kullanıcı doğrulamasını başarıyla geçtiniz.");
        }
    }
}