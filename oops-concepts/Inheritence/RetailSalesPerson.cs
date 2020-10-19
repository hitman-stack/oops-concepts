
using System;
#region In this block we are inheriting salesman class and the code is done to pass on the values and override the sales method
//We are inheriting from Salesman so it will be our Base class or parent class
//Here RetialSalesPerson will be a subclass or a child class 
public class RetailSalesPerson : Salesman,SelfDeveloping
{
    //base reserve keyword here is just saying that we are using the base classes constructor
    //Instead of taking the  first name and last name and setting them to fileds in the concrete class
    //which doesn't have any we take those and pass down to the base constructor so that the abstract
    //abstract class can set those fileds

    public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public void develop()
    {
        Console.WriteLine("Hey I am in Retailsales person class ");
    }

    public override void Sell()
    {
        Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to but this pen!", this.FullName));
    }
}
#endregion

// #region  In the below code block we will be implementing the interface and the code block will change to assing the values 
// public class RetailSalesPerson : SalesmanInterface
// {
//     //base reserve keyword here is just saying that we are using the base classes constructor
//     //Instead of taking the  first name and last name and setting them to fileds in the concrete class
//     //which doesn't have any we take those and pass down to the base constructor so that the abstract
//     //abstract class can set those fileds
// private string _firstName;
// private string _lastName;
//     public RetailSalesPerson(string firstName, string lastName)
//     {
//         _firstName=firstName;
//         _lastName=lastName;
//     }

//     public string FullName {
//         get 
//         {
//             return string.Format("{0}{1}",this._firstName,this._lastName);
//         }
//     }

//     public  void Sell()
//     {
//         Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to but this pen!", this.FullName));
//     }
// }
// #endregion