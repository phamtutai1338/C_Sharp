using System;
using System.Linq;


namespace Lab7
{ 
    class Program { 
        static void Main(string[] args)
    {
            // Collections
        string[] students = { "Duc","Ton Ngo Khong" ,"Viet", "Nam", "Tai", "Phu" };
            //1. Duyệt danh sách clloection
            //2. So sánh
            //LINQ
            var studentName = from student in students
                              where student.Contains('T')
                              select students;
            //Other way
            var studentName1 = students.Where(s => s.Contains('T'));

            foreach(var name in studentName1)
            {
                Console.WriteLine(name);    
            }    

           
     }
    
    
    
    }
    class Employee
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }
        public int Age { get; set; }



    }



    class Applications
    {
       static void Main(string[] args)
        {
            Employee[] employees = {
            new Employee() {EmployeeId = 1, EmployeeName = "Khoi", Age = 60},
            new Employee() {EmployeeId = 2, EmployeeName = "Nam", Age = 18},
            new Employee() {EmployeeId = 3, EmployeeName = "Minh", Age = 20},
            new Employee() {EmployeeId = 4, EmployeeName = "Duc", Age = 50},
            new Employee() {EmployeeId = 5, EmployeeName = "Ngoc", Age = 60},
            new Employee() {EmployeeId = 6, EmployeeName = "Hai", Age = 62},
            new Employee() {EmployeeId = 7, EmployeeName = "Phuc", Age = 59},
            new Employee() {EmployeeId = 8, EmployeeName = "Phuc", Age = 59},
            new Employee() {EmployeeId = 9, EmployeeName = "Phuc", Age = 59},
            new Employee() {EmployeeId = 10, EmployeeName = "Phuc", Age = 59},


            };
            //var result = new List<Employee>();
            //foreach (Employee employee in employees)
            //{

            //    if (employee.Age > 18 && employee.Age < 60)
            //    {
            //        result.Add(employee);
            //    }
            //}
            //foreach (var emp in result)
            //{
            //    Console.WriteLine(emp);
            //}

            //LINQ
            var empInWork = employees.Where(e => e.Age > 18 && e.Age < 60).ToList();
            var empInWork1 = (from emp in employees
                             where emp.Age > 18 && emp.Age < 60
                             select emp).ToArray();
            
            var empName = employees.Where(e => e.EmployeeName == "Phuc").FirstOrDefault();
            //Skip: để bỏ qua các phần tử không lấy trong danh sách
            var empOver60 = employees.Skip(1);
            
            //Take: lấy data trong khoảng này
            var empTake = employees.Take(5);

            //Count()
            int empInConpanyInWork = empInWork.Count(e => e.Age <60 && e.Age >= 18);
            int empInCompany = employees.Count();
            if(employees.Count()>0)
            {

            }

            //Any()
            bool checkEmp = employees.Any();//return true
            if (employees.Any())
            {
                //có dữ liệu => Hiệu năng tốt hơn Count
            }
            //All()
            var allEmpInWork = employees.All(e => e.Age < 60); // return false

            //WHERE vs Functions()
            var empQ1 = from emp in employees
                        where emp.EmployeeName.StartsWith("K")
                        select emp.EmployeeName;
            foreach(var emp in empQ1)
            {
                Console.WriteLine(emp);
            }
            //Other way
            var empQ2 = employees.Where(e => e.EmployeeName.StartsWith("K"));

            //ODER BY ASCENDING
            var empQ3 = from emp in employees
                        orderby emp.EmployeeName
                        select emp;
            var empQ4 = employees.OrderBy(e => e.EmployeeName);
            //ORDER BY DESCNDING 
            var empQ5 =  from emp in employees
                         orderby emp.EmployeeName descending
                         select emp.EmployeeName ;
            var empQ6 = employees.OrderByDescending(e => e.EmployeeName);
            //GROUP BY
            var empQ7 = from emp in employees
                        group emp by emp.Age;
            var empQ8 = employees.GroupBy(e => e.Age);

        }
    }
  }



      