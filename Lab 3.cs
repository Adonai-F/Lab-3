// Adonai Ford-Williams
// Lab 3
// Date: Feb 27nd, 2021
// NETD2202
// Description: 
// This program calculates the average of seven user inputted whole numbers for three different users. 
// ****Will calculate entire average once done
// ** Could not figure out why the averages wouldn't work **


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
    public partial class Lab3 : Form
    {
        #region "Declarations"
        // Initialize array
        int[,] units = new int[3,7];

        // Global Variables.
        bool go;
        int counter = 0;
        int dayTracker = 1;
        double sum = 0;
        double totalAverage = 0;

        #endregion

        public Lab3()
        {
            InitializeComponent();
            int[,] units = new int[3, 7];

        }

       
        #region "Event Handlers"
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            
            int validUnits;
            int employee;
            int shipped;
            const int AverageNumber = 7;
            const int LastUnit = 14;
            const int MiniumumRange = 0;
            const int MaximumRange = 5000;

            for(employee = 0; employee < units.GetLength(0); employee++) 
            {
                while (go)
                {
                    if (int.TryParse(textBoxUnits.Text, out validUnits) && (validUnits > MiniumumRange & validUnits < MaximumRange))
                    {
                        for (shipped = 0; shipped < units.GetLength(1); shipped++)
                        {
                            units[employee, shipped] = validUnits;
                            sum += validUnits;
                        }
                        double employeeAverage = sum / AverageNumber;

                        if (counter < AverageNumber)
                        {
                            textBoxEmployee1.Text += textBoxUnits.Text + "\r\n";
                            counter++;
                            labelDayCounter.Text= "Day: " + dayTracker++;
                            double employee1 = employeeAverage;
                            totalAverage += employee1;
                            employeeAverage = 0;
                            if (counter == AverageNumber) { labelEmployeeAverage1.Text = "Average: " + Math.Round(employee1, 2); }
                            
                            // Clear textbox for another input.
                            textBoxUnits.Clear();
                            break;
                        }
                        else if (counter >= AverageNumber && counter < LastUnit)
                        {
                            textBoxEmployee2.Text += textBoxUnits.Text + "\r\n";
                            counter++;
                            double employee2 = employeeAverage;
                            totalAverage += employee2;
                            employeeAverage = 0;
                            if (counter == LastUnit) { labelEmployeeAverage2.Text = "Average: " + Math.Round(employee2, 2); }
                            
                            // Clear textbox for another input.
                            textBoxUnits.Clear();
                            break;
                        }
                        else if (counter > LastUnit)
                        {
                            textBoxEmployee3.Text += textBoxUnits.Text + "\r\n";
                            counter++;
                            double employee3 = employeeAverage;
                            totalAverage += employee3;
                            
                            employeeAverage = 0;
                            if (counter == 23) {
                                labelEmployeeAverage3.Text = "Average: " + Math.Round(employee3, 2);
                                go = false;
                            }
                        }

          
                    }

                    else
                    {
                        MessageBox.Show("Please input a whole number between " + MiniumumRange + " and " + MaximumRange);
                        textBoxUnits.SelectAll();
                        textBoxUnits.Focus();
                        break;
                    }
                }
            }
            while(go == false) 
            {
                double finalTotal = totalAverage / units.GetLength(0);
                labelDayCounter.Text = "Done";
                labelTotalAverage.Text = "Total Average: " + finalTotal;
            }
            

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region "Functions"
        private void ClearControls(Control[] controlArray)
        {
            foreach (Control controlToClear in controlArray)
            {
                controlToClear.Text = String.Empty;
            }
        }

        /// <summary>
        /// This enables or disables all controls in an array of controls that is passed in
        /// </summary>
        /// <param name="controlArray">An array of controls to enable or disable</param>
        /// <param name="enabledStatus">true to enable, false to disable</param>
        private void SetControlsEnabled(Control[] controlArray, bool enabledStatus)
        {
            foreach (Control controlToSet in controlArray)
            {
                controlToSet.Enabled = enabledStatus;
            }
        }

        #endregion




    }
}
