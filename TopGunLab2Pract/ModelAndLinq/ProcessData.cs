using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static TopGunLab2Pract.ModelAndLinq.Enum;
using System.Collections;

namespace TopGunLab2Pract.ModelAndLinq
{
   public class ProcessData 
    {
        List<Worker> workerList = new List<Worker>()
        {
            new Worker() { Id = 1, Name = "Igor", Age = 20, Position = Position.Developer, Salary = 200, City = City.Odessa, CompanyName = CompanyName.Epam },
        new Worker() { Id = 2, Name = "Oleg", Age = 30, Position = Position.BusinessAnalit, Salary = 100, City = City.Kharkiv, CompanyName = CompanyName.TeamDev },
         new Worker() { Id = 3, Name = "Pavel", Age = 14, Position = Position.BusinessAnalit, Salary = 200, City = City.Kharkiv, CompanyName = CompanyName.TeamDev },
         new Worker() { Id = 4, Name = "Mark", Age = 30, Position = Position.Developer, Salary = 400, City = City.Kharkiv, CompanyName = CompanyName.Epam },
         new Worker() { Id = 5, Name = "Mark", Age = 40, Position = Position.Developer, Salary = 230, City = City.Lviv, CompanyName = CompanyName.Nix },
        new Worker() { Id = 6, Name = "Sasha", Age = 32, Position = Position.Developer, Salary = 280, City = City.Odessa, CompanyName = CompanyName.Nix }

    };


        List<WorkPlace> workPlaceList = new List<WorkPlace>()
        {
            new WorkPlace() {Id = 1, city= City.Dnepr, Name= CompanyName.Epam, NumberOfWorkers=100 },
        new WorkPlace() { Id = 2, city = City.Dnepr, Name = CompanyName.TeamDev, NumberOfWorkers = 100 },
        new WorkPlace() { Id = 3, city = City.Kharkiv, Name = CompanyName.TeamDev, NumberOfWorkers = 140 },
         new WorkPlace() { Id = 4, city = City.Kyiv, Name = CompanyName.Nix, NumberOfWorkers = 200 },
         new WorkPlace() { Id = 5, city = City.Lviv, Name = CompanyName.Nix, NumberOfWorkers = 100 },
         new WorkPlace() { Id = 6, city = City.Odessa, Name = CompanyName.Epam, NumberOfWorkers = 300 }
    };
        public IEnumerable<Worker> GetAll()
        {
            var workers = workerList.Select(x => x).ToList();
            return workers;

        }
        public List<Worker> GetOlderThanFifty()
        {
            var workers = workerList.Select(x => x).Where(x => x.Age >= 50).ToList();
                return workers;
        }
      
        public void GetWorkersGroupByCompany()
        {

            var workersByCompany = from worker in workerList
                          group worker by worker.CompanyName;

            foreach (var company in workersByCompany)
            {
                Console.WriteLine("Workers from {0}: ", company.Key);
                foreach (var worker in company)
                    Console.WriteLine(worker.Name);
                Console.WriteLine();
            }
        }


      

    }
}
