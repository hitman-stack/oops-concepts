using System;

public class BlogWriter : Writer
{
    public BlogWriter(string firstname, string lastName) : base(firstname, lastName)
    {
    }

    public override void Vlog()
    {
        Console.WriteLine("I vlog using GOPro.");
    }

    public override void Write()
    {
Console.WriteLine("I love writing my vlog regarding Nature.");
    }
}