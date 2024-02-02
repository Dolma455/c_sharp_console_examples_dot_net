// using System;
// using System.Linq;
// using System.Collections.Generic;

// public class Employee
// {
//     public string Name { get; set; }
//     public int DepartmentId { get; set; }
// }

// public class Department
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
//         List<Employee> employees = new List<Employee>
//         {
//             new Employee { Name = "John", DepartmentId = 1 },
//             new Employee { Name = "Jane", DepartmentId = 2 },
//             new Employee { Name = "Doe", DepartmentId = 1 },
//             new Employee { Name = "Smith", DepartmentId = 3 },
//         };

//         List<Department> departments = new List<Department>
//         {
//             new Department { Id = 1, Name = "HR" },
//             new Department { Id = 2, Name = "Sales" },
//             new Department { Id = 3, Name = "IT" },
//         };

//         var result = from e in employees
//                      join d in departments on e.DepartmentId equals d.Id
//                      select new { EmployeeName = e.Name, DepartmentName = d.Name };

//         foreach (var item in result)
//         {
//             Console.WriteLine($"Employee: {item.EmployeeName}, Department: {item.DepartmentName}");
//         }
//     }
// }