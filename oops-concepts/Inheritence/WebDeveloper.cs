
using System;

public class WebDeveloper : Developer,SelfDeveloping
{
    public WebDeveloper(string mainDevLanguage) : base(mainDevLanguage)
    {
    }
    public void develop()
    {
        Console.WriteLine("Hey how you doin!");
    }
}

