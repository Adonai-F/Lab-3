// Adonai Ford-Williams
// Lab 3
// Date: Feb 27nd, 2021
// NETD2202
// Description: 
// This program calculates the average of seven user inputted whole numbers for three different users. 
// Will calculate entire average once done


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class Lab3 : Form {
        
        #region "Declarations"
        // Class-level variable declarations.
        int employee = 0;
        int day = 0;

        // Constant definitions.
        const int EmployeeTotal = 3;
        const int Week = 7;
        const int Days = 8;

        // Arrays.
        int[,] unitsArray = new int[EmployeeTotal, Days];
        double[] averagesArray = new double[EmployeeTotal];
        TextBox[] employees;
        Label[] averages;


        public Lab3()
        {
            InitializeComponent();
            ResetForm();

            // Initiialize array.
            employees = new TextBox[] { textBoxEmployee1, textBoxEmployee2, textBoxEmployee3 };
            averages = new Label[] {labelEmployeeAverage1, labelEmployeeAverage2, labelEmployeeAverage3 };
       
        }

        #endregion

        /// <summary>
        /// This activates the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region "Event Handlers"
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            // Local variable declaration 
            const int MiniumumRange = 0;
            const int MaximumRange = 5000;

            // New variable to store total average.
            int employeeTotal = 0;

            // Validate for whole number.
            if (int.TryParse(textBoxUnits.Text, out unitsArray[employee, day]))
            {
                // Validate for valid range.
                if (unitsArray[employee, day] >= MiniumumRange && unitsArray[employee, day] <= MaximumRange)
                {
                    // Add values from the units textbox to the employees textbox.
                    employees[employee].Text += unitsArray[employee, day] + "\r\n";
                    textBoxUnits.Clear();

                    // Increase day label and counter
                    ++day;
                    labelDayCounter.Text = "Day: " + (day + 1);

                    // Look to see if we are past seventh day.
                    if (day == Week )
                    {
                       
                        labelDayCounter.Text = "Day: " + (day);

                        // Perform calculations.
                        for (int currentDay = 0; currentDay < Days; currentDay++)
                        {
                            employeeTotal += unitsArray[employee, day];
                        }

                        // Display averages in output label.
                        averages[employee].Text = "Averages: " + Math.Round((double)employeeTotal / Week, 2);
                        averagesArray[employee] += Math.Round((double)employeeTotal / Week, 2);

                        // Reset the day. 
                        day = 0;
                        // Go to next employee.
                        employee++;
                    }
                    if (employee >= EmployeeTotal)
                    {
                        double average = 0;
                        double final = 0;

                        // Calculate total average of all employees.
                        average = averagesArray.Sum();
                        final = average / EmployeeTotal;
   
                        labelTotalAverage.Text = "Total Average: " + Math.Round(final, 2); 
                        employee = 0;

                        // Disable butons and textbox.
                        textBoxUnits.Enabled = false;
                        buttonEnter.Enabled = false;
                        buttonReset.Focus();
                    }
                }
                else
                {
                    // Error message for out of range.
                    MessageBox.Show("Please input a whole number between " + MiniumumRange + " and " + MaximumRange);
                    textBoxUnits.SelectAll();
                    textBoxUnits.Focus();
                }
            }
            else
            {
                // Error message for not a whole number.
                MessageBox.Show("Please input a numeric value. Try again");
                textBoxUnits.SelectAll();
                textBoxUnits.Focus();

            }


        }

        private void buttonReset_Click(object sender, EventArgs e)
             {
            ResetForm();       
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Exit application
            Close();
        }
        #endregion

        #region "Functions"

        private void ResetForm()
        {
            // Reset Variables.
            employee = 0;
            day = 0;
            labelDayCounter.Text = "Day: " + day + 1;

            // Clear all fields.
            textBoxUnits.Clear();
            textBoxEmployee1.Clear();
            textBoxEmployee2.Clear();
            textBoxEmployee3.Clear();
            labelTotalAverage.Text = String.Empty;
            labelEmployeeAverage1.Text = String.Empty;
            labelEmployeeAverage2.Text = String.Empty;
            labelEmployeeAverage3.Text = String.Empty;

            // Enable input controls.
            textBoxUnits.Enabled = true;
            buttonEnter.Enabled = true;

            // Highlight units textbox.
            textBoxUnits.Focus();
        }
        #endregion
    }
}
