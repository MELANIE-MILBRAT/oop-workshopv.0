class Movies : Media
 {
    private string genre;
    private int releaseDate;
    private string language;
    private int duration;
    private string scene;

    public Movies(string title, string creator, string genre, int releaseDate, string language, int duration, string scene) : base(title, creator)
    {
        this.genre = genre;
        this.releaseDate = releaseDate;
        this.language = language;
        this.duration = duration;
        this.scene = scene;
    }
    public void Watch()
    {
        Console.WriteLine("Watch scene: ");
        Console.WriteLine(scene);
        Console.WriteLine("----- EBOOK PREVIEW -----");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + creator);
        Console.WriteLine("Genre: " + genre);
        Console.WriteLine("ReleaseDate: " + releaseDate);
        Console.WriteLine("Language: " + language);
        Console.WriteLine("Duration: " + duration);
        Console.WriteLine("-------------------------");
        Console.WriteLine("Would you like to download this Movie?");
    }
 }