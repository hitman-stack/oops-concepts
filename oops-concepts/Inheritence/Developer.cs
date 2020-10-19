using System;

public class Developer
{
private string _mainDevLanguage;
    public Developer(string mainDevLanguage) 
    {
        _mainDevLanguage=mainDevLanguage;
    }

    public virtual void Code()
    {
        Console.WriteLine(string.Format("Hey I love coding on {0}!", this._mainDevLanguage));
    }
}
