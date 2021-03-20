using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassClassLibrary
{
	/// <summary>
	/// class to hold info for all employees. 
	/// </summary>
	public static class EmployeesInfo
	{
		private static int _currentEmployeeIndex = 0;

		private static List<Employee> _employeeList = new List<Employee>()
		{
			new Employee("Susan Meyers",    "Accounting",       "Vice President",   47899),
			new Employee("Mark Jones",      "IT",               "Programmer",       39119),
			new Employee("Joy Rogers",      "Manufacturing",    "Engineer",         81774)
		};

		/// <summary>
		/// int for holding index of currently selected employee. 
		/// </summary>
		public static int CurrentEmployeeIndex
		{
			get { return _currentEmployeeIndex;		}
			set { _currentEmployeeIndex = value;	}
		}

		/// <summary>
		/// list of all current employees. 
		/// </summary>
		public static List<Employee> EmployeeList
		{
			get { return _employeeList;		}
			set { _employeeList = value;	}
		}
	}
}
