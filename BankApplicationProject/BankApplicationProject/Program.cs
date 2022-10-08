using System;
using System.Collections.Generic;
using BankApplicationProject.Models;
using BankApplicationProject.Services.Implementations;

namespace BankApplicationProject
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            BranchService branchService = new BranchService();
            EmployeeService employeeService = new EmployeeService();

            Manager manager = new Manager("Shafa", "Cabbarova", "jabbarova", "09012002");

            List<Branch> branches = new List<Branch>();
            List<Employee> employees = new List<Employee>();

         Login:
            string username = "asg";
            string password = "2003";
            Console.Write("Please, Enter your username: ");
            string username1 = Console.ReadLine();
            Console.Write("Please, Enter your password: ");
            string password1 = Console.ReadLine();

            if (username==username1 && password==password1)
            {
            again:
                Console.Clear();

                Console.WriteLine("Press 1 to choose Branch");
                Console.WriteLine("Press 2 to choose Employee");
                Console.Write("Please, choose one: ");
                int choice;
                try
                {
                    choice= int.Parse(Console.ReadLine()); 
                }
                catch (FormatException)
                {
                    Console.WriteLine("This's a incorrect, press any key to continue!");
                    Console.ReadKey();
                    goto again;
                }
                if (choice != 0)
                {
                    if (choice == 1 || choice == 2)
                    {
                        switch (choice)
                        {
                            case 1:
                                Console.Clear();
                                BranchMenu();
                                int firstoperation;
                                try
                                {
                                    firstoperation = int.Parse(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("This's a incorrect, press any key to continue!");
                                    Console.ReadKey();
                                    goto again;
                                }
                                if (firstoperation != 0)

                                {
                                    if (firstoperation < 10 || firstoperation == 19 || firstoperation == 24)
                                    {
                                        switch (firstoperation)
                                        {
                                            case 1:
                                                Console.Clear();
                                                Console.WriteLine("Please, enter a name, address, budget on the new Branch: ");
                                                string newname1 = Console.ReadLine();
                                                string newaddress1 = Console.ReadLine();
                                                decimal newbudget1 = decimal.Parse(Console.ReadLine());
                                                Branch branch = new Branch(newname1, newaddress1, newbudget1);
                                                branchService.Create(branch);
                                                goto again;

                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine("Please, enter a branch name to delete any branch: ");
                                                string deleteName = Console.ReadLine();
                                                if (deleteName != null)
                                                {
                                                    branchService.Delete(deleteName);
                                                }
                                                Console.ReadKey();
                                                goto again;

                                            case 3:
                                                Console.Clear();
                                                Console.WriteLine("Please, enter branch name to update: ");
                                                string updateName = Console.ReadLine();
                                                Console.WriteLine("Please, enter address and budget: ");
                                                string updateAddress = Console.ReadLine();
                                                int updateBudget = int.Parse(Console.ReadLine());
                                                if (updateBudget != 0 && updateAddress != null && updateName != null)
                                                {
                                                    branchService.Update(updateName, updateAddress, updateBudget);
                                                    branchService.GetAll();
                                                }
                                                Console.ReadKey();
                                                goto again;

                                            case 4:
                                                Console.Clear();
                                                Console.Write("Please, enter any branch name to find any branch: ");
                                                string getName1 = Console.ReadLine();
                                                if (getName1 != null)
                                                {
                                                    branchService.Get(getName1);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Please, enter a number that is not null, press any key to return");
                                                }
                                                Console.ReadKey();
                                                goto again;

                                            case 5:
                                                Console.Clear();
                                                branchService.GetAll();
                                                Console.ReadKey();
                                                goto again;

                                            case 6:
                                                Console.Clear();
                                                string branchName = Console.ReadLine();

                                                branchService.GetProfit(branchName);
                                                Console.ReadKey();
                                                goto again;

                                            case 7:
                                                Console.Clear();
                                                Console.WriteLine("Please, enter employee name to hire employee: ");
                                                string hireName = Console.ReadLine();
                                                branchService.HireEmployee(hireName);
                                                Console.ReadKey();
                                                goto again;

                                            case 8:
                                                Console.Clear();
                                                string name1= Console.ReadLine();
                                                string name2= Console.ReadLine();
                                                string name3 = Console.ReadLine();
                                                branchService.TransferEmployee(name1,name2,name3);
                                                Console.ReadKey();
                                                goto again;

                                            case 9:
                                                Console.Clear();
                                                Console.Write("Select First Branch: ");
                                                var first_branch = Console.ReadLine();
                                                Console.Write("Select Second Branch: ");
                                                var second_branch = Console.ReadLine();
                                                Console.Write("Enter budget: ");
                                                var budget = int.Parse(Console.ReadLine());
                                                branchService.TransferMoney(first_branch, second_branch, budget);
                                                branchService.GetAll();
                                                Console.ReadKey();
                                                goto again;

                                            case 19:
                                                Console.Clear();
                                                Console.WriteLine("Going back to main menu, press any key to continue");
                                                Console.ReadKey();
                                                goto again;

                                            case 24:
                                                Console.Clear();
                                                Console.WriteLine("Press any key to quit!");
                                                Console.ReadKey();
                                                Environment.Exit(0);
                                                break;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Exceeded limit, Please, select till 9 (included), press any key to return");
                                        Console.ReadKey();
                                        goto again;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please, enter a number that isn't null, press any key to return Menu");
                                    Console.ReadKey();
                                    goto again;
                                }
                                break;

                            case 2:
                                Console.Clear();
                                EmployeeMenu();
                                int secondoperation;
                                try
                                {
                                    secondoperation = int.Parse(Console.ReadLine());
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Input string was not in a correct format, press any key to continue");
                                    Console.ReadKey();
                                    goto again;
                                }
                                if (secondoperation != 0)
                                {
                                    if (secondoperation < 6 || secondoperation == 20 || secondoperation == 25)
                                    {
                                        switch (secondoperation)
                                        {
                                            case 1:
                                                Console.Clear();
                                                Console.WriteLine("Please, enter name, surname, salary and profession your order: ");
                                                string newName2 = Console.ReadLine();
                                                string newSurname2 = Console.ReadLine();
                                                int newSalary = int.Parse(Console.ReadLine());
                                                string newProfession = Console.ReadLine();

                                                if (newName2 != null && newSurname2 != null && newSalary != 0 && newProfession != null)
                                                {
                                                    Employee newemp = new Employee(newName2, newSurname2, newSalary, newProfession);
                                                    employeeService.Create(newemp);
                                                    Console.WriteLine(newemp.Name + " " + newemp.Surname + " " + newemp.Salary + " " + newemp.Profession);
                                                    employeeService.GetAll();
                                                    Console.ReadKey();
                                                    goto again;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Going back to main menu, press any key to continue");
                                                    Console.ReadKey();
                                                    goto again;
                                                }
                                                break;
                                            case 2:
                                                Console.Clear();
                                                Console.Write("Type in the name of an employee to delete it: ");
                                                string deleteEmp = Console.ReadLine();
                                                if (deleteEmp != null)
                                                {
                                                    employeeService.Delete(deleteEmp);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Going back to main menu, press any key to continue");
                                                    Console.ReadKey();
                                                    goto again;
                                                }
                                                break;
                                            case 3:
                                                Console.Clear();
                                                Console.WriteLine("Type in the name of an employee to update:");
                                                string updateName = Console.ReadLine();
                                                if(updateName != null)
                                                {
                                                    Console.WriteLine("Type in the new salary and the name of a new profession");
                                                    string name = Console.ReadLine();
                                                    decimal updateSalary = decimal.Parse(Console.ReadLine());
                                                    string updateProfession = Console.ReadLine();
                                                    
                                                    if (updateSalary != 0 && updateProfession != null)
                                                    {
                                                            employeeService.Update(name, updateProfession, updateSalary);
                                                            employeeService.GetAll();
                                                    }
                                                }
                                                Console.ReadKey();
                                                goto again;
                                            case 4:
                                                Console.Clear();
                                                Console.Write("Type in the name of an employee to find it: ");
                                                string getemp = Console.ReadLine();
                                                if (getemp != null)
                                                {
                                                    branchService.Get(getemp);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("This's a incorrect, press any key to continue!");
                                                }
                                                Console.ReadKey();
                                                goto again;
                                            case 5:
                                                Console.Clear();
                                                employeeService.GetAll();
                                                Console.ReadKey();
                                                goto again;
                                            case 20:
                                                Console.Clear();
                                                Console.WriteLine("Going back to main menu, press any key to continue");
                                                Console.ReadKey();
                                                goto again;
                                            case 25:
                                                Console.Clear();
                                                Console.WriteLine("Press any key to quit");
                                                Console.ReadKey();
                                                Environment.Exit(0);
                                                break;
                                            
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Press the digit that exists on screen");
                                        Console.ReadKey();
                                        goto again;
                                    }
                                    break;
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Either the username or the password is incorrect, try again!");
                        Console.ReadKey();
                        goto Login;
                    }
                }
            }
        }

        static void BranchMenu()
        {
            Console.WriteLine("Please, select your transaction: ");
            Console.WriteLine("Press 1 to to Create");
            Console.WriteLine("Press 2 to to Delete");
            Console.WriteLine("Press 3 to to Update");
            Console.WriteLine("Press 4 to to Get");
            Console.WriteLine("Press 5 to to GetAll");
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("Press 10 to go back to Main Menu");
            Console.WriteLine("Press 0 to quit and then press Enter to Quit");
        }

        static void EmployeeMenu()
        {
            Console.WriteLine("Please, select your transaction: ");
            Console.WriteLine("Press 1 to to Create");
            Console.WriteLine("Press 2 to to Update");
            Console.WriteLine("Press 3 to to Delete");
            Console.WriteLine("Press 4 to to Get");
            Console.WriteLine("Press 5 to to GetAll");
            Console.WriteLine("Press 6 to to Hire Employee");
            Console.WriteLine("Press 7 to to Get Profit");
            Console.WriteLine("Press 8 to to Transfer Employee");
            Console.WriteLine("Press 9 to to Transfer Money");
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("Press 10 to go back to Main Menu");
            Console.WriteLine("Press 0 to quit and then press Enter to Quit");

        }


        static void BranchAndEmployee()
        {
            Employee employee = new Employee("Amina", "Tagibeyli", 5500, "Cashier");
            Employee employee1 = new Employee("Jale", "Qasimzade", 4850, "Loan officer");
            Employee employee2 = new Employee("Milana", "Nabiyeva", 6000, "Programmer");
            Employee employee3 = new Employee("Adila", "Huseynova", 3840, "Financial Adviser");

            Branch branch = new Branch("Hezi", "Hezi Aslanov", 24000);
            Branch branch1 = new Branch("Azadliq", "Azadliq m", 15000);
            Branch branch2 = new Branch("Nizami", "Nizami m", 42000);
            Branch branch3 = new Branch("Nerimanov", "Neriman Nerimanov", 35000);

            branch.Employees.Add(employee);
            branch.Employees.Add(employee1);
            branch.Employees.Add(employee2);
            branch.Employees.Add(employee3);

        }


        
    }
}
