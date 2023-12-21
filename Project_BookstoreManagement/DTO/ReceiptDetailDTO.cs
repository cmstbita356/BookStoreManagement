using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DTO
{
	public class ReceiptDetailDTO
	{
		private string _ReceiptId;
		public string ReceiptId
		{
			get { return _ReceiptId; }
			set { _ReceiptId = value; }
		}

		private string _BookId;
		public string BookId
		{
			get { return _BookId; }
			set { _BookId = value; }
		}

		private int _Quantity;
		public int Quantity
		{
			get { return _Quantity; }
			set { _Quantity = value; }
		}

		private bool _Status;
		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }
		}

		public ReceiptDetailDTO() { }

		public ReceiptDetailDTO(string ReceiptId_, string BookId_, int Quantity_, bool Status_)
		{
			this.ReceiptId = ReceiptId_;
			this.BookId = BookId_;
			this.Quantity = Quantity_;
			this.Status = Status_;
		}
	}
}
