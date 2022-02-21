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

Console.WriteLine(employee1);
Console.WriteLine();
Console.WriteLine(employee2);