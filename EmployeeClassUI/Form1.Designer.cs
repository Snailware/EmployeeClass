
namespace EmployeeClassUI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.InputNameTextBox = new System.Windows.Forms.TextBox();
			this.InputDepartmentTextBox = new System.Windows.Forms.TextBox();
			this.InputPositionTextBox = new System.Windows.Forms.TextBox();
			this.InputIdNumberTextBox = new System.Windows.Forms.TextBox();
			this.OutputNameLabel = new System.Windows.Forms.Label();
			this.OutputDepartmentLabel = new System.Windows.Forms.Label();
			this.OutputPositionLabel = new System.Windows.Forms.Label();
			this.OutputIdNumberLabel = new System.Windows.Forms.Label();
			this.InputEnterButton = new System.Windows.Forms.Button();
			this.LabelNameInput = new System.Windows.Forms.Label();
			this.LabelDepartmentInput = new System.Windows.Forms.Label();
			this.LabelPositionInput = new System.Windows.Forms.Label();
			this.LabelIdNumberInput = new System.Windows.Forms.Label();
			this.LabelNameOutput = new System.Windows.Forms.Label();
			this.LabelDepartmentOutput = new System.Windows.Forms.Label();
			this.LabelPositionOutput = new System.Windows.Forms.Label();
			this.LabelIdNumberOutput = new System.Windows.Forms.Label();
			this.InputClearButton = new System.Windows.Forms.Button();
			this.LabelTitle = new System.Windows.Forms.Label();
			this.OutputNextButton = new System.Windows.Forms.Button();
			this.OutputPreviousButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.GroupBoxInput = new System.Windows.Forms.GroupBox();
			this.GroupBoxOutput = new System.Windows.Forms.GroupBox();
			this.GroupBoxInput.SuspendLayout();
			this.GroupBoxOutput.SuspendLayout();
			this.SuspendLayout();
			// 
			// InputNameTextBox
			// 
			this.InputNameTextBox.Location = new System.Drawing.Point(15, 45);
			this.InputNameTextBox.Name = "InputNameTextBox";
			this.InputNameTextBox.Size = new System.Drawing.Size(180, 20);
			this.InputNameTextBox.TabIndex = 0;
			// 
			// InputDepartmentTextBox
			// 
			this.InputDepartmentTextBox.Location = new System.Drawing.Point(15, 116);
			this.InputDepartmentTextBox.Name = "InputDepartmentTextBox";
			this.InputDepartmentTextBox.Size = new System.Drawing.Size(180, 20);
			this.InputDepartmentTextBox.TabIndex = 1;
			// 
			// InputPositionTextBox
			// 
			this.InputPositionTextBox.Location = new System.Drawing.Point(15, 189);
			this.InputPositionTextBox.Name = "InputPositionTextBox";
			this.InputPositionTextBox.Size = new System.Drawing.Size(180, 20);
			this.InputPositionTextBox.TabIndex = 2;
			// 
			// InputIdNumberTextBox
			// 
			this.InputIdNumberTextBox.Location = new System.Drawing.Point(15, 258);
			this.InputIdNumberTextBox.Name = "InputIdNumberTextBox";
			this.InputIdNumberTextBox.Size = new System.Drawing.Size(180, 20);
			this.InputIdNumberTextBox.TabIndex = 3;
			// 
			// OutputNameLabel
			// 
			this.OutputNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OutputNameLabel.Location = new System.Drawing.Point(14, 44);
			this.OutputNameLabel.Name = "OutputNameLabel";
			this.OutputNameLabel.Size = new System.Drawing.Size(180, 20);
			this.OutputNameLabel.TabIndex = 4;
			this.OutputNameLabel.Text = "n/a";
			this.OutputNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// OutputDepartmentLabel
			// 
			this.OutputDepartmentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OutputDepartmentLabel.Location = new System.Drawing.Point(14, 115);
			this.OutputDepartmentLabel.Name = "OutputDepartmentLabel";
			this.OutputDepartmentLabel.Size = new System.Drawing.Size(180, 20);
			this.OutputDepartmentLabel.TabIndex = 5;
			this.OutputDepartmentLabel.Text = "n/a";
			this.OutputDepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// OutputPositionLabel
			// 
			this.OutputPositionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OutputPositionLabel.Location = new System.Drawing.Point(14, 188);
			this.OutputPositionLabel.Name = "OutputPositionLabel";
			this.OutputPositionLabel.Size = new System.Drawing.Size(180, 20);
			this.OutputPositionLabel.TabIndex = 6;
			this.OutputPositionLabel.Text = "n/a";
			this.OutputPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// OutputIdNumberLabel
			// 
			this.OutputIdNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OutputIdNumberLabel.Location = new System.Drawing.Point(14, 258);
			this.OutputIdNumberLabel.Name = "OutputIdNumberLabel";
			this.OutputIdNumberLabel.Size = new System.Drawing.Size(180, 20);
			this.OutputIdNumberLabel.TabIndex = 7;
			this.OutputIdNumberLabel.Text = "n/a";
			this.OutputIdNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// InputEnterButton
			// 
			this.InputEnterButton.Location = new System.Drawing.Point(15, 302);
			this.InputEnterButton.Name = "InputEnterButton";
			this.InputEnterButton.Size = new System.Drawing.Size(75, 23);
			this.InputEnterButton.TabIndex = 8;
			this.InputEnterButton.Text = "Enter";
			this.InputEnterButton.UseVisualStyleBackColor = true;
			this.InputEnterButton.Click += new System.EventHandler(this.InputEnterButton_Click);
			// 
			// LabelNameInput
			// 
			this.LabelNameInput.AutoSize = true;
			this.LabelNameInput.Location = new System.Drawing.Point(88, 29);
			this.LabelNameInput.Name = "LabelNameInput";
			this.LabelNameInput.Size = new System.Drawing.Size(38, 13);
			this.LabelNameInput.TabIndex = 9;
			this.LabelNameInput.Text = "Name:";
			// 
			// LabelDepartmentInput
			// 
			this.LabelDepartmentInput.AutoSize = true;
			this.LabelDepartmentInput.Location = new System.Drawing.Point(79, 100);
			this.LabelDepartmentInput.Name = "LabelDepartmentInput";
			this.LabelDepartmentInput.Size = new System.Drawing.Size(65, 13);
			this.LabelDepartmentInput.TabIndex = 10;
			this.LabelDepartmentInput.Text = "Department:";
			// 
			// LabelPositionInput
			// 
			this.LabelPositionInput.AutoSize = true;
			this.LabelPositionInput.Location = new System.Drawing.Point(88, 173);
			this.LabelPositionInput.Name = "LabelPositionInput";
			this.LabelPositionInput.Size = new System.Drawing.Size(47, 13);
			this.LabelPositionInput.TabIndex = 11;
			this.LabelPositionInput.Text = "Position:";
			// 
			// LabelIdNumberInput
			// 
			this.LabelIdNumberInput.AutoSize = true;
			this.LabelIdNumberInput.Location = new System.Drawing.Point(79, 242);
			this.LabelIdNumberInput.Name = "LabelIdNumberInput";
			this.LabelIdNumberInput.Size = new System.Drawing.Size(61, 13);
			this.LabelIdNumberInput.TabIndex = 12;
			this.LabelIdNumberInput.Text = "ID Number:";
			// 
			// LabelNameOutput
			// 
			this.LabelNameOutput.AutoSize = true;
			this.LabelNameOutput.Location = new System.Drawing.Point(92, 29);
			this.LabelNameOutput.Name = "LabelNameOutput";
			this.LabelNameOutput.Size = new System.Drawing.Size(38, 13);
			this.LabelNameOutput.TabIndex = 13;
			this.LabelNameOutput.Text = "Name:";
			// 
			// LabelDepartmentOutput
			// 
			this.LabelDepartmentOutput.AutoSize = true;
			this.LabelDepartmentOutput.Location = new System.Drawing.Point(75, 100);
			this.LabelDepartmentOutput.Name = "LabelDepartmentOutput";
			this.LabelDepartmentOutput.Size = new System.Drawing.Size(65, 13);
			this.LabelDepartmentOutput.TabIndex = 14;
			this.LabelDepartmentOutput.Text = "Department:";
			// 
			// LabelPositionOutput
			// 
			this.LabelPositionOutput.AutoSize = true;
			this.LabelPositionOutput.Location = new System.Drawing.Point(83, 173);
			this.LabelPositionOutput.Name = "LabelPositionOutput";
			this.LabelPositionOutput.Size = new System.Drawing.Size(47, 13);
			this.LabelPositionOutput.TabIndex = 15;
			this.LabelPositionOutput.Text = "Position:";
			// 
			// LabelIdNumberOutput
			// 
			this.LabelIdNumberOutput.AutoSize = true;
			this.LabelIdNumberOutput.Location = new System.Drawing.Point(75, 242);
			this.LabelIdNumberOutput.Name = "LabelIdNumberOutput";
			this.LabelIdNumberOutput.Size = new System.Drawing.Size(61, 13);
			this.LabelIdNumberOutput.TabIndex = 16;
			this.LabelIdNumberOutput.Text = "ID Number:";
			// 
			// InputClearButton
			// 
			this.InputClearButton.Location = new System.Drawing.Point(120, 302);
			this.InputClearButton.Name = "InputClearButton";
			this.InputClearButton.Size = new System.Drawing.Size(75, 23);
			this.InputClearButton.TabIndex = 17;
			this.InputClearButton.Text = "Clear";
			this.InputClearButton.UseVisualStyleBackColor = true;
			this.InputClearButton.Click += new System.EventHandler(this.InputClearButton_Click);
			// 
			// LabelTitle
			// 
			this.LabelTitle.AutoSize = true;
			this.LabelTitle.Location = new System.Drawing.Point(175, 23);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new System.Drawing.Size(123, 13);
			this.LabelTitle.TabIndex = 18;
			this.LabelTitle.Text = "Employee Class Practice";
			// 
			// OutputNextButton
			// 
			this.OutputNextButton.Location = new System.Drawing.Point(14, 302);
			this.OutputNextButton.Name = "OutputNextButton";
			this.OutputNextButton.Size = new System.Drawing.Size(75, 23);
			this.OutputNextButton.TabIndex = 19;
			this.OutputNextButton.Text = "Next";
			this.OutputNextButton.UseVisualStyleBackColor = true;
			this.OutputNextButton.Click += new System.EventHandler(this.OutputNextButton_Click);
			// 
			// OutputPreviousButton
			// 
			this.OutputPreviousButton.Location = new System.Drawing.Point(119, 302);
			this.OutputPreviousButton.Name = "OutputPreviousButton";
			this.OutputPreviousButton.Size = new System.Drawing.Size(75, 23);
			this.OutputPreviousButton.TabIndex = 20;
			this.OutputPreviousButton.Text = "Previous";
			this.OutputPreviousButton.UseVisualStyleBackColor = true;
			this.OutputPreviousButton.Click += new System.EventHandler(this.OutputPreviousButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(196, 404);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 21;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// GroupBoxInput
			// 
			this.GroupBoxInput.Controls.Add(this.InputClearButton);
			this.GroupBoxInput.Controls.Add(this.LabelIdNumberInput);
			this.GroupBoxInput.Controls.Add(this.LabelPositionInput);
			this.GroupBoxInput.Controls.Add(this.LabelDepartmentInput);
			this.GroupBoxInput.Controls.Add(this.LabelNameInput);
			this.GroupBoxInput.Controls.Add(this.InputEnterButton);
			this.GroupBoxInput.Controls.Add(this.InputIdNumberTextBox);
			this.GroupBoxInput.Controls.Add(this.InputPositionTextBox);
			this.GroupBoxInput.Controls.Add(this.InputDepartmentTextBox);
			this.GroupBoxInput.Controls.Add(this.InputNameTextBox);
			this.GroupBoxInput.Location = new System.Drawing.Point(14, 56);
			this.GroupBoxInput.Name = "GroupBoxInput";
			this.GroupBoxInput.Size = new System.Drawing.Size(209, 336);
			this.GroupBoxInput.TabIndex = 0;
			this.GroupBoxInput.TabStop = false;
			this.GroupBoxInput.Text = "Input";
			// 
			// GroupBoxOutput
			// 
			this.GroupBoxOutput.Controls.Add(this.OutputPreviousButton);
			this.GroupBoxOutput.Controls.Add(this.OutputNextButton);
			this.GroupBoxOutput.Controls.Add(this.LabelIdNumberOutput);
			this.GroupBoxOutput.Controls.Add(this.LabelPositionOutput);
			this.GroupBoxOutput.Controls.Add(this.LabelDepartmentOutput);
			this.GroupBoxOutput.Controls.Add(this.LabelNameOutput);
			this.GroupBoxOutput.Controls.Add(this.OutputIdNumberLabel);
			this.GroupBoxOutput.Controls.Add(this.OutputPositionLabel);
			this.GroupBoxOutput.Controls.Add(this.OutputDepartmentLabel);
			this.GroupBoxOutput.Controls.Add(this.OutputNameLabel);
			this.GroupBoxOutput.Location = new System.Drawing.Point(243, 56);
			this.GroupBoxOutput.Name = "GroupBoxOutput";
			this.GroupBoxOutput.Size = new System.Drawing.Size(209, 335);
			this.GroupBoxOutput.TabIndex = 1;
			this.GroupBoxOutput.TabStop = false;
			this.GroupBoxOutput.Text = "Output";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(470, 441);
			this.Controls.Add(this.GroupBoxOutput);
			this.Controls.Add(this.GroupBoxInput);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.LabelTitle);
			this.Name = "Form1";
			this.Text = "Employee Class Practice";
			this.GroupBoxInput.ResumeLayout(false);
			this.GroupBoxInput.PerformLayout();
			this.GroupBoxOutput.ResumeLayout(false);
			this.GroupBoxOutput.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox InputNameTextBox;
		private System.Windows.Forms.TextBox InputDepartmentTextBox;
		private System.Windows.Forms.TextBox InputPositionTextBox;
		private System.Windows.Forms.TextBox InputIdNumberTextBox;
		private System.Windows.Forms.Label OutputNameLabel;
		private System.Windows.Forms.Label OutputDepartmentLabel;
		private System.Windows.Forms.Label OutputPositionLabel;
		private System.Windows.Forms.Label OutputIdNumberLabel;
		private System.Windows.Forms.Button InputEnterButton;
		private System.Windows.Forms.Label LabelNameInput;
		private System.Windows.Forms.Label LabelDepartmentInput;
		private System.Windows.Forms.Label LabelPositionInput;
		private System.Windows.Forms.Label LabelIdNumberInput;
		private System.Windows.Forms.Label LabelNameOutput;
		private System.Windows.Forms.Label LabelDepartmentOutput;
		private System.Windows.Forms.Label LabelPositionOutput;
		private System.Windows.Forms.Label LabelIdNumberOutput;
		private System.Windows.Forms.Button InputClearButton;
		private System.Windows.Forms.Label LabelTitle;
		private System.Windows.Forms.Button OutputNextButton;
		private System.Windows.Forms.Button OutputPreviousButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.GroupBox GroupBoxInput;
		private System.Windows.Forms.GroupBox GroupBoxOutput;
	}
}

