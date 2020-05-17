using Interface2;
using System;

namespace Inteface2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            
            Console.ReadLine();
        }

        
    }
   
}
