class Program
{
    static void Main(string []args)
    {
        Console.WriteLine("Hej");

        Ebook ebook;
        
        Ebook harryPotter = new Ebook ("Harry Potter and the Philosopher's Stone", "J.K. Rowling", "English", 360, 2015, 
           "9788702173222");

        harryPotter.View();
    }
    
}