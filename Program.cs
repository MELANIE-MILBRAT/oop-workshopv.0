class Program
{
    static void Main(string []args)
    {
        Console.WriteLine("Hej");

        //Ebog lavet
        Ebook harryPotter = new Ebook ("Harry Potter and the Philosopher's Stone", "J.K. Rowling", "English", 360, 2015, "9788702173222");
        harryPotter.PreView();

        //Film lavet
        Movies piratesOfTheCarabian = new Movies ("Pirates of the Caribbean: The Curse of the Black Pearl", "Jerry Bruckheime", "Fantasy swashbuckler", 2003, "English", "143 minutes","A mysterious ship appears through the fog as cannon fire tears across the sea. Captain Jack Sparrow draws his sword and smiles. Cursed pirates are closing in... and the battle for a legendary treasure has begun");
        piratesOfTheCarabian.PreWatch();
       
        //Sang lavet
        Songs cruelSummer = new Songs ("Cruel Summer", "Taylor Swift", "synth-pop and electropop", "MP4", "English", "2 minutes and 58 seconds");
        cruelSummer.PreHear();
    }
    
}