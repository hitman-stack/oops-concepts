
using System;
//We are inheriting from Salesman so it will be our Base class or parent class
//Here RetialSalesPerson will be a subclass or a child class 
public class RetailSalesPerson : Salesman
{
    //base reserve keyword here is just saying that we are using the base classes constructor
    //Instead of taking the  first name and last name and setting them to fileds in the concrete class
    //which doesn't have any we take those and pass down to the base constructor so that the abstract
    //abstract class can set those fileds

    public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
    {
    }
    public void Develop()
    {
        Console.WriteLine("I love working with C#");
    }

    protected override void AddressConcerns()
    {
        Console.WriteLine("Here is 50% discount for you.");
    }

    protected override void Close()
    {
       Console.WriteLine("Buy this pen.");
    }

    protected override void DemoValue()
    {
        Console.WriteLine("You are awesome!");
    }

    protected override void Engage()
    {
        Console.WriteLine("Hello");
    }

    protected override void EstablishTrust()
    {
        Console.WriteLine("Hey how can I help you!");
    }
}