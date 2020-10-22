using System;

public class BookWriter : Writer
{
    public BookWriter(string firstname, string lastName) : base(firstname, lastName)
    {
    }

    public override void Vlog()
    {
        Console.WriteLine("I love making vlogs using Iphone.");
    }

    public override void Write()
    {
        Console.WriteLine("I love to write vlogs on mountains trecking.");
    }
}