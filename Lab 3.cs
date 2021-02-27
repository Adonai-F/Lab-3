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
   

        public Lab3()
        {
            InitializeComponent();
       
        }
     
        #region "Declarations"
        // Initialize array
        int[,] units = new int[3, 7];

        // Global Variables.
        int counter = 0;
        int dayTracker = 2;
        double sum = 0;
        double employee1Average, employee2Average;

        #endregion


        #region "Event Handlers"
        private void buttonEnter_Click(object sender, EventArgs e)
        {

            int validUnits;
            int employee;
            int shipped;
            double employee1, employee2, employee3;
            const int AverageNumber = 7;
            const int MidUnit = 14;
            const int LastUnit = 21;
            const int MiniumumRange = 0;
            const int MaximumRange = 5000;

            while (counter < LastUnit)
            {
                if (int.TryParse(textBoxUnits.Text, out validUnits) && (validUnits > MiniumumRange & validUnits < MaximumRange))
                {
                    sum += validUnits;

                    if (counter < AverageNumber)
                    {
                        textBoxEmployee1.Text += textBoxUnits.Text + "\r\n";
                        counter++;
                        employee1 = sum / AverageNumber;
                        Math.Round(employee1);
                        employee1Average = employee1;
                       
                        labelDayCounter.Text = "Day: " + dayTracker++;
                        if (counter == AverageNumber) { labelEmployeeAverage1.Text = "Average: " + employee1; sum = 0; }

                        // Clear textbox for another input.
                        textBoxUnits.Clear();
                        break;
                    }
                    else if (counter >= AverageNumber && counter < MidUnit)
                    {
                        textBoxEmployee2.Text += textBoxUnits.Text + "\r\n";
                        counter++;
                        employee2 = sum / AverageNumber;
                        Math.Round(employee2, 2);
                        employee2Average = employee2;
                        labelDayCounter.Text = "Day: " + dayTracker++;
                        if (counter == MidUnit) { labelEmployeeAverage2.Text = "Average: " + employee2; sum = 0; }

                        // Clear textbox for another input.
                        textBoxUnits.Clear();
                        break;
                    }
                    else if (counter >= MidUnit && counter <= LastUnit)
                    {
                        textBoxEmployee3.Text += textBoxUnits.Text + "\r\n";
                        counter++;
                        employee3 = sum / AverageNumber;
                        Math.Round(employee3, 2);
                        labelDayCounter.Text = "Day: " + dayTracker++;
                        if (counter == LastUnit)
                        {
                            labelEmployeeAverage3.Text = "Average: " + employee3;
                            CalculateTotal(employee1Average, employee2Average, employee3);
                            labelDayCounter.Text = "Done";
                            validUnits = 0;
                            employee3 = 0;
                            
                            
                        }
                        
                        // Clear textbox for another input.
                        textBoxUnits.Clear();
                        break;
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Reset Variables.
            counter = 0;
            dayTracker = 2;
            sum = 0;

            // Clear all fields.
            textBoxUnits.Clear();
            textBoxEmployee1.Clear();
            textBoxEmployee2.Clear();
            textBoxEmployee3.Clear();
            labelTotalAverage.Text = "";
            labelDayCounter.Text = "Day: 1";
            labelEmployeeAverage1.Text = "";
            labelEmployeeAverage2.Text = "";
            labelEmployeeAverage3.Text = "";

            // Enable input controls.
            textBoxUnits.Enabled = true;
            buttonEnter.Enabled = true;

            // Highlight units textbox.
            textBoxUnits.Focus();
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

        private void CalculateTotal(double employee1, double employee2, double employee3) {
            double sum = employee1 + employee2 + employee3;
            double finalAverage = sum / 3;
            labelTotalAverage.Text = "Total Average: " + Math.Round(finalAverage, 2);
            textBoxUnits.Enabled = false;
            buttonEnter.Enabled = false;
            buttonReset.Focus();
            
        }

        #endregion




    }
}
