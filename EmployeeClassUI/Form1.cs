using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeClassClassLibrary;

namespace EmployeeClassUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// create employee based on input groupbox fields and add to list on click. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void InputEnterButton_Click(object sender, EventArgs e)
		{
			if (int.TryParse(InputIdNumberTextBox.Text, out int idNumber))
			{
				EmployeesInfo.EmployeeList.Add(new Employee(InputNameTextBox.Text,
															InputDepartmentTextBox.Text,
															InputPositionTextBox.Text,
															idNumber));
				/// create employee object and add to EmployeeList.
			}
			// only create entries where idNumber can be succesfully parsed. 

			else
			{
				InputNameTextBox.Text		= "Invalid Entry";
				InputDepartmentTextBox.Text = "Invalid Entry";
				InputPositionTextBox.Text	= "Invalid Entry";
				InputIdNumberTextBox.Text	= "Invalid Entry";
				// set text in all fields to Invalid Entry.
			}
			// alert user that entry was invalid. 
		}

		/// <summary>
		/// clear input groupbox fields on click.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void InputClearButton_Click(object sender, EventArgs e)
		{
			InputNameTextBox.Clear();
			InputDepartmentTextBox.Clear();
			InputPositionTextBox.Clear();
			InputIdNumberTextBox.Clear();
			// clear text in all fields in prep for new entry. 
		}

		/// <summary>
		/// display next employee in output groupbox fields on click.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OutputNextButton_Click(object sender, EventArgs e)
		{
			if ((EmployeesInfo.CurrentEmployeeIndex < EmployeesInfo.EmployeeList.Count - 1) &&
				(OutputNameLabel.Text != @"n/a"))
			{
				EmployeesInfo.CurrentEmployeeIndex++;
			}
			// increment index if within employeeList bounds.

			OutputNameLabel.Text		= EmployeesInfo.EmployeeList[EmployeesInfo.CurrentEmployeeIndex].Name;
			OutputDepartmentLabel.Text	= EmployeesInfo.EmployeeList[EmployeesInfo.CurrentEmployeeIndex].Department;
			OutputPositionLabel.Text	= EmployeesInfo.EmployeeList[EmployeesInfo.CurrentEmployeeIndex].Position;
			OutputIdNumberLabel.Text	= EmployeesInfo.EmployeeList[EmployeesInfo.CurrentEmployeeIndex].IdNumber.ToString();
			// set output based on currentEmployeeIndex.
		}

		/// <summary>
		/// display previous employee in output groupbox fields on click. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OutputPreviousButton_Click(object sender, EventArgs e)
		{
			if (EmployeesInfo.CurrentEmployeeIndex > 0)
			{
				EmployeesInfo.CurrentEmployeeIndex--;
			}
			// decrement index if within employeeList bounds.

			OutputNameLabel.Text		= EmployeesInfo.EmployeeList[EmployeesInfo.CurrentEmployeeIndex].Name;
			OutputDepartmentLabel.Text	= EmployeesInfo.EmployeeList[EmployeesInfo.CurrentEmployeeIndex].Department;
			OutputPositionLabel.Text	= EmployeesInfo.EmployeeList[EmployeesInfo.CurrentEmployeeIndex].Position;
			OutputIdNumberLabel.Text	= EmployeesInfo.EmployeeList[EmployeesInfo.CurrentEmployeeIndex].IdNumber.ToString();
			// set output based on currentEmployeeIndex.
		}

		/// <summary>
		/// close program on click.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
