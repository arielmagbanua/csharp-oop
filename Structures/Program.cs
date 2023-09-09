using Structures;

Book book1 = new Book();
book1.title = "Object Oriented Programming";
book1.author = "John Doe";
book1.book_id = 912389812;

Book book2 = book1;
book2.title = "Python Programming";

Console.WriteLine("Book title: " + book2.title);
Console.WriteLine("Book author: " + book1.author);
Console.WriteLine("Book ID: " + book1.book_id);

Person ariel = new Person("Ariel", 23);
Person other = ariel;
other.Name = "Daniel";
Console.WriteLine(ariel.Name);
