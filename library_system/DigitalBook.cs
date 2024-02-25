using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_system
{
	internal class DigitalBook:Book
	{

		protected string file_type;

		public string File
		{
			get { return file_type; }
			set { file_type = value; }
		}
		public DigitalBook(string title_book, string author, int n_pages, string genre_book, string file_tp): base(title_book, author,n_pages,genre_book)		
		{
			this.file_type = file_tp;
		}

		//Method that returns but does not receive parameters
		public override string ToString()
		{
			return base.ToString() + "Available in format : " + file_type;

		}
		//Method that does not return but receives parameters
		public string Check_copies(DigitalBook otherBook)
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
			this.file_type = string.Empty;
		}







	}
}
