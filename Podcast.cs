class Podcast : Media
{
    private int releaseYear;
    private string guest;
    private int episodeNumber;
    private string language;

    public Podcast(string title, int releaseYear, string creator, string guest, int episodeNumber, string language) :base(title, creator)

    {
        this.releaseYear = releaseYear;
        this.guest = guest;
        this.episodeNumber = episodeNumber;
        this.language = language;
    }
}