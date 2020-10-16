using System;

public abstract class Salesman
{
    //fields are started with _abc
    private string _firstName; //Keep your fields private 
    private string _lastName;
    //expose property as public
    //properties starts with Captial case
    public string FullName{
        get{
            return string.Format("{0}{1}",this._firstName,this._lastName);
        }
    }
    public Salesman(string firstName,string lastName)
    {
this._firstName=firstName;
this._lastName=lastName;
    }

    public virtual void Sell()
    {
        Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to but this item!", this.FullName));
    }    
    
}