using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplicationProject.Models
{
    public class Employee : BaseEntity
    {
        public string Surname { get; set; }
        public string Profession { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string surname, decimal salary, string profession)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            Profession = profession;
            SoftDelete = false;

        }
        
    }
}
