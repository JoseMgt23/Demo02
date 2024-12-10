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

        public abstract decimal CalculaMonthlyPayment();
    }

    public class Secretary : Employee
    {
        public override decimal CalculaMonthlyPayment() => 15000;
        
    }

    public class Manager : Employee
    {

    }
        
}
