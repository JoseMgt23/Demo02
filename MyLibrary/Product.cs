using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Product(int id, string name, decimal unitPrice, int unitsInStock)
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
        public decimal UnitPrice { get; } = unitPrice;
        public int UnitsInStock { get;} = unitsInStock;

    }


}
