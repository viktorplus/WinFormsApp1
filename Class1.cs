using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Good
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public decimal PricePerOne { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }

        public Good(string name, string description, int amount, decimal pricePerOne, DateTime date)
        {
            Name = name;
            Description = description;
            Amount = amount;
            PricePerOne = pricePerOne;
            Date = date;
            TotalPrice = amount * pricePerOne;
        }

        public override string ToString()
        {
            return $"{Name} : {Description}  |  {Amount} * {PricePerOne} = {TotalPrice}  |  {Date}";
        }

    }

}
