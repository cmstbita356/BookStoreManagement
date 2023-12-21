using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DTO
{
	public class BookTypeDTO
	{
		private string _TypeId;
		public string TypeId
		{
			get { return _TypeId; }
			set { _TypeId = value; }
		}

		private string _TypeName;
		public string TypeName
		{
			get { return _TypeName; }
			set { _TypeName = value; }
		}

		private bool _Status;
		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }
		}

		public BookTypeDTO()
		{

		}

		public BookTypeDTO(string TypeId_, string TypeName_, bool Status_)
		{
			this.TypeId = TypeId_;
			this.TypeName = TypeName_;
			this.Status = Status_;
		}
	}
}
