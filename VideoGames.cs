class VideoGames : Media
{
    private string genre;
    private int releaseYear;
    private string supportedPlatforms;

    public VideoGames(string title, string genre, string creator, int releaseYear, string supportedPlatforms) :base(title, creator)

    {
        this.genre = genre;
        this.releaseYear = releaseYear;
        this.supportedPlatforms = supportedPlatforms;
    }
}