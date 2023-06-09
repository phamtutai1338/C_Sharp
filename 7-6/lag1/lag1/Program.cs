using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lag1
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Employee employee = new Employee();
            Employee employee1 = new Employee();
            employee1.Id = 2;
            employee1.Name = "Hai";
            employee1.Address = "Quang Minh";
            Console.WriteLine(employee1);   
            
        }
         
    }
    class MyApp
    {
        public static void Main(string[] args)
        {
            int valueToBox = 345;
            object boxed = valueToBox;
            int valueOutOfBox = (int)boxed;

            ArrayList students = new ArrayList();
            students.Add("Khoi");
            students.Add("Nam");
            students.Add("Phu");
            string[] studentsArray = new string[3]; ;
            students.CopyTo(studentsArray, 0);

            foreach (string name in studentsArray)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(students.Count);

            Console.WriteLine(students.IsSynchronized);

            students.Remove("Khoi");
            students.RemoveAt(1);
            students.Insert(0, "Minh");

            students.Contains("Minh");
            students.Clear();
          

            Hashtable employyees = new Hashtable();
            employyees.Add("t", "Trung");
            employyees.Add("d", "Dung");
            employyees.Add("v", "Vinh");
            employyees.Add("n", "Ngoc");

            employyees.Remove("t");
            employyees.Contains("v");

            //  employyees.Clear();

            ICollection keys = employyees.Keys;
            ICollection values = employyees.Values;

            foreach(object key in keys)
            {
                Console.WriteLine(key);
            }
            foreach(object value in values)
            {
                Console.WriteLine(value);
            }

            SortedList users = new SortedList();
            SortedList sortedList = new SortedList(50);

            SortedList sortedListwthOption =new SortedList ( new CaseInsensitiveComparer());

            Hashtable hashtable = new Hashtable();  
            
            



            ArrayList arrayList = new ArrayList();
            ArrayList arrayList1 = new ArrayList();
            arrayList.Add("i Macbook");
            arrayList.Add("i Phone");
            arrayList.Add("i Mac");
            arrayList.Add("i everyThing");
            arrayList.Add("B Phone");
            arrayList.Add("B Thing");
            arrayList.AddRange(arrayList1);
            arrayList.Insert(3, "New product");
            for (var i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
    class Teacher
    {

    }
    class ArrayListDemo
    {
       
    }
}
