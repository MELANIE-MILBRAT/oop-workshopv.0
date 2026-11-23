class Movies : Media
 {
    private string genre;
    private int releaseDate;
    private string language;
    private int duration;

    public Movies(string title, string creator, string genre, int releaseDate, string language, int duration) : base(title, creator)
    {
        this.genre = genre;
        this.releaseDate = releaseDate;
        this.language = language;
        this.duration = duration;
    }
 }