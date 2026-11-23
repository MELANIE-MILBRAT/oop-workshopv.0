class Ebook : Media
 {
    protected string language;
    protected int pages;
    protected int publicationDate;
    protected string ISBN;

    public Ebook(string title, string author, string language, int pages, int publicationDate, string ISBN): base(title, author)
    {
        this.language = language;
        this.pages = pages;
        this.publicationDate = publicationDate;
        this.ISBN = ISBN;
    }
}