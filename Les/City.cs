using System;
using System.Collections.Generic;

namespace Les
{
    public struct City : IComparable<City>
    {
        public string Name { get; set; }

        public int Population { get; set; }

        public static bool operator >(City c1, City c2)
        {
            return c1.Population > c2.Population;
        }

        public static bool operator <(City c1, City c2)
        {
            return c1.Population < c2.Population;
        }

        public int CompareTo(City o)
        {
            //var c = o as City;
            //if (c != null)
            //    return this.Name.Length.CompareTo(c.Name.Length);
            //else
            //    throw new Exception("Невозможно сравнить два объекта");
            return this.Population.CompareTo(o.Population);
        }


    }

    public sealed class CityComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            if (x.Population > y.Population)
                return 1;
            else if (x.Population < y.Population)
                return -1;
            else
                return 0;
        }
    }
}
