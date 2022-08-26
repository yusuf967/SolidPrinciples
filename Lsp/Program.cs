namespace Lsp
{
    internal class Program
    {
        //Liskov prensibi alt sınıf ile üst sınıf yer değiştirince bir sorun
        //olmadan proje bozulmadan çalışma mantığıdır
        static void Main(string[] args)
        {
           Employee employee = new PartTimeEmployee(); //burada biz alt sınıfı üst sınıfın yerine kullanabildik.
            employee.EmployeeId = 1;
            employee.EmployeeName = "Yusuf";
            employee.EmployeeSurname = "Doğan";
        }


        class Employee
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }
            public string EmployeeSurname { get; set; }
        }


        class PartTimeEmployee : Employee
        {
            public decimal DailyWage { get; set; } //günlük ücret
        }

        class FullTimeEmployee : Employee
        {
            public decimal HourlyWage { get; set; } //saatlik ücret
        }
    }
}