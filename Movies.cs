class Movies : Media
 {
    protected string genre;
    protected int releaseDate;
    protected string language;
    protected int duration;

    public Moves(string title, string author, string genre, int releaseDate, string language, int duration): base(title, author)
    {
        this.genre = genre;
        this.releaseDate = releaseDate;
        this.language = language;
        this.duration = duration;
    }