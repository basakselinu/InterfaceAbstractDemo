using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {
                Id = 1,
                DateOfBirth=new DateTime(2000,6,4),
                FirstName="Başak Selin",
                LastName="Ünsal",
                NationalityId="888888"
            });

            Console.ReadLine();
        }
    }
}