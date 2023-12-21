using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DTO
{
	public class ReceiptDTO
	{
		private string _ReceiptId;
		public string ReceiptId
		{
			get { return _ReceiptId; }
			set { _ReceiptId = value; }
		}

		private string _SaleEmployeeId;
		public string SaleEmployeeId
		{
			get { return _SaleEmployeeId; }
			set { _SaleEmployeeId = value; }
		}

		private string _CustomerId;
		public string CustomerId
		{
			get { return _CustomerId; }
			set { _CustomerId = value; }
		}

		private string _SaleDate;
		public string SaleDate
		{
			get { return _SaleDate; }
			set { _SaleDate = value; }
		}

		private int _ReceiptTotal;
		public int ReceiptTotal
		{
			get { return _ReceiptTotal; }
			set { _ReceiptTotal = value; }
		}

		private bool _Status;
		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }
		}

		public ReceiptDTO() { }

		public ReceiptDTO(string ReceiptId_, string SaleEmployeeId_, string CustomerId_, string SaleDate_, int ReceiptTotal_, bool Status_)
		{
			this.ReceiptId = ReceiptId_;
			this.SaleEmployeeId = SaleEmployeeId_;
			this.CustomerId = CustomerId_;
			this.SaleDate = SaleDate_;
			this.ReceiptTotal = ReceiptTotal_;
			this.Status = Status_;
		}
	}
}
