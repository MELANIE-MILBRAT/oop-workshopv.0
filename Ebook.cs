class Ebook : Media
 {
    private string language;
    private int pages;
    private int publicationYear;
    private string ISBN;

    public Ebook(string title, string creator, string language, int pages, int publicationYear, string ISBN) : base(title, creator)
    {
        this.language = language;
        this.pages = pages;
        this.publicationYear = publicationYear;
        this.ISBN = ISBN;
    }
    public void PreView()
    {
        Console.WriteLine("----- EBOOK PREVIEW -----");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + creator);
        Console.WriteLine("Language: " + language);
        Console.WriteLine("Number of pages: " + pages);
        Console.WriteLine("Publication year: " + publicationYear);
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("-------------------------");
        Console.WriteLine("Would you like to download this ebook?");
    }
}