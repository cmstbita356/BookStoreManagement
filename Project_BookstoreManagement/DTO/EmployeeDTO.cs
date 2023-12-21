using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DTO
{
	public class EmployeeDTO
	{
		private string _EmplId;
		public string EmplId
		{
			get { return _EmplId; }
			set { _EmplId = value; }
		}

		private string _EmplName;
		public string EmplName
		{
			get { return _EmplName; }
			set { _EmplName = value; }
		}

		private string _EmplDegree;
		public string EmplDegree
		{
			get { return _EmplDegree; }
			set { _EmplDegree = value; }
		}

		private string _EmplPosition;
		public string EmplPosition
		{
			get { return _EmplPosition; }
			set { _EmplPosition = value; }
		}

		private string _EmplAddress;
		public string EmplAddress
		{
			get { return _EmplAddress; }
			set { _EmplAddress = value; }
		}

		private string _EmplPhone;
		public string EmplPhone
		{
			get { return _EmplPhone; }
			set { _EmplPhone = value; }
		}

		private string _EmplUsername;
		public string EmplUsername
		{
			get { return _EmplUsername; }
			set { _EmplUsername = value; }
		}

		private string _EmplPassword;
		public string EmplPassword
		{
			get { return _EmplPassword; }
			set { _EmplPassword = value; }
		}

		private bool _Status;
		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }
		}

		public EmployeeDTO() { }

		public EmployeeDTO(string EmplId_, string EmplName_, string EmplDegree_, string EmplPosition_, string EmplAddress_, string EmplPhone_, string EmplUsername_, string EmplPassword_, bool Status_)
		{
			this.EmplId = EmplId_;
			this.EmplName = EmplName_;
			this.EmplDegree = EmplDegree_;
			this.EmplPosition = EmplPosition_;
			this.EmplAddress = EmplAddress_;
			this.EmplPhone = EmplPhone_;
			this.EmplUsername = EmplUsername_;
			this.EmplPassword = EmplPassword_;
			this.Status = Status_;
		}
	}
}
