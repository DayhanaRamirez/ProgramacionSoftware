using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

//try
//{
//    console.writeline(new date(2022, 12, 7));
//    console.writeline(new date(2022, 9, 23));
//    console.writeline(new date(2024, 2, 29));
//}
//catch (exception error)
//{
//    console.writeline(error.message);
//}
// Clase 1 

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Dayhana",
    LastName = "Ramirez",
    Birthdate = new Date(1996, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1248569.45M
};

Employee employee2 = new CommissionEmployee()
{
    Id = 1020,
    FirstName = "Daniel",
    LastName = "Ramirez",
    Birthdate = new Date(1997, 12, 3),
    HiringDate = new Date(2022, 2, 15),
    IsActive = true,
    Sales = 15635000M,
    CommissionPercentaje = 0.2F
};

Employee employee3 = new HourlyEmployee()
{
    Id = 1030,
    FirstName = "Angela",
    LastName = "Moreno",
    Birthdate = new Date(1980, 8, 15),
    HiringDate = new Date(2022, 3, 15),
    IsActive = true,
    Hours = 123.5F,
    HourValue = 12550.5M
};

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 1040,
    FirstName = "Maria Fernanda",
    LastName = "Cardona",
    Birthdate = new Date(2000, 7, 26),
    HiringDate = new Date(2022, 4, 15),
    IsActive = true,
    Base = 1000000M,
    Sales = 58000000,
    CommissionPercentaje = 0.02F
};

//Console.WriteLine(employee1);
//Console.WriteLine();
//Console.WriteLine(employee2);
//Console.WriteLine();
//Console.WriteLine(employee3);
//Console.WriteLine();
//Console.WriteLine(employee4);
//Clase 2 y 3

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}

Console.WriteLine();
Console.WriteLine("                                   ==============");
Console.WriteLine($"TOTAl:                        {$"{payroll:C2}", 19}");

Invoice invoice1 = new Invoice()
{
    Description = "iPhone13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Description = "Posta Premium",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};

Console.WriteLine(invoice1);
Console.WriteLine();
Console.WriteLine(invoice2);