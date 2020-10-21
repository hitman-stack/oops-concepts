using System;
//This class is used to demonstrate purpose of static polymorphism
public abstract class StaticDeveloper
{
    private string _mainDevLanguage;
    public StaticDeveloper(string mainDevLanguage)
    {
        this._mainDevLanguage=mainDevLanguage;
    }
    #region Code written below uses static polymorphism where we will be demonstrating method overloading
    public virtual void Code()
    {
Console.WriteLine(string.Format("I am using {0} as my main dev language", this._mainDevLanguage));
    }
    public virtual void Code(string extraLanguage=null)
    {
        Console.WriteLine(string.Format("I am using {0} as my main dev language.I am also using {1} as my extra dev languages", this._mainDevLanguage,extraLanguage));
    }
    public virtual void Code(string firstExtraLanguage=null, string secondExtraLanguage= null)
    {
        Console.WriteLine(string.Format("I am using {0} as my main dev language. I am also using {1},{2} as my extra dev languages", this._mainDevLanguage,firstExtraLanguage,secondExtraLanguage));
    }
  
    
    #endregion

// #region Code written below is not the best approach to deal with the business scenario to handle different parameter as it is not readable and not maintable
//     public virtual void Code(string firstExtraLanguage=null, string secondExtraLanguage= null)
//     {
//             if (firstExtraLanguage == null && secondExtraLanguage== null)
//         {
//             Console.WriteLine(string.Format("I am using {0} as my main dev language", this._mainDevLanguage));
//         }
//            else if (firstExtraLanguage != null && secondExtraLanguage!= null)
//         {
//             Console.WriteLine(string.Format("I am using {0} as my main dev language. I am also using {1},{2} as my extra dev languages", this._mainDevLanguage,firstExtraLanguage,secondExtraLanguage));
//         }
//            else if (firstExtraLanguage != null)
//         {
//             Console.WriteLine(string.Format("I am using {0} as my main dev language.I am also using {1} as my extra dev languages", this._mainDevLanguage,firstExtraLanguage));
//         } 
         
//          else if (secondExtraLanguage!= null)
//         {
//             Console.WriteLine(string.Format("I am using {0} as my main dev language.I am also using {1} as my extra dev languages", this._mainDevLanguage,secondExtraLanguage));
//         }
//     }
//     #endregion
}