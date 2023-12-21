using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_BookstoreManagement.DTO
{
	public class VendorDTO
	{
		private string _VendorId;
		public string VendorId
		{
			get { return _VendorId; }
			set { _VendorId = value; }
		}

		private string _VendorName;
		public string VendorName
		{
			get { return _VendorName; }
			set { _VendorName = value; }
		}

		private string _VendorPhone;
		public string VendorPhone
		{
			get { return _VendorPhone; }
			set { _VendorPhone = value; }
		}

		private bool _Status;
		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }
		}

		public VendorDTO() { }

		public VendorDTO(string VendorId_, string VendorName_, string VendorPhone_, bool Status_)
		{
			this.VendorId = VendorId_;
			this.VendorName = VendorName_;
			this.VendorPhone = VendorPhone_;
			this.Status = Status_;
		}
	}
}
