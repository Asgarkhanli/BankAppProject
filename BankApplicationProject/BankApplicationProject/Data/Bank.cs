using System;
using System.Collections.Generic;
using System.Text;
using BankApplicationProject.Models;

namespace BankApplicationProject.DataBase
{
    public class Bank<T>
    {
        public List<T> Datas { get; set; }

        public Bank()
        {
            Datas = new List<T>();
        }

        
    }
}
