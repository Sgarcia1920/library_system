using Microsoft.VisualBasic.FileIO;

namespace library_system
{
	internal class Program
	{

		public static void Main(string[] args)
		{


			List<Book> bookList = new List<Book>
			{
				new Book("Cinderella", "The Brothers Grimm", 32, "Children's Fairy Tale"),
				new Book("Snow White", "The Brothers Grimm", 32, "Children's Fairy Tale"),
				new Book("Rapunzel", "The Brothers Grimm", 32, "Children's Fairy Tale"),
				new Book("The Frog Prince", "The Brothers Grimm", 32, "Children's Fairy Tale"),
				new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 223, "Fantasy"),
				new Book("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 223, "Fantasy")
			};

			List<DigitalBook> DigitalbookList = new List<DigitalBook>
			{
				new DigitalBook("The Lord of the Rings: The Fellowship of the Ring", "J.R.R. Tolkien", 432, "Fantasy", "lord_of_the_rings.pdf"),
				new DigitalBook("La La Land", "Emma Stone", 320, "Romance", "la_la_land.pdf"),
				new DigitalBook("Inception", "Christopher Nolan", 400, "Science Fiction", "inception.pdf"),
				new DigitalBook("Gladiator", "Russell Crowe", 320, "Action", "gladiator.pdf"),
				new DigitalBook("Coco", "Pixar", 240, "Animation", "coco.pdf"),
				new DigitalBook("Interstellar", "Christopher Nolan", 440, "Science Fiction", "interstellar.pdf"),
		     };

			Console.WriteLine("Welcome to the book system.");
			Console.WriteLine("Select an option:\n1) Add book\n2) Delete book\n3) Check for clones\n4) Exit");
			char option = Console.ReadKey().KeyChar;
			Console.WriteLine();

			switch (option)
			{
				case '1':

					Console.WriteLine("Enter the title of the book:");
					string title = Console.ReadLine();

					Console.WriteLine("Enter the author of the book:");
					string author = Console.ReadLine();

					Console.WriteLine("Enter the number of pages:");
					int pages = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("Enter the genre of the book:");
					string genre = Console.ReadLine();

                    
					Book userBook = new Book(title, author, pages, genre);
					Console.WriteLine(userBook.ToString());
					bookList.Add(userBook);

					break;

				case '2':

					Console.WriteLine("Book Options:");
					Console.WriteLine("1) Cinderella - The Brothers Grimm");
					Console.WriteLine("2) Snow White - The Brothers Grimm");
					Console.WriteLine("3) Rapunzel - The Brothers Grimm");
					Console.WriteLine("4) The Frog Prince - The Brothers Grimm");
					Console.WriteLine("5) Harry Potter and the Philosopher's Stone - J.K. Rowling");

					Console.WriteLine("\nDigital Book Options:");
					Console.WriteLine("1) The Lord of the Rings: The Fellowship of the Ring - J.R.R. Tolkien");
					Console.WriteLine("2) La La Land - Emma Stone");
					Console.WriteLine("3) Inception - Christopher Nolan");
					Console.WriteLine("4) Gladiator - Russell Crowe");
					Console.WriteLine("5) Coco - Pixar");
					Console.WriteLine("6) Interstellar - Christopher Nolan");
					Console.WriteLine("Type the title: ");
					string booksdelete = Console.ReadLine();
					foreach (Book book in bookList)
					{
						if (booksdelete.Equals(book.TITLE))
						{
							book.DeleteBook();
							Console.WriteLine("The book was deleted");

						}
						else
						{
							break;
						}

					}
					foreach (DigitalBook digitalBook in DigitalbookList)
					{
						if (booksdelete.Equals(digitalBook.TITLE))
						{
							digitalBook.DeleteBook();
							Console.WriteLine("The book was deleted");

						}
					}
					break;
				case '3':
					Console.WriteLine("Type the title: ");
					string booksclon = Console.ReadLine();
					foreach (Book book in bookList)
					{
						if (booksclon.Equals(book.TITLE))
						{
							string result = book.Check_copies(book);
							Console.WriteLine(result);
							Console.WriteLine("The book was checked for copies");
							break;
						}

					}
					foreach (DigitalBook digitalBook in DigitalbookList)
					{
						if (booksclon.Equals(digitalBook.TITLE))
						{
							string result = digitalBook.Check_copies(digitalBook);
							Console.WriteLine(result);
							Console.WriteLine("The book was checked for copies");
							break;
						}
					}
					break;
				case '4':
					return;
				default:
					Console.WriteLine("Invalid option ");
					break;
			}



		}


	}
}
