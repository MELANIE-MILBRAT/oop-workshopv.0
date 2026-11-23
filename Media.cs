class Media
{
    protected string title;
    protected string creator;
    
    public Media(string title, string creator)
    {
        this.title = title;
        this.creator = creator;
    }
    
    public void Download ()
    {
        Console.WriteLine("Download complete, enjoy!");
    }
    
}