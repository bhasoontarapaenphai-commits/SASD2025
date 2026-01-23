using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101.ShotgunSurgeryHard;


public class Constant
{
    public const string Owner = "Johny Black";
}
public class ShotgunA
{
    public void PrintReportA()
    {
        Console.WriteLine("Owner : " + Constant.Owner);
    }
}
public class ShotgunB
{
    public void PrintReportB()
    {
        Console.WriteLine("Signer : " + Constant.Owner);
    }



    public class Customer
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
    }
    public class CustomerReader
    {
        public Customer ReadCustomer()
        {
            string name = Console.ReadLine()!;
            string address = Console.ReadLine()!;
            return new Customer() { Name = name, Address = address };
        }
    }
    public class CustomerWriter
    {
        public void WriterCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Address);
        }
    }
}
