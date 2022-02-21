using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

try
{
    Console.WriteLine(new Date(2022, 12, 7));
    Console.WriteLine(new Date(2022, 9, 23));
    Console.WriteLine(new Date(2024, 2, 29));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}