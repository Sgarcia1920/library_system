using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace library_system
{
	internal class Book
	{
		protected string title;

		public string TITLE
		{
			get { return title; }
			set {
				if (value != null)
				{
					title = value;
				}
				else
				{
					//Throws a warning that it cannot be null and void.
					throw new ArgumentNullException("The title cannot be null");
				}
			}
		}

		protected string author;

		public string Author
		{
			get { return author; }
			set {
				if (value != null)
				{
					author = value;
				}
				else
				{
					//Throws a warning that it cannot be null and void.
					throw new ArgumentNullException("The title cannot be null");
				}
			}
		}

		protected int number_pages;

		public int Number_Pages
		{
			get { return number_pages; }
			set { number_pages = value; }
		}

		protected string gender;

		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}


		public Book(string title_book, string author, int n_pages, string gender_book)
		{
			this.title = title_book;
			this.author = author;
			this.number_pages = n_pages;
			this.gender = gender_book;
		}

		//Method that returns but does not receive parameters
		public override string ToString()
		{
			return "The book is " + "" + title + "The book is " + "Prepared by: "
			+ author + "Account with: " + number_pages + "Gender: " + gender;

		}

		//Method that returns but does not receive parameters
		public string Check_copies(Book otherBook)
		{
			if (this.title == otherBook.title && this.author == otherBook.author)
			{
				return "There are coincidences";
			}
			else
			{
				return "No Coincidences";
			}

		}
		//Method that neither returns nor receives parameters:
		public void DeleteBook()
		{

			this.title = string.Empty;
			this.author = string.Empty;
			this.number_pages = 0;
			this.gender = string.Empty;
		}




	}
}
