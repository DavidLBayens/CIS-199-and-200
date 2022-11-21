// Program 3
// CIS-199-02
// Due 4/1/2021
// By: S9223 (ID)

// This Windows form application is designed to calculate the cost of shipping
// to certain states/ farms based on what is ordered. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_199_02_Program_3
{
    public partial class Program3 : Form
    {
        public Program3()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // All of the arrays that are used in the code
            string[] states = { "NE", "NW", "SE", "SW" };
            double[] shipfee = { 0.06, 0.0717, 0.07, 0.0874 };

            int[] itemnumber = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 };
            double[] costperpound = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };

            int[] pounds = { 0,6,11,21 };
            double[] discount = { 0, .05, .10, .15 };

            // Additional variables
            int  quantity;
            double initialcost, discountA, item, discountedcost, fee, shipmentcost, total;
            double customerdiscount = 0;
            bool found = false;
            quantity = int.Parse(QuantityText.Text);
            
            // Code used to calaculate the initial cost.
            // I had a hard time truly incorporating arrays here so I improvised.
            if (ItemCombo.Text == "10001")
             item = costperpound[0];
               
            else if (ItemCombo.Text == "10002")
             item = costperpound[1];
               
            else if (ItemCombo.Text == "10003")
             item = costperpound[2];
                
            else if (ItemCombo.Text == "10004")
             item = costperpound[3];

            else if (ItemCombo.Text == "10005")
             item = costperpound[4];
               
            else if (ItemCombo.Text == "10006")
             item = costperpound[5];
                
            else if (ItemCombo.Text == "10007")
             item = costperpound[6];
                
            else
             item = 0;

            initialcost = quantity * item;
           
        
        // Code used to calculate the discount.
        // I was able to inplement the arrays here thankfully.
        int index = pounds.Length - 1;

            while (index >= 0 && !found)
            {
                if (quantity >= pounds[index])
                    found = true;
                else
                    --index;
            }
            if (found)
                customerdiscount = discount[index];

            discountA = initialcost * customerdiscount;
            discountedcost = initialcost - discountA;

            // Code used to calculate the shipment cost.
            // Again, the combo boxes confused me so I used the arrays how I could.
            if (FarmCombo.Text == "NE")
                fee = shipfee[0];

            else if (FarmCombo.Text == "NW")
                fee = shipfee[1];

            else if (FarmCombo.Text == "SE")
                fee = shipfee[2];

            else if (FarmCombo.Text == "SW")
                fee = shipfee[3];

            else
                fee = 0;

            shipmentcost = discountedcost * fee;

            // Final calculations
            total = discountedcost + shipmentcost;

            // Code used to output the info into the form.
            CostBox.Text = $"{initialcost:C2}";
            DiscountBox.Text = $"{discountedcost:C2}";
            ShipmentBox.Text = $"{shipmentcost:C2}";
            TotalBox.Text = $"{total:C2}"; 
        }
        // Additional form code.
        private void Program3_Load(object sender, EventArgs e)
        {
            BackColor = Color.Silver;
        }
    }
}
