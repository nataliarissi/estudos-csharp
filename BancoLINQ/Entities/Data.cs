using System;
namespace Entities
{
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee> ();

            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Luke",
                LastName = "Lindo",
                AnnualSalary = 4000,
                IsManager = true,
                DepartmentId = 1
            };
            employees.Add(employee);
            Employee employee = new Employee
            {
                Id = 2,
                FirstName = "Itachi",
                LastName = "Uchiha",
                AnnualSalary = 2000,
                IsManager = true,
                DepartmentId = 2
            };
            employees.Add(employee);
            Employee employee = new Employee
            {
                Id = 3,
                FirstName = "Sakura",
                LastName = "Haruno",
                AnnualSalary = 7000,
                IsManager = false,
                DepartmentId = 2
            };
            employees.Add(employee);
            Employee employee = new Employee
            {
                Id = 4,
                FirstName = "Sasuke",
                LastName = "Uchiha",
                AnnualSalary = 6000,
                IsManager = false,
                DepartmentId = 3
            };
            employees.Add(employee);
            return employees;
        }

        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();

            Department department = new Department
            {
                Id = 1,
                ShortName = "Uchiha",
                LongName = "Melhor de Todos"
            };
            departments.Add(department);
            Department department = new Department
            {
                Id = 2,
                ShortName = "TH",
                LongName = "Techonology"
            };
            departments.Add(department);
            Department department = new Department
            {
                Id = 3,
                ShortName = "PO",
                LongName = "Porquinho"
            };
            departments.Add(department);
        }
        return departments;
    }
}
