using System;

namespace oops_concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman mohitTheSalesman= new CarSalesman("Mohit","Mishra");
            Console.WriteLine(mohitTheSalesman.FullName);
            mohitTheSalesman.Sell();

            CarSalesman sunnyTheSalesman= new CarSalesman("Sunny","Singh");
            Console.WriteLine(sunnyTheSalesman.FullName);
            sunnyTheSalesman.Sell();
        }
    }
}
