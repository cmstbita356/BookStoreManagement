using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DTO
{
	public class BookDTO
	{
		private string _BookId;
		public string BookId
		{
			get { return _BookId; }
			set { _BookId = value; }
		}

		private string _BookName;
		public string BookName
		{
			get { return _BookName; }
			set { _BookName = value; }
		}

		private string _BookType;
		public string BookType
		{
			get { return _BookType; }
			set { _BookType = value; }
		}

		private string _BookAuthor;
		public string BookAuthor
		{
			get { return _BookAuthor; }
			set { _BookAuthor = value; }
		}

		private string _BookPublisher;
		public string BookPublisher
		{
			get { return _BookPublisher; }
			set { _BookPublisher = value; }
		}

		private int _BookPrice;
		public int BookPrice
		{
			get { return _BookPrice; }
			set { _BookPrice = value; }
		}

		private bool _Status;
		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }
		}

        public BookDTO()
        {

        }

        public BookDTO(string BookId_, string BookName_, string BookType_, string BookAuthor_, string BookPublisher_, int BookPrice_, bool Status_)
		{
			this.BookId = BookId_;
			this.BookName = BookName_;
			this.BookType = BookType_;
			this.BookAuthor = BookAuthor_;
			this.BookPublisher = BookPublisher_;
			this.BookPrice = BookPrice_;
			this.Status = Status_;
		}
	}
}
