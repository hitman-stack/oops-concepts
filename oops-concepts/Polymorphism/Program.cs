using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Below code demonstrate static polymorphism
            StaticWebDeveloper devLanguage= new StaticWebDeveloper("Angular");
            devLanguage.Code();
             devLanguage.Code("C#");
              devLanguage.Code("C#",".Net Core");
               devLanguage.Code(null,"NodeJs");
            //Why we  need dynamic polymorphism Start
            List<object> salesmen = new List<object>() {new CarSalesman("Joey","Tribbiani"),new CarSalesman("Phoebe","Buffey"), new RetailSalesPerson("Chandler","Bing")};
            foreach(var item in salesmen)
            {
                ShowHowToSell(item);
            }
            //Why we  need dynamic polymorphism END
             List<Salesman> salesmenDynamic = new List<Salesman>() 
             {new CarSalesman("Joey","Tribbiani"),new CarSalesman("Phoebe","Buffey"), new RetailSalesPerson("Chandler","Bing"), new OnlineMarketer("Rachel","Green")};
            foreach(var item in salesmenDynamic)
            {
                ShowHowToSellDynamic(item);
            }
        }
        static void ShowHowToSellDynamic(Salesman salesman)
        {
salesman.Sell();
        }
        //If we need to add more types then we will have to explicityly code it which is not great and that's where we will use dynamic polymorphis,
//Why we  need dynamic polymorphism Start
        static void ShowHowToSell(Object salesman)
        {
            if(salesman is CarSalesman)
            {
                CarSalesman carSalesman= (CarSalesman) salesman;
                carSalesman.Sell();
            }
                else
            {
                RetailSalesPerson retailSalesPerson= (RetailSalesPerson) salesman;
                retailSalesPerson.Sell();
            }
        }
        //Why we  need dynamic polymorphism END
        
    }
}
