using System;

namespace EncapsulationAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
                        //Demosntrating that we can use sell method from Retailsalesperson class as it is defined a public
            RetailSalesPerson retailSalesPerson= new RetailSalesPerson("John","Wick");
            retailSalesPerson.Develop();

            //Demonstrating we can access protected members within the class and inheriting class
            //We are also demonstrating abstraction here as you can see we wanted to show sell method so we made it public but we didn't wanted other methods to show here so specified them as protected
            CarSalesman carSalesman = new CarSalesman("Carl","Cox");
            carSalesman.Sell();
        }
    }
}
