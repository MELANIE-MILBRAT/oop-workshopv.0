class Employee : User
{
    public Employee (string name, string age, string CPR, string role) :base (name, age, CPR, role)
    {
        
    }
    public void employeeAdd()
    {
        Console.WriteLine("What type of media would you like to add?");
        Console.WriteLine("- Ebook");
        Console.WriteLine("- Movie");
        Console.WriteLine("- Song");
        Console.WriteLine("- Video Game");
        Console.WriteLine("- App");
        Console.WriteLine("- Podcast");
        Console.WriteLine("- Image");

        string mediaType = Console.ReadLine();

        Console.WriteLine("You chose " + mediaType + ":");

        Console.WriteLine("Please enter: ");

        string input;
        switch(mediaType)
        {
            case "Ebook":
                Console.WriteLine("DE HER TING");
                input = Console.ReadLine();
                
                break;
                
            case "Movie":
                Console.WriteLine("DE HER TING");
                input = Console.ReadLine();
                break;
                
            case "Song":
                Console.WriteLine("DE HER TING");
                input = Console.ReadLine();
                break;

            case "Video Game":
                Console.WriteLine("DE HER TING");
                input = Console.ReadLine();
                break;

            case "App":
                Console.WriteLine("DE HER TING");
                input = Console.ReadLine();
                break;

            case "Podcast":
                Console.WriteLine("DE HER TING");
                input = Console.ReadLine();
                break;

            case "Image":
                Console.WriteLine("DE HER TING");
                input = Console.ReadLine();
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}
