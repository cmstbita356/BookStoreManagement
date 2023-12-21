using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DTO
{
	public class ImportDTO
	{
		private string _ImportId;
		public string ImportId
		{
			get { return _ImportId; }
			set { _ImportId = value; }
		}

		private string _EmplId;
		public string EmplId
		{
			get { return _EmplId; }
			set { _EmplId = value; }
		}

		private string _VendorId;
		public string VendorId
		{
			get { return _VendorId; }
			set { _VendorId = value; }
		}

		private string _ImportDate;
		public string ImportDate
		{
			get { return _ImportDate; }
			set { _ImportDate = value; }
		}

		private int _ImportTotal;
		public int ImportTotal
		{
			get { return _ImportTotal; }
			set { _ImportTotal = value; }
		}

		private bool _Status;
		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }
		}

		public ImportDTO() { }
		public ImportDTO(string ImportId_, string EmplId_, string VendorId_, string ImportDate_, int ImportTotal_, bool Status_)
		{
			this.ImportId = ImportId_;
			this.EmplId = EmplId_;
			this.VendorId = VendorId_;
			this.ImportDate = ImportDate_;
			this.ImportTotal = ImportTotal_;
			this.Status = Status_;
		}
	}
}
