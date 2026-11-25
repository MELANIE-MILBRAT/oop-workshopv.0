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
        
        switch(mediaType)
        {
            case "Ebook":
                Console.WriteLine("DE HER TING");
                break;
                
            case "Movie":
                Console.WriteLine("DE HER TING");
                break;
                
            case "Song":
                Console.WriteLine("DE HER TING");
                break;

            case "Video Game":
                Console.WriteLine("DE HER TING");
                break;

            case "App":
                Console.WriteLine("DE HER TING");
                break;

            case "Podcast":
                Console.WriteLine("DE HER TING");
                break;

            case "Image":
                Console.WriteLine("DE HER TING");
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
        Console.WriteLine("with , inbetween");

        //string[] whatconstrukter = placeholdr.Split(',');
        //Console.WriteLine(whatconstrukter[0]+whatconstrukter[1]+whatconstrukter[2]........);
    }
}
