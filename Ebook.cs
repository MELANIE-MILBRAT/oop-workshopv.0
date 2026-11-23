class Ebook : Media
 {
    private string language;
    private int pages;
    private int publicationDate;
    private string ISBN;

    public Ebook(string title, string creator, string language, int pages, int publicationDate, string ISBN) : base(title, creator)
    {
        this.language = language;
        this.pages = pages;
        this.publicationDate = publicationDate;
        this.ISBN = ISBN;
    }
}