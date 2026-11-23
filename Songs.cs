class Songs : Media
 {
    private string genre;
    private int releaseYear;
    private string language;
    private string duration;

    public Songs (string title, string creator, string genre, int releaseYear, string language, string duration) : base(title, creator)
    {
        this.genre = genre;
        this.releaseYear = releaseYear;
        this.language = language;
        this.duration = duration;
        
    }
}

    