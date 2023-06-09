using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Address { get; set; } 

    public Employee()
    {

    }
    public Employee(int id, string name, string address)
    {
        Id = id;   
        Name = name;
        Address = address;
    }
}
