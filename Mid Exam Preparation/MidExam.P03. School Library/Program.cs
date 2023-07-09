List<string> bookShelf = Console.ReadLine()!
    .Split('&', StringSplitOptions.RemoveEmptyEntries)
    .ToList();


while (true)
{
    string input = Console.ReadLine()!;
    
    if (input == "Done")
    {
        break;
    }
    string[] command = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);


    if (command[0] == "Add Book")
    {
        string bookName = command[1];
        if (!bookShelf.Contains(bookName))
        {
            bookShelf.Insert(0, bookName);
        }
    }
    else if (command[0] == "Take Book")
    {
        string bookName = command[1];
        if (bookShelf.Contains(bookName))
        {
            bookShelf.Remove(bookName);
        }
    }
    else if (command[0] == "Swap Books")
    {
        string book1 = command[1];
        string book2 = command[2];
        if (bookShelf.Contains(book1) && bookShelf.Contains(book2))
        {
            int indexOfBook1 = bookShelf.IndexOf(book1);
            int indexOfBook2 = bookShelf.IndexOf(book2);
            string tmp = bookShelf[indexOfBook1];
            bookShelf[indexOfBook1]=bookShelf[indexOfBook2];
            bookShelf[indexOfBook2] = tmp;
        }

    }
    else if (command[0] == "Insert Book")
    {
        string bookName = command[1];
        if (!bookShelf.Contains(bookName))
        {
            bookShelf.Add(bookName);
        }

    }

    else if (command[0] == "Check Book")
    {
        int index = int.Parse(command[1]);
       
        if (index < 0 || index >= bookShelf.Count)
        {
            continue;
        }
        Console.WriteLine(bookShelf[index]);
    }
}

Console.WriteLine(string.Join(", ", bookShelf));
