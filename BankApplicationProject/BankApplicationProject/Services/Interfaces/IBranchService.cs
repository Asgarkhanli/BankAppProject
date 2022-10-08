using System;
using System.Collections.Generic;
using System.Text;
using BankApplicationProject.Models;

namespace BankApplicationProject.Services.Interfaces
{
    public interface IBranchService :IBankService<Branch>
    {
        void HireEmployee(string name);
        void GetProfit(string name);
        void TransferMoney(string name1, string name2, decimal budget);
        void TransferEmployee(string name, string name1, string name2);
    }
}
