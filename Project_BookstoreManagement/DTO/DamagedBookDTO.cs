using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DTO
{
	public class DamagedBookDTO
	{
		private string _BookId;
		public string BookId
		{
			get { return _BookId; }
			set { _BookId = value; }
		}

		private int _DamagedQuantity;
		public int DamagedQuantity
		{
			get { return _DamagedQuantity; }
			set { _DamagedQuantity = value; }
		}

		private int _DamagedTotal;
		public int DamagedTotal
		{
			get { return _DamagedTotal; }
			set { _DamagedTotal = value; }
		}

		private int _Liquidated;
		public int Liquidated
		{
			get { return _Liquidated; }
			set { _Liquidated = value; }
		}

		private bool _Status;
		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }
		}

		public DamagedBookDTO()
		{

		}

		public DamagedBookDTO(string BookId_, int DamagedQuantity_, int DamagedTotal_, int Liquidated_, bool Status_)
		{
			this.BookId = BookId_;
			this.DamagedQuantity = DamagedQuantity_;
			this.DamagedTotal = DamagedTotal_;
			this.Liquidated = Liquidated_;
			this.Status = Status_;
		}
	}
}
