using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankApplicationProject.DataBase;
using BankApplicationProject.Models;
using BankApplicationProject.Services.Interfaces;

namespace BankApplicationProject.Services.Implementations
{
    public class BranchService : IBankService<Branch>, IBranchService
    {
        private Bank<Branch> bank;
        private Bank<Employee> employees;
        public BranchService()
        {
            bank = new Bank<Branch>();
            employees = new Bank<Employee>();
        }
        
        public void Create(Branch branch)
        {
            bank.Datas.Add(branch);
            
        }

        public void Delete(string name)
        {
            Branch branch = bank.Datas.Find(x=>x.Name.ToLower().Trim()==name.ToLower());
            branch.SoftDelete = true;
        }
        
        public void Get(string filter)
        {
            try
            {
                Branch branch = bank.Datas.Find(m => m.Name.Contains(filter.ToLower().Trim())
                ||
                m.Address.Contains(filter.ToLower().Trim()));

                Console.WriteLine(branch.Name + " " + branch.Address);
            }

            catch (Exception)
            {
                Console.WriteLine("Branch not found!");
            }
        }

        public void GetAll()
        {
            foreach (var branch in bank.Datas.Where(n=>n.SoftDelete==false))
            {
                Console.WriteLine(branch.Name + " " + branch.Address + " " + branch.Budget);
            }    
        }
        
        public void Update(string name, string address, decimal budget)
        {
            Branch branch = bank.Datas.Find(l => l.Name.ToLower().Trim() == name.ToLower().Trim());
            branch.Address = address;
            branch.Budget = budget;
        }

        public void GetProfit(string name)
        {
            Branch branch = bank.Datas.Find(p => p.Name.ToLower().Trim() == name.ToLower().Trim());
            decimal sum = 0;
            foreach (var employee in branch.Employees)
            {
                sum += employee.Salary;
            }
            decimal profit = branch.Budget - sum;
            Console.WriteLine(profit);
        }

        public void HireEmployee(string name)
        {
            Employee employee = employees.Datas.Find(k => k.Name.ToLower().Trim() == name.ToLower().Trim());
            Branch branch = bank.Datas.Find(j => j.Name.ToLower().Trim() == name);
            branch.Employees.Add(employee);
        }

        public void TransferEmployee(string name, string name1, string name2)
        {
            Employee employee = employees.Datas.Find(b=>b.Name.ToLower().Trim() == name.ToLower().Trim());
            Branch branch1 = bank.Datas.Find(b=>b.Name.ToLower().Trim()== name1.ToLower().Trim());
            Branch branch2 = bank.Datas.Find(b => b.Name.ToLower().Trim() == name2.ToLower().Trim());
            branch1.Employees.Add(employee);
            branch2.Employees.Add(employee);
        }

        public void TransferMoney(string name1, string name2, decimal budget)
        {
            Branch branch1 = bank.Datas.Find(p => p.Name.ToLower().Trim() == name1.ToLower().Trim());
            Branch branch2 = bank.Datas.Find(p => p.Name.ToLower().Trim() == name2.ToLower().Trim());
            branch1.Budget = branch2.Budget - budget;
            branch2.Budget = branch2.Budget + budget;
        }

        
    }
}
