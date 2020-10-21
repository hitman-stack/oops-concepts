
using System;
//We are inheriting from Salesman so it will be our Base class or parent class
//Here RetialSalesPerson will be a subclass or a child class 
public class OnlineMarketer : Salesman
{
    //base reserve keyword here is just saying that we are using the base classes constructor
    //Instead of taking the  first name and last name and setting them to fileds in the concrete class
    //which doesn't have any we take those and pass down to the base constructor so that the abstract
    //abstract class can set those fileds

    public OnlineMarketer(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Sell()
    {
        Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to but this gun!", this.FullName));
    }
}