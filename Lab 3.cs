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
        double finalTotal = 0;

        // Constant definitions.
        const int EmployeeTotal = 3;
        const int Days = 7;

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
                    if (day == Days )
                    {
                        // New variable to store total average.
                        int employeeTotal = 0;
                        double totalAverages = 0;
                        labelDayCounter.Text = "Day: " + (day - 1);

                        // Perform calculations.
                        for (int currentDay = 0; currentDay < Days; currentDay++)
                        {
                            employeeTotal += unitsArray[employee, day - 1];
                        }

                        for (int averageCounter = 0; averageCounter < EmployeeTotal; averageCounter++)
                        {
                            totalAverages = Math.Round((double)employeeTotal / Days, 2);
                            averagesArray[averageCounter] = averageCounter + totalAverages;
                        }

                        // Display averages in output label.
                        averages[employee].Text = "Average: " + totalAverages;

                        // Reset the day. 
                        day = 0;
                        // Go to next employee.
                        employee++;
                    }
                    if (employee >= EmployeeTotal)
                    {
                        // Calculate total average of all employees.
                        foreach(int record in averagesArray)
                        {
                            double average = 0;
                            double final = 0;

                            average += record;
                            final = average / EmployeeTotal;
                        }
                        labelTotalAverage.Text = "Total Average: " + final;
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

        private double StoreValues(double employeeAverage)
        {
            // Add all the averages

            double finalTotal = 0;

            finalTotal = finalTotal + employeeAverage;

            return finalTotal;
        }
      
        /// <summary>
        /// Will calculate the total average of all employees
        /// </summary>
        /// <param name="finalAverage"></param>       
        private double CalculateTotal(double finalAverage) 
        {
            foreach (int record in averagesArray)
            {
                double average = 0;
                double final = 0;
                average += record;
                final = average / EmployeeTotal;
                return final;
            }
            labelDayCounter.Text = "Done";
        }
        private void ClearControls(Control[] controlArray)
        {
            foreach (Control controlToClear in controlArray)
            {
                controlToClear.Text = String.Empty;
            }
        }

        private void ResetForm()
        {
            // Reset Variables.
            employee = 0;
            day = 0;
            finalTotal = 0;
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
