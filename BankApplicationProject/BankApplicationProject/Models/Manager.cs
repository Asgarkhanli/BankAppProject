using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplicationProject.Models
{
    public class Manager : BaseEntity
    {
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Manager(string name, string surname, string username, string password)
        {
            Name = name;
            Surname = surname;
            UserName = username;
            Password = password;
            SoftDelete = false;
        }
    }
}
