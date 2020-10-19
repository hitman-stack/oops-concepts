using System;

namespace Inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
                        CarSalesman johnTheSalesman= new CarSalesman("John","Wick");
            Console.WriteLine(johnTheSalesman.FullName);
            johnTheSalesman.Sell();

            
            RetailSalesPerson chandlerTheSalesman= new RetailSalesPerson("Chandler","Bing");
            Console.WriteLine(chandlerTheSalesman.FullName);
            chandlerTheSalesman.Sell();

            WebDeveloper angularLearn= new WebDeveloper("Angular 10");
            angularLearn.Code();
            angularLearn.develop();
        }
    }
}
