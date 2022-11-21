// Lab 4
// CIS-199-02
// Due: 2/21/2021
// By: S9223 (ID)

// This is Windows form application that is designed to both accept and reject students to a 
// university based on two credentials. The first being their highschool GPA and the second being their admissions test score.
// This program also outputs the number of students that have been rejected and accepted by the program.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_199_02_Lab_4
{
    public partial class Lab4 : Form
    {
        // Counter Variables
        private int AcceptCounter = 0;
        private int RejectCounter = 0;
        public Lab4()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
           
            int Test;
            float GPA;
            const double GoodGPA = 3.0; // Variable for an acceptable GPA by some standards.
            const double PerfectGPA = 4.0; // Variable for the max possible GPA in this instance.
            const double TerribleGPA = 0; // Variable for the lowest possible GPA.
            const int GoodTest = 80; // Variable for an acceptable test in.
            const int PoorTest = 60; // Variable for an acceptable test based on GPA. 
            const int PerfectTest = 100; // The Highest possible test score.
            const int TerribleTest = 0; // The Worst possible test score.

            // The variables that are inputed by the user and the output that would occur based
            // on what is typed into the textboxes.
            if (float.TryParse(GPAinput.Text, out GPA))
                if (int.TryParse(ATSinput.Text, out Test))
                    // The main code for the form that determines who would be accepted or rejected. Or alternatively if the input was invalid.
                {
                    if ((GPA >= GoodGPA) && (Test >= PoorTest) && (GPA <= PerfectGPA) && (Test <= PerfectTest))
                        MessageBox.Show("Accepted");

                    else if ((GPA >= TerribleGPA) && (Test >= GoodTest) && (Test <= PerfectTest) && (GPA <= PerfectGPA))
                        MessageBox.Show("Accepted");

                    else if ((GPA > PerfectGPA) || (GPA < TerribleGPA))
                        MessageBox.Show("Invalid Credentials");

                    else if ((Test > PerfectTest) || (Test < TerribleTest))
                        MessageBox.Show("Invalid Credentials");

                    else MessageBox.Show("Rejected");
                }



            if (float.TryParse(GPAinput.Text, out GPA))
                if (int.TryParse(ATSinput.Text, out Test))
                    // The code that is used to dictate rather or not the acceptance counter increases or the 
                    // Rejected counter increses.
                { 
                    if ((GPA >= GoodGPA) && (Test >= PoorTest) && (GPA <= PerfectGPA) && (Test <= PerfectTest))
                        ++AcceptCounter;

                    else if ((GPA >= TerribleGPA) && (Test >= GoodTest) && (Test <= PerfectTest) && (GPA <= PerfectGPA))
                        ++AcceptCounter;
                   
                    else if ((GPA > GoodGPA) && (Test < PoorTest) && (Test >= TerribleTest) && (GPA <= PerfectGPA))  
                        ++RejectCounter;

                    else if ((GPA >= TerribleGPA) && (GPA <= PerfectGPA) && (Test < GoodTest) && (Test >= TerribleTest))
                        ++RejectCounter;
                }
            // Changes the Accept and Reject labels numeric values in accordance with the input and code.
            Accepted.Text = $"{AcceptCounter}";
            Rejected.Text = $"{RejectCounter}";
            }
    }
}
