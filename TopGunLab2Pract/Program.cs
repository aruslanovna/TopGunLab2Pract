using System;
using System.Collections.Generic;
using System.Linq;
using TopGunLab2Pract.ModelAndLinq;

namespace TopGunLab2Pract
{
   
        class Program
        {
            static void Main(string[] args)
            {

            //WorkPlace wp1 = new WorkPlace() {Id = 1, city= City.Dnepr, Name=Name.Epam, NumberOfWorkers=100 };
            //WorkPlace wp2 = new WorkPlace() { Id = 2, city = City.Dnepr, Name = Name.TeamDev, NumberOfWorkers = 100 };
            //WorkPlace wp3 = new WorkPlace() { Id = 3, city = City.Kharkiv, Name = Name.TeamDev, NumberOfWorkers = 140 };
            //WorkPlace wp4 = new WorkPlace() { Id = 4, city = City.Kyiv, Name =Name.Nix, NumberOfWorkers = 200 };
            //WorkPlace wp5 = new WorkPlace() { Id = 5, city = City.Lviv, Name = Name.Nix, NumberOfWorkers = 100 };
            //WorkPlace wp6 = new WorkPlace() { Id = 6, city = City.Odessa, Name = Name.Epam, NumberOfWorkers = 300 };

            //Worker w1 = new Worker() { Id = 1, Name = "Igor", Experience = 20, Position = Position.Developer, Salary = 200, City = City.Odessa, CompanyName = CompanyName.Epam };
            //Worker w2 = new Worker() { Id = 2, Name = "Oleg", Experience = 30, Position = Position.BusinessAnalit, Salary = 100, City = City.Kharkiv, CompanyName = CompanyName.TeamDev };
            //Worker w3 = new Worker() { Id = 3, Name = "Pavel", Experience = 14, Position = Position.BusinessAnalit, Salary = 200, City = City.Kharkiv, CompanyName = CompanyName.TeamDev };
            //Worker w4 = new Worker() { Id = 4, Name = "Mark", Experience = 30, Position = Position.Developer, Salary = 400, City = City.Kharkiv, CompanyName = CompanyName.Epam };
            //Worker w5 = new Worker() { Id = 5, Name = "Mark", Experience = 40, Position = Position.Developer, Salary = 230, City = City.Lviv, CompanyName = CompanyName.Nix };
            //Worker w6 = new Worker() { Id = 6, Name = "Sasha", Experience = 32, Position = Position.Developer, Salary = 280, City = City.Odessa, CompanyName = CompanyName.Nix };


            ProcessData pr = new ProcessData();
            pr.GetWorkersGroupByCompany();

            Fibonacci fib = new Fibonacci();
                 fib.Count(6);

                Factorial fact = new Factorial();
                  fact.Count(7);

                Console.ReadKey();
            }
           


          
        }
    
}
