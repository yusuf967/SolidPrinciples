namespace Ocp
{
    // Open Closed prensibi nesneler değişime kapalı ama gelişime açık olmalısır.
    internal class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculator calculate = new SalaryCalculator(new PartTimeEmployee());
            calculate.CalculatorSalary();
        }
    }


    interface IEmployee
    {
        void Calculator();
    }
    public class FullTimeEmployee : IEmployee
    {
        public void Calculator()
        {
            Console.WriteLine("Tam zamanlı");
        }
    }

    public class PartTimeEmployee : IEmployee

    {
        public void Calculator()
        {
            Console.WriteLine("Yarı zamanlı");
        }
    }

    public class SupportEmployee : IEmployee
    {
        public void Calculator()
        {
            Console.WriteLine("Dışarıdan gelen kısmi olarak çalışan");
        }
    }

     class SalaryCalculator
    {
        IEmployee employee;
        public SalaryCalculator(IEmployee employee)
        {
            this.employee = employee;   
        }

        public void CalculatorSalary()
        {
            this.employee.Calculator();
        }
    }
}