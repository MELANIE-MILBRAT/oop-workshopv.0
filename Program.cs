class Program
{
    static void Main(string []args)
    {
        Console.WriteLine("Hej");

        //Ebog lavet
        Ebook harryPotter = new Ebook ("Harry Potter and the Philosopher's Stone", "J.K. Rowling", "English", 360, 2015, "9788702173222");
        harryPotter.View();
        //Film lavet
        Movies piratesOfTheCarabian = new Movies ("Pirates of the Caribbean: The Curse of the Black Pearl", "Jerry Bruckheime", "fantasy swashbuckler", 2003, "English", "143 minutes","A mysteriou sship appears tr´hrough the fog as cannon fire tears across the sea. Captain Jack Sparrow draws his sword and smiles. Cursed pirates are closing in... and the battle for a legendary treasure has begun");
        piratesOfTheCarabian.Watch();
    }
    
}