using System;
#region  in below code block we are inheriting salesman abstract class
public class CarSalesman : Salesman
{
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Sell()
    {
        Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to but this car!", this.FullName));
    }
}
#endregion

// #region In below code block we implementing salesman interface 
// public class CarSalesman : SalesmanInterface
// {
//     //base reserve keyword here is just saying that we are using the base classes constructor
//     //Instead of taking the  first name and last name and setting them to fileds in the concrete class
//     //which doesn't have any we take those and pass down to the base constructor so that the abstract
//     //abstract class can set those fileds
// private string _firstName;
// private string _lastName;
//     public CarSalesman(string firstName, string lastName)
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
//         Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to but this car!", this.FullName));
//     }
// }
// #endregion
