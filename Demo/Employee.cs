using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class EmployeeComparier : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
return x?.name?.CompareTo(y?.name) ?? (y is null ? 0 :-1);

        }
    }
    class Employee :IComparable<Employee>  
    {

        public int id {  get; set; }
        public string? name { get; set; }
        public int salary { get; set; }

        public Employee(int _id,string _name , int _salary) { 
        
        id = _id;   
            name = _name;
            salary = _salary;
        
        }

        public override string ToString()
        {
            return $"id is {id}  name is {name}  salary is {salary}";
        }

        public Employee() { 
        }
        public int CompareTo(Employee? other)
        {
if(other == null) return 1 ;
return this.salary.CompareTo(other.salary) ;

        }
    }
}
