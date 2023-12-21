using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DTO
{
	public class DegreeDTO
	{
		private string _DegId;
		public string DegId
		{
			get { return _DegId; }
			set { _DegId = value; }
		}

		private string _DegName;
		public string DegName
		{
			get { return _DegName; }
			set { _DegName = value; }
		}

		private bool _Status;
		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }
		}

		public DegreeDTO() { }

		public DegreeDTO(string DegId_, string DegName_, bool Status_)
		{
			this.DegId = DegId_;
			this.DegName = DegName_;
			this.Status = Status_;
		}
	}
}
