using System;
class Employee
{
    public String FirstName;
    public String LastName;
    public int EmployeeId;
    public int Salary;
    public void DisplayDetails(String FirstName, String LastName, int EmployeeId, int Salary)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.EmployeeId = EmployeeId;
        this.Salary = Salary;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("First Name: {0}", FirstName);
        Console.WriteLine("Last Name: {0}", LastName);
        Console.WriteLine("Employee Id: {0}", EmployeeId);
        Console.WriteLine("Salary: {0}", Salary);
    }

}

class Manager : Employee
{
    public String? Department;
    public void DisplayDetails(String FirstName, String LastName, int EmployeeId, int Salary, String Department)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.EmployeeId = EmployeeId;
        this.Salary = Salary;
        this.Department = Department;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("First Name: {0}", FirstName);
        Console.WriteLine("Last Name: {0}", LastName);
        Console.WriteLine("Employee Id: {0}", EmployeeId);
        Console.WriteLine("Salary: {0}", Salary);
        Console.WriteLine("Department: {0}", Department);

    }
}

class Developer : Employee
{
    public String? ProgrammingLanguage;
    public void DisplayDetails(String FirstName, String LastName, int EmployeeId, int Salary, String ProgrammingLanguage)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.EmployeeId = EmployeeId;
        this.Salary = Salary;
        this.ProgrammingLanguage = ProgrammingLanguage;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("First Name: {0}", FirstName);
        Console.WriteLine("Last Name: {0}", LastName);
        Console.WriteLine("Employee Id: {0}", EmployeeId);
        Console.WriteLine("Salary: {0}", Salary);
        Console.WriteLine("Programming Language: {0}", ProgrammingLanguage);

    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager();
        manager.DisplayDetails("John", "Doe", 1, 100000, "Sales");
        manager.DisplayDetails();

        Developer developer = new Developer();
        developer.DisplayDetails("Jane", "Doe", 2, 100000, "C#");
        developer.DisplayDetails();
    }
}
