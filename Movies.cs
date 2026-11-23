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
    public void Watch()
    {
        Console.WriteLine("Watch scene: ");
        Console.WriteLine("A mysteriou sship appears tr´hrough the fog as cannon fire tears across the sea. Captain Jack Sparrow draws his sword and smiles. Cursed pirates are closing in... and the battle for a legendary treasure has begun");
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