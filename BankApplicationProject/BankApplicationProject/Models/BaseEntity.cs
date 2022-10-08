using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplicationProject.Models
{
    public class BaseEntity
    {
        public string Name { get; set; }
        public bool SoftDelete { get; set; }
    }
}
