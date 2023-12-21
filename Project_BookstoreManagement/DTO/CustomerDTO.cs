using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DTO
{
	public class CustomerDTO
	{
		private string _CustomerId;
		public string CustomerId
		{
			get { return _CustomerId; }
			set { _CustomerId = value; }
		}

		private string _CustomerName;
		public string CustomerName
		{
			get { return _CustomerName; }
			set { _CustomerName = value; }
		}

		private string _CustomerPhone;
		public string CustomerPhone
		{
			get { return _CustomerPhone; }
			set { _CustomerPhone = value; }
		}

		private string _CustomerEmail;
		public string CustomerEmail
		{
			get { return _CustomerEmail; }
			set { _CustomerEmail = value; }
		}

		private bool _Status;
		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }
		}

		public CustomerDTO()
		{

		}
		public CustomerDTO(string CustomerId_, string CustomerName_, string CustomerPhone_, string CustomerEmail_, bool Status_)
		{
			this.CustomerId = CustomerId_;
			this.CustomerName = CustomerName_;
			this.CustomerPhone = CustomerPhone_;
			this.CustomerEmail = CustomerEmail_;
			this.Status = Status_;
		}
	}
}
