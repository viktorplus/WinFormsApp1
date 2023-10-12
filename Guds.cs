using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
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
        public Gud (string name, int coumt, double price)
        {
            Name = name;
            Count = coumt;  
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
