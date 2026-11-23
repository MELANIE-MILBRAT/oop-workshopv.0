class Songs : Media
 {
    private string singer;
    private string genre;
    private string fileType;
    private string language;
    private string duration;

    public Songs (string title, string creator, string singer, string genre, string fileType, string language, string duration) : base(title, creator)
    {
        this.singer = singer;
        this.genre = genre;
        this.fileType = fileType;
        this.language = language;
        this.duration = duration;
        
    }
}

    