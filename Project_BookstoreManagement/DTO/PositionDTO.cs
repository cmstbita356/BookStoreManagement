using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DTO
{
	public class PositionDTO
	{
		private string _PtnId;
		public string PtnId
		{
			get { return _PtnId; }
			set { _PtnId = value; }
		}

		private string _PtnName;
		public string PtnName
		{
			get { return _PtnName; }
			set { _PtnName = value; }
		}

		private bool _Status;
		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }
		}

		public PositionDTO() { }

		public PositionDTO(string PtnId_, string PtnName_, bool Status_)
		{
			this.PtnId = PtnId_;
			this.PtnName = PtnName_;
			this.Status = Status_;
		}
	}
}
