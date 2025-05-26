namespace W2InClassAssignment;


public class Book
{
    public string Title;
    public string Author;
    public int YearPublished;

  
    public Book(string title, string author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Year Published: {YearPublished}");
    }
}
