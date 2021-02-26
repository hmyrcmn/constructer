using System;

namespace constructer_yapıcıblok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer customer1 = new Customer();//yapıcı blok çalışır 
            customer1.Id = 1;
            customer1.Name = " hüm";
            customer1.City = " kayseri";
            Console.WriteLine(customer1.Id+customer1.Name+customer1.City);

            Customer customer2 = new Customer(2, " süm", " kay"); //parametre olarak çalışan blokda veriler bu şekilde verilir
            Console.WriteLine(customer2.Id + customer2.Name+customer2.City);

            Console.WriteLine("**************************");
            Customer customer3 = new Customer() {Id=3,Name="ayşe ",City="yesilhisar " };
            Console.WriteLine(customer3.City+customer3.Name+customer3.Id);
        }
    }
    class Customer
    {
        public Customer()//parametre almadan çalışan blokda 
        {
            Console.WriteLine("yapıcı metod çalıstı--- the constructer is worked! ");
            // yapıcı blok newlediğimiz zaman çalışan bloktur 
        }
        public Customer(int id, string name, string city)
        {
            Console.WriteLine("parametre alarak çalışan blok--- the blok worked with parametre ");
            Id = id;
            Name = name;
            City = city;


        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }


    }
}
