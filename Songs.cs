class Songs : Media
 {
    private string genre;
    private string fileType;
    private string language;
    private string duration;

    public Songs (string title, string creator, string genre, string fileType, string language, string duration) : base(title, creator)
    {
        this.genre = genre;
        this.fileType = fileType;
        this.language = language;
        this.duration = duration;
    }
    public void PreHear()
    {
        Console.WriteLine("----- HEAR PREVIEW -----");
        Console.WriteLine("▶ ━━━●━━━━━━━━━━━━ 0:15 / " + duration);
        Console.WriteLine("  ▁▂▄▆█▇▅▃▂▁▃▅▇█▆▄▂▁▂▄▇▅▃▁");
        Console.WriteLine();
    
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Singer: " + creator);
        Console.WriteLine("Genre: " + genre);
        Console.WriteLine("File type: " + fileType);
        Console.WriteLine("Language: " + language);
        Console.WriteLine("Duration: " + duration);
        Console.WriteLine("-------------------------");
        Console.WriteLine("Would you like to download this song?");
                Console.WriteLine("");
    }
}

    