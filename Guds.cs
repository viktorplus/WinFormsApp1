using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace WinFormsApp1
{
    public class Oil
    {
        public String Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double Summa { get; set; }

        public Oil() {
            Name = string.Empty;
            Count = 0;
            Price = 0;
            Summa = 0;
        }
        public Oil (string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
            if (Count > 0)
            {
                Summa = Price * Count;
            }
            else
            {
                Summa = 0;
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
     public class Oils
    {
     public List<Oil> oil = new List<Oil>();
    }

    public class Gud
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public double Summa { get; set; }
        public Gud() {
            Name = string.Empty;
            Count = 0;
            Price = 0;
            Summa = 0;
        }
        public Gud (string name, int count, double price)
        {
            Name = name;
            Count = count;  
            Price = price;
            if (Count > 0)
            {
                Summa = Price * Count;
            }
            else
            {
                Summa = 0;
            }
        }
        public void SetCount(int count)
        {
            Count = count;
            if (Count > 0)
            {
                Summa = Price * count;
            }
            else
            {
                Summa = 0;
            }
        }
    }

    public class Guds
    {
       public List<Gud> gud = new List<Gud>(); 
    }
}
