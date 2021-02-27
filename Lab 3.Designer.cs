
namespace Lab_3
{
    partial class Lab3
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
            this.components = new System.ComponentModel.Container();
            this.labelDayCounter = new System.Windows.Forms.Label();
            this.labelUnitsInput = new System.Windows.Forms.Label();
            this.textBoxEmployee1 = new System.Windows.Forms.TextBox();
            this.textBoxEmployee3 = new System.Windows.Forms.TextBox();
            this.textBoxEmployee2 = new System.Windows.Forms.TextBox();
            this.labelEmployee1 = new System.Windows.Forms.Label();
            this.labelEmployeeAverage2 = new System.Windows.Forms.Label();
            this.labelEmployee3 = new System.Windows.Forms.Label();
            this.labelTotalAverage = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxUnits = new System.Windows.Forms.TextBox();
            this.labelEmployeeAverage3 = new System.Windows.Forms.Label();
            this.labelEmployeeAverage1 = new System.Windows.Forms.Label();
            this.labelEmployee2 = new System.Windows.Forms.Label();
            this.toolTipEmployeeAverage = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelDayCounter
            // 
            this.labelDayCounter.AutoSize = true;
            this.labelDayCounter.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayCounter.Location = new System.Drawing.Point(278, 36);
            this.labelDayCounter.Name = "labelDayCounter";
            this.labelDayCounter.Size = new System.Drawing.Size(112, 37);
            this.labelDayCounter.TabIndex = 0;
            this.labelDayCounter.Text = "Day: 1";
            this.toolTipEmployeeAverage.SetToolTip(this.labelDayCounter, "What day you are inputting units for");
            // 
            // labelUnitsInput
            // 
            this.labelUnitsInput.AutoSize = true;
            this.labelUnitsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitsInput.Location = new System.Drawing.Point(43, 106);
            this.labelUnitsInput.Name = "labelUnitsInput";
            this.labelUnitsInput.Size = new System.Drawing.Size(68, 25);
            this.labelUnitsInput.TabIndex = 1;
            this.labelUnitsInput.Text = "Units:";
            // 
            // textBoxEmployee1
            // 
            this.textBoxEmployee1.Location = new System.Drawing.Point(48, 206);
            this.textBoxEmployee1.Multiline = true;
            this.textBoxEmployee1.Name = "textBoxEmployee1";
            this.textBoxEmployee1.ReadOnly = true;
            this.textBoxEmployee1.Size = new System.Drawing.Size(172, 164);
            this.textBoxEmployee1.TabIndex = 2;
            this.toolTipEmployeeAverage.SetToolTip(this.textBoxEmployee1, "Units for first employee");
            // 
            // textBoxEmployee3
            // 
            this.textBoxEmployee3.Location = new System.Drawing.Point(455, 206);
            this.textBoxEmployee3.Multiline = true;
            this.textBoxEmployee3.Name = "textBoxEmployee3";
            this.textBoxEmployee3.ReadOnly = true;
            this.textBoxEmployee3.Size = new System.Drawing.Size(172, 164);
            this.textBoxEmployee3.TabIndex = 6;
            this.toolTipEmployeeAverage.SetToolTip(this.textBoxEmployee3, "Units for third employee");
            // 
            // textBoxEmployee2
            // 
            this.textBoxEmployee2.Location = new System.Drawing.Point(255, 206);
            this.textBoxEmployee2.Multiline = true;
            this.textBoxEmployee2.Name = "textBoxEmployee2";
            this.textBoxEmployee2.ReadOnly = true;
            this.textBoxEmployee2.Size = new System.Drawing.Size(172, 164);
            this.textBoxEmployee2.TabIndex = 4;
            this.toolTipEmployeeAverage.SetToolTip(this.textBoxEmployee2, "Units for second employee");
            // 
            // labelEmployee1
            // 
            this.labelEmployee1.AutoSize = true;
            this.labelEmployee1.Location = new System.Drawing.Point(83, 160);
            this.labelEmployee1.Name = "labelEmployee1";
            this.labelEmployee1.Size = new System.Drawing.Size(92, 20);
            this.labelEmployee1.TabIndex = 5;
            this.labelEmployee1.Text = "Employee 1";
            // 
            // labelEmployeeAverage2
            // 
            this.labelEmployeeAverage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployeeAverage2.Location = new System.Drawing.Point(255, 403);
            this.labelEmployeeAverage2.Name = "labelEmployeeAverage2";
            this.labelEmployeeAverage2.Size = new System.Drawing.Size(172, 29);
            this.labelEmployeeAverage2.TabIndex = 5;
            this.toolTipEmployeeAverage.SetToolTip(this.labelEmployeeAverage2, "Average units shipped for second employee");
            // 
            // labelEmployee3
            // 
            this.labelEmployee3.AutoSize = true;
            this.labelEmployee3.Location = new System.Drawing.Point(495, 160);
            this.labelEmployee3.Name = "labelEmployee3";
            this.labelEmployee3.Size = new System.Drawing.Size(92, 20);
            this.labelEmployee3.TabIndex = 7;
            this.labelEmployee3.Text = "Employee 3";
            // 
            // labelTotalAverage
            // 
            this.labelTotalAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalAverage.Location = new System.Drawing.Point(116, 458);
            this.labelTotalAverage.Name = "labelTotalAverage";
            this.labelTotalAverage.Size = new System.Drawing.Size(430, 27);
            this.labelTotalAverage.TabIndex = 8;
            this.labelTotalAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipEmployeeAverage.SetToolTip(this.labelTotalAverage, "Average of all employees");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(70, 526);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(105, 37);
            this.buttonEnter.TabIndex = 9;
            this.buttonEnter.Text = "&Enter";
            this.toolTipEmployeeAverage.SetToolTip(this.buttonEnter, "Press to progress");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(285, 526);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(105, 37);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "&Reset";
            this.toolTipEmployeeAverage.SetToolTip(this.buttonReset, "Press to reset form");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(482, 526);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(105, 37);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "E&xit";
            this.toolTipEmployeeAverage.SetToolTip(this.buttonExit, "Press to exit form");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxUnits
            // 
            this.textBoxUnits.Location = new System.Drawing.Point(144, 107);
            this.textBoxUnits.Name = "textBoxUnits";
            this.textBoxUnits.Size = new System.Drawing.Size(76, 26);
            this.textBoxUnits.TabIndex = 0;
            this.toolTipEmployeeAverage.SetToolTip(this.textBoxUnits, "Input units shipped");
            // 
            // labelEmployeeAverage3
            // 
            this.labelEmployeeAverage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployeeAverage3.Location = new System.Drawing.Point(455, 403);
            this.labelEmployeeAverage3.Name = "labelEmployeeAverage3";
            this.labelEmployeeAverage3.Size = new System.Drawing.Size(172, 29);
            this.labelEmployeeAverage3.TabIndex = 7;
            this.toolTipEmployeeAverage.SetToolTip(this.labelEmployeeAverage3, "Average units shipped for third employee");
            // 
            // labelEmployeeAverage1
            // 
            this.labelEmployeeAverage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployeeAverage1.Location = new System.Drawing.Point(48, 403);
            this.labelEmployeeAverage1.Name = "labelEmployeeAverage1";
            this.labelEmployeeAverage1.Size = new System.Drawing.Size(172, 29);
            this.labelEmployeeAverage1.TabIndex = 3;
            this.toolTipEmployeeAverage.SetToolTip(this.labelEmployeeAverage1, "Average units shipped for first employee");
            // 
            // labelEmployee2
            // 
            this.labelEmployee2.AutoSize = true;
            this.labelEmployee2.Location = new System.Drawing.Point(298, 160);
            this.labelEmployee2.Name = "labelEmployee2";
            this.labelEmployee2.Size = new System.Drawing.Size(92, 20);
            this.labelEmployee2.TabIndex = 15;
            this.labelEmployee2.Text = "Employee 2";
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 598);
            this.Controls.Add(this.labelEmployee2);
            this.Controls.Add(this.labelEmployeeAverage1);
            this.Controls.Add(this.labelEmployeeAverage3);
            this.Controls.Add(this.textBoxUnits);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelTotalAverage);
            this.Controls.Add(this.labelEmployee3);
            this.Controls.Add(this.labelEmployeeAverage2);
            this.Controls.Add(this.labelEmployee1);
            this.Controls.Add(this.textBoxEmployee2);
            this.Controls.Add(this.textBoxEmployee3);
            this.Controls.Add(this.textBoxEmployee1);
            this.Controls.Add(this.labelUnitsInput);
            this.Controls.Add(this.labelDayCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lab3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped By Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDayCounter;
        private System.Windows.Forms.Label labelUnitsInput;
        private System.Windows.Forms.TextBox textBoxEmployee1;
        private System.Windows.Forms.TextBox textBoxEmployee3;
        private System.Windows.Forms.TextBox textBoxEmployee2;
        private System.Windows.Forms.Label labelEmployee1;
        private System.Windows.Forms.Label labelEmployeeAverage2;
        private System.Windows.Forms.Label labelEmployee3;
        private System.Windows.Forms.Label labelTotalAverage;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxUnits;
        private System.Windows.Forms.Label labelEmployeeAverage3;
        private System.Windows.Forms.Label labelEmployeeAverage1;
        private System.Windows.Forms.Label labelEmployee2;
        private System.Windows.Forms.ToolTip toolTipEmployeeAverage;
    }
}

