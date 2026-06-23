public class Program
{
    public static void Main()
    {
        Book book = new Book("C# Programming", "Ashton", 450);
        DVD dvd = new DVD("Learn C#", "Ashton", 120);
        Magazine magazine = new Magazine("Tech Weekly", "Austin", 34);

        // Display the common details followed by each item's specific details.
        book.PrintDetails();
        dvd.PrintDetails();
        magazine.PrintDetails();
    }
}

public class LibraryItem
{
    private string Title;
    private string Author;

    public LibraryItem(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public virtual void PrintDetails()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}

public class Book : LibraryItem
{
    private int PageCount;

    public Book(string title, string author, int pageCount)
        : base(title, author)
    {
        PageCount = pageCount;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"PageCount: {PageCount}");
    }
}

public class DVD : LibraryItem
{
    private int Duration;

    public DVD(string title, string author, int duration)
        : base(title, author)
    {
        Duration = duration;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Duration: {Duration} minutes");
    }
}

public class Magazine : LibraryItem
{
    private int IssueNumber;

    public Magazine(string title, string author, int issueNumber)
        : base(title, author)
    {
        IssueNumber = issueNumber;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Issue Number: {IssueNumber}");
    }
}
