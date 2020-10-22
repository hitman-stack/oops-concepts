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

    public  void Sell(){
        Engage();
        EstablishTrust();
        AddressConcerns();
        DemoValue();
        Close();
    }
    protected abstract void Engage();
    protected abstract void EstablishTrust();
    protected abstract void AddressConcerns();
    protected abstract void DemoValue();
    protected abstract void Close();

}