using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DTO
{
	public class StockDTO
	{
		private string _BookId;
		public string BookId
		{
			get { return _BookId; }
			set { _BookId = value; }
		}

		private int _BookQuantity;
		public int BookQuantity
		{
			get { return _BookQuantity; }
			set { _BookQuantity = value; }
		}

		private bool _Status;
		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }
		}

		public StockDTO() { }

		public StockDTO(string BookId_, int BookQuantity_, bool Status_)
		{
			this.BookId = BookId_;
			this.BookQuantity = BookQuantity_;
			this.Status = Status_;
		}
	}
}
