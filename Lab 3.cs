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
        int counter = 0;
        int dayTracker = 7;
        double sum = 0;
        double totalAverage = 0;

        #endregion

        public Lab3()
        {
            InitializeComponent();

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

            if(int.TryParse(textBoxUnits.Text, out validUnits) && (validUnits > MiniumumRange & validUnits < MaximumRange))
            {
                    if(counter < AverageNumber)
                    {
                        textBoxEmployee1.Text += textBoxUnits.Text + "\r\n";
                        counter++;
                    }
                    else if(counter >= AverageNumber && counter < LastUnit)
                    {
                        textBoxEmployee2.Text += textBoxUnits.Text + "\r\n";
                        counter++;
                    }
                    else if (counter > LastUnit)
                    {
                        textBoxEmployee3.Text += textBoxUnits.Text + "\r\n";
                        counter++;
                    }




                    for (shipped = 0; shipped < units.GetLength(1); shipped++) 
                {
                    units[employee, shipped] = validUnits;
                };
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
