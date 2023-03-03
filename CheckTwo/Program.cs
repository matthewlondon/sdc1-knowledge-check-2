using CheckTwo;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Book>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    Book book = new Book();

    //Prompt user for book title, I would like to expound on this to check that user
    //input is a string only, and repeatedly prompt until that condition is met.
    Console.WriteLine("Enter the title:");
    book.title = Console.ReadLine();

    //Prompt user to input author's name
    Console.WriteLine("Enter the author's name:");
    book.author = Console.ReadLine();

    //Prompt user for year published
    Console.WriteLine("Enter the year the media was published:");
    book.yearPublished = int.Parse(Console.ReadLine());

    //Adds a new record to List<Book> until for loop condition is met
    recordList.Add(book);
}

// Print out the list of records using Console.WriteLine()
foreach (Book book in recordList)
    Console.WriteLine($"{book.title} by {book.author} in {book.yearPublished}");
