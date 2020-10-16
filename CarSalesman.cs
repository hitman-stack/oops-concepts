using System;
public class CarSalesman
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
    public CarSalesman(string firstName,string lastName)
    {
this._firstName=firstName;
this._lastName=lastName;
    }

    public void Sell()
    {
       Console.WriteLine(string.Format("Hi my name is {0}. I would like you to buy this car!",this.FullName));
    }
}