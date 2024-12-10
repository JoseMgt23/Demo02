using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public abstract class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int GeInt()
        {
            return 5;
        }

        public virtual decimal CalculaMonthlyPayment()
        {
            return 12000;
        }
    }

    public class Secretary : Employee
    {
        public override decimal CalculaMonthlyPayment() => 15000;
        
    }

    public class Manager : Employee
    {
        public override decimal CalculaMonthlyPayment()
        {
            return 30000;
        }
    }

    public class Developer : Employee
    {

    }

}
