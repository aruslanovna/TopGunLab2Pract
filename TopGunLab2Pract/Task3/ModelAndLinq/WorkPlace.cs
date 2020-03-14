using System;
using System.Collections.Generic;
using System.Text;
using static TopGunLab2Pract.ModelAndLinq.Enum;

namespace TopGunLab2Pract.ModelAndLinq
{
   public class WorkPlace
    {
        public int Id { get; set; }
        public CompanyName Name { get; set; }
        public City city { get; set; }
        public string About { get; set; }
       
    }

  
}
