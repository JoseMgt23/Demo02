

using MyLibrary;

Employee Maria =  new Secretary();
Maria.Name = "Maria";
Employee Pedro = new Manager();
Pedro.Name = "Pedro";
Employee Miguel = new Developer();
Miguel.Name = "Miguel";

WriteEmployeeInfo(Maria);
WriteEmployeeInfo(Pedro);
WriteEmployeeInfo(Miguel);

void WriteEmployeeInfo(Employee employee)
{
    Console.WriteLine($"{employee.Name}: {employee.CalculaMonthlyPayment()}");
    Console.WriteLine($"Days: {employee.GePaymentDays()}");
}