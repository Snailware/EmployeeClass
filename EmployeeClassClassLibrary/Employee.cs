using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassClassLibrary
{
	/// <summary>
	/// class for company employees. 
	/// </summary>
	public class Employee
	{
		private string	_name,
						_department,
						_position;

		private int _idNumber;
		// fields.

		/// <summary>
		/// full employee constructor. 
		/// </summary>
		/// <param name="empName">employees full name.</param>
		/// <param name="empDept">department employee works in.</param>
		/// <param name="empPosn">employees position within company.</param>
		/// <param name="empIdNo">employees unique identification number.</param>
		public Employee(string empName, string empDept, string empPosn, int empIdNo)
		{
			Name		= empName;
			Department	= empDept;
			Position	= empPosn;
			IdNumber	= empIdNo;
		}

		/// <summary>
		/// partial employee constructor.
		/// </summary>
		/// <param name="empName">employees full name.</param>
		/// <param name="empIdNo">employees unique identification number.</param>
		public Employee(string empName, int empIdNo)
		{
			Name		= empName;
			Department	= "";
			Position	= "";
			IdNumber	= empIdNo;
		}

		/// <summary>
		/// empty employee constructor.
		/// </summary>
		public Employee()
		{
			Name		= "";
			Department	= "";
			Position	= "";
			IdNumber	= 0;
		}
		// constructors.

		/// <summary>
		/// employees full name.
		/// </summary>
		public string Name
		{
			get { return _name;		}
			set { _name = value;	}
		}

		/// <summary>
		/// department employee works in. 
		/// </summary>
		public string Department
		{
			get { return _department;	}
			set { _department = value;	}
		}

		/// <summary>
		/// employees position within company. 
		/// </summary>
		public string Position
		{
			get { return _position;		}
			set { _position = value;	}
		}

		/// <summary>
		/// employees unique identification number.
		/// </summary>
		public int IdNumber
		{
			get { return _idNumber;		}
			set { _idNumber = value;	}
		}
		// properties.
	}
}
