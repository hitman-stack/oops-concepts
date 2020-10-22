using System;
public class CarSalesman : Salesman
{
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {
    }
    protected override void AddressConcerns()
    {
        Console.WriteLine("Here is 20% discount for you.");
    }

    protected override void Close()
    {
       Console.WriteLine("Buy this car.");
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