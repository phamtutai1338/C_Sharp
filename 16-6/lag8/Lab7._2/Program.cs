using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab7._2
{
    class Program
    {    
            public static List<Project> projects = new List<Project>();
            public static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            InitProject();
            InitEmployee();

            //LINQ with Where
           var empQ1 =( from emp in employees
                        where emp.EmployeeName.StartsWith("K")
                        select emp).ToList();
            
            foreach(Employee name in empQ1)
            {
                Console.WriteLine(name.EmployeeName);
            }

            //LINQ W2
            var empQ2 = employees.Where(emp => emp.EmployeeName.StartsWith("T"));
            foreach(Employee name in empQ2)
            {
                Console.WriteLine(name.EmployeeName);
            }




            //SQL
            // select employeeName form employees where employee like'K%';

            //Group by
            var empQ3 = from emp in employees
                        group emp by emp.ProjectId;

             var empQ4 = employees.GroupBy(emp => emp.EmployeeId);

            Console.WriteLine(" Du an ma nhan vien tham gia: ");
            foreach(var data in empQ4)
            {
                Console.WriteLine("ProjectId: " + data.Key + " :" + data.Count());
            }
            var empQ5 = from emp in employees
                        join pro in projects on emp.EmployeeId equals pro.ProjectId
                        select new { emp.EmployeeName, pro.ProjectName };
            Console.WriteLine("Du an duoc lam boi nhan vien: ;");
            foreach(var data in empQ5)
            {
                Console.WriteLine(data.EmployeeName +" : "+ data.ProjectName);
            }
            var empQ6 = employees.Join(projects, emp => emp.ProjectId, pro => pro.ProjectId,
                (emp,pro) => new { emp.EmployeeName, pro.ProjectName }
                );
            foreach (var data in empQ6)
            {
                Console.WriteLine(data.EmployeeName + ":" + data.ProjectName);
            }
        }
        public static void InitProject()
        {
            projects.Add(new Project { ProjectId = 1, ProjectName = "VNPT" });
            projects.Add(new Project { ProjectId = 2, ProjectName = "MB Bank" });
            projects.Add(new Project { ProjectId = 3, ProjectName = "EVNE" });
            projects.Add(new Project { ProjectId = 4, ProjectName = "ABC" });
            projects.Add(new Project { ProjectId = 5, ProjectName = "TECHBANK" });
            projects.Add(new Project { ProjectId = 6, ProjectName = "AVG corp" });
            projects.Add(new Project { ProjectId = 7, ProjectName = "Vin group" });
            projects.Add(new Project { ProjectId = 8, ProjectName = "FPT Aptech" });


        }
        public static void InitEmployee()
        {
            employees.Add(new Employee { EmployeeId = 101, EmployeeName = "Khoi", ProjectId = 1 });
            employees.Add(new Employee { EmployeeId = 102, EmployeeName = "Minh", ProjectId = 2 });
            employees.Add(new Employee { EmployeeId = 103, EmployeeName = "Nam", ProjectId = 2 });
            employees.Add(new Employee { EmployeeId = 104, EmployeeName = "Duc", ProjectId = 2 });
            employees.Add(new Employee { EmployeeId = 105, EmployeeName = "Viet", ProjectId = 3 });
            employees.Add(new Employee { EmployeeId = 106, EmployeeName = "Ngoc", ProjectId = 4 });
            employees.Add(new Employee { EmployeeId = 107, EmployeeName = "Trung", ProjectId = 5 });
            employees.Add(new Employee { EmployeeId = 108, EmployeeName = "Thao", ProjectId = 2 });
            employees.Add(new Employee { EmployeeId = 109, EmployeeName = "Hung", ProjectId = 6 });
            employees.Add(new Employee { EmployeeId = 110, EmployeeName = "Anh", ProjectId = 6 });
            employees.Add(new Employee { EmployeeId = 111, EmployeeName = "Van", ProjectId = 8 });
            employees.Add(new Employee { EmployeeId = 112, EmployeeName = "Ngoc", ProjectId = 8 });
            employees.Add(new Employee { EmployeeId = 113, EmployeeName = "Dung", ProjectId = 1 });
            employees.Add(new Employee { EmployeeId = 114, EmployeeName = "Khoi", ProjectId = 7 });
            employees.Add(new Employee { EmployeeId = 115, EmployeeName = "Khoi", ProjectId = 2 });

        }
    }
}