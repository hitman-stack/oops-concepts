using System;
//This class is used to demonstrate purpose of static polymorphism
public class StaticWebDeveloper : StaticDeveloper
{
    public StaticWebDeveloper(string mainDevLanguage) : base(mainDevLanguage)
    {
    }
    public void Develop()
    {
        Console.WriteLine("Hey there we are demonstrating Static polymorphism");
    }
}