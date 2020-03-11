using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TopGunLab2Pract.ModelAndLinq
{
   public class Enum: IEnumerable
    {
        public IEnumerator Enumerator { get; set; }

        public IEnumerator GetEnumerator()
        {
            return Enumerator;
        }
        public enum Position
        {
            Developer = 0,
            HumanResource = 1,
            Manager = 2,
            BusinessAnalit = 3,
            Tester = 4,
        }
        public enum City
        {
            Kyiv = 0,
            Kharkiv = 1,
            Odessa = 2,
            Lviv = 3,
            Dnepr = 4,

        }
        public enum CompanyName
        {
            TeamDev = 0,
            Epam = 1,
            Nix = 2,

        }
    }
}
