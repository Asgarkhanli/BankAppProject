using System;
using System.Collections.Generic;
using System.Text;
using BankApplicationProject.Models;

namespace BankApplicationProject.Services.Interfaces
{
    public interface IBankService<T>
    {
        void Create(T entity);
        void Update(string name, string addressOrProfession, decimal salaryOrBudget);
        void Delete(string name);
        void Get(string filter);
        void GetAll();
    }
}
