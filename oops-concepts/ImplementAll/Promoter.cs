public abstract class Promoter
{
    
    private string _firstname;
    private string _lastName;
    private long _cellPhone;

    protected Promoter(string firstName, string lastName, long cellPhone)
    {
        _firstname= firstName;
        _lastName= lastName;
        _cellPhone= cellPhone;
    }

    public string AuthorBio
    {
        get
        {
            return string.Format("{0}{1}{3}",this._firstname,this._lastName,this._cellPhone);
        }
    }
 public  void Promote()
 {
  ShareWithInnerCircle();
  UsePaidAds();   
 } 
 protected abstract void ShareWithInnerCircle();
 protected abstract void UsePaidAds(); 
}