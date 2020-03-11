using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static TopGunLab2Pract.ModelAndLinq.Enum;

namespace TopGunLab2Pract.ModelAndLinq
{
   public class Worker :IEnumerable
    {   
        public int Id { get; set; }
        public string Name { get; set; }       
        public City City { get; set; }
        public CompanyName CompanyName { get; set; }
        public Position Position { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }


        public IEnumerator Enumerator { get; set; }

        public IEnumerator GetEnumerator()
        {
            return Enumerator;
        }
    }
   
}
