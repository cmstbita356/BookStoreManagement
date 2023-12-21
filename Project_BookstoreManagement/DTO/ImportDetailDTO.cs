using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DTO
{
	public class ImportDetailDTO
	{
		private string _ImportId;
		public string ImportId
		{
			get { return _ImportId; }
			set { _ImportId = value; }
		}

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

		private int _UnitCost;
		public int UnitCost
		{
			get { return _UnitCost; }
			set { _UnitCost = value; }
		}

		private bool _Status;
		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }
		}

		public ImportDetailDTO() { }

		public ImportDetailDTO(string ImportId_, string BookId_, int BookQuantity_, int UnitCost_, bool Status_)
		{
			this.ImportId = ImportId_;
			this.BookId = BookId_;
			this.BookQuantity = BookQuantity_;
			this.UnitCost = UnitCost_;
			this.Status = Status_;
		}
	}
}
