using System;
using System.Collections.Generic;
using System.Text;
using TopGunLab2Pract.ModelAndLinq;

namespace TopGunLab2Pract.List
{
   public class WorkerList
    {
      
     

            public List<Worker> allWorkers = new List<Worker>();

            public void Add(Worker worker)
            {
                if (!Contains(worker))
                {
                allWorkers.Add(worker);
                    Console.WriteLine($"Worker {worker.Name} added to list");
                }
                else
                {
                    Console.WriteLine($"Worker {worker.Name} already exists in list of workers");
                }
            }

            public bool Contains(Worker Worker)
            {
                if (allWorkers.Contains(Worker))
                {
                    return true;
                }
                return false;
            }

            public void Remove(Worker worker)
            {
                if (allWorkers.Contains(worker))
                {
                allWorkers.Remove(worker);
                    Console.WriteLine($"Worker {worker.Name} removed from list succesfully");
                }
                else
                {
                    Console.WriteLine($"Worker {worker.Name} doesn't exist in Worker list");
                }
            }

            public void ResetGame()
            {
                allWorkers.Clear();
            }

            public IEnumerable<Worker> GetElements()
            {

                foreach (Worker t in allWorkers)
                {
                    Console.Write(t.Name + " ");
                }
                return this.allWorkers;
            }

            public List<Worker> GetElementsList()
            {
                return this.allWorkers;
            }
        }
    

}

