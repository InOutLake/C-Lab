using C_Lab2;

public static class Program
{
    public static void Main(string[] args)
    {
        Manuscript myBook = new Manuscript(new DateOnly(2023, 9, 27), "John Doe", "The Epic Tale", "Fantasy", "First Edition");
        myBook.getReadByJhonny();
        GiveNobelWith50Chance(ref myBook);
        myBook.getReadByJhonny();

        Journal myJournal = new Journal(new DateOnly(2023, 9, 27), "Jane Smith", "Science Journal", "Science", 42);
        myJournal.getReadByJhonny();

        SchoolBook mySchoolBook = new SchoolBook(new DateOnly(2023, 9, 27), "Professor Johnson", "Mathematics Textbook", "Math", 7);
        mySchoolBook.getReadByJhonny();

        setOnFire(myJournal);
        setOnFire(mySchoolBook);

        myJournal.Clone();
        mySchoolBook.Clone();

        myJournal.getReadByJhonny();
        mySchoolBook.getReadByJhonny();
    }

    static void GiveNobelWith50Chance(ref Manuscript book)
    {
        Random random = new Random();
        if (random.Next(2) == 1)
        {
            book.giveNobel();
            Console.WriteLine("Jhonny awards the Nobel Prize to the book!");
        }
        else
        {
            Console.WriteLine("Jhonny did not award the Nobel Prize to the book.");
        }
    }

    static void setOnFire(IBurnable burnable)
    {
        burnable.burnToAshes();
    }

}