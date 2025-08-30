// See https://aka.ms/new-console-template for more information
using ADO_NET_07_Homework_Explicit_Method;
using Microsoft.EntityFrameworkCore;


using LibraryContext db = new();

while (true)
{
    Console.WriteLine("Choose");

    Console.WriteLine("1.Books by topic");
    Console.WriteLine("2.Books by Category");
    Console.WriteLine("3.Books by Author");
    if (!int.TryParse(Console.ReadLine(), out int choise))
    {
        Console.WriteLine("Please enter number\n");
        continue;
    }
    if (choise == 1)
    {
        var topics = db.Themes.ToList();
        foreach (var topic in topics)
        {
            db.Books.Where(s => s.IdThemes == topic.Id).Load();
            if (topic is not null)
            {
                Console.WriteLine($"**************{topic.Id} {topic.Name}");
                foreach (var book in db.Books)
                {
                    Console.WriteLine($"{book.Name}");
                }
            }
        }
    }


    else if (choise == 2)
    {
        var categories = db.Categories.ToList();
        foreach (var category in categories)
        {
            db.Books.Where(s => s.IdCategory == category.Id).Load();
            if (category is not null)
            {
                Console.WriteLine($"**************{category.Id} {category.Name}");
                foreach (var book in db.Books)
                {
                    Console.WriteLine($"{book.Name}");
                }
            }
        }
    }

    else if (choise == 3)
    {
        var authors = db.Authors.ToList();
        foreach (var author in authors)
        {
            db.Books.Where(s => s.IdAuthor == author.Id).Load();
            if (author is not null)
            {
                Console.WriteLine($"**************{author.FirstName} {author.LastName}");
                foreach (var book in db.Books)
                {
                    Console.WriteLine($"{book.Name}");
                }
            }
        }
    }



    }









