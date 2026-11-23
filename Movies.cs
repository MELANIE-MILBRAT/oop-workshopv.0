class Movies : Media
 {
    private string genre;
    private int releaseDate;
    private string language;
    private string duration;
    private string scene;

    public Movies(string title, string creator, string genre, int releaseDate, string language, string duration, string scene) : base(title, creator)
    {
        this.genre = genre;
        this.releaseDate = releaseDate;
        this.language = language;
        this.duration = duration;
        this.scene = scene;
    }
    public void PreWatch()
    {
        Console.WriteLine("----- MOVIE PREVIEW -----");
        Console.WriteLine("Watch scene: " + scene);
        Console.WriteLine ();
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + creator);
        Console.WriteLine("Genre: " + genre);
        Console.WriteLine("Release year: " + releaseDate);
        Console.WriteLine("Language: " + language);
        Console.WriteLine("Duration: " + duration);
        Console.WriteLine("-------------------------");
        Console.WriteLine("Would you like to download this Movie?");
    }
 }