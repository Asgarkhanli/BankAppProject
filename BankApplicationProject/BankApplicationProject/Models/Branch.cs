using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplicationProject.Models
{
    public class Branch : BaseEntity 
    {
        public decimal Budget { get; set; }
        public string Address { get; set; } 
        public List<Employee> Employees { get; set; }
        public Branch(string name, string address, decimal budget)
        {
            Name = name;
            Address = address;
            Budget = budget;
            SoftDelete = false;
        }

        
    }
}
