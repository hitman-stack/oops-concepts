public abstract class Writer:IVlogger
{
    private string _firstname;
    private string _lastName;
    protected Writer(string firstname, string lastName)
    {
        this._firstname=firstname;
        this._lastName=lastName;
    }
    public string AuthorBio
    {
        get{
            return string.Format("My name is {0}{1}",this._firstname,this._lastName);
        }
    }

    public abstract void Vlog();

    public abstract void Write();
}