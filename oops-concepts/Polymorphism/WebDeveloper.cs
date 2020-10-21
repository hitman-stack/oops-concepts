using System;

public class WebDeveloper : Developer
{
    public WebDeveloper(string mainDevLanguage) : base(mainDevLanguage)
    {
    }
    public void Develop()
    {
        Console.WriteLine("Hey there this is a turoial follow up video.");
    }
}