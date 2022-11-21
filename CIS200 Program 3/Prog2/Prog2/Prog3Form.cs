// Program 3
// CIS 200-76
// Fall 2020
// Due: 11/15/2021
// By: 5394923

// File: Prog3Form.cs
// This class creates the main GUI for Program 3, It provides a form that offers file, insert, report, and edit tabs that each offer various additional usage.
// The program 3 version allows for the ability to save files and open files through serialization and allows you to edit addresses in addition to everything that program 2 offered.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace UPVApp
{
    public partial class Prog3Form : Form
    {
        private UserParcelView upv; // The UserParcelView

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test addresses are
        //                added to the list of addresses
        public Prog3Form()
        {
            InitializeComponent();

            upv = new UserParcelView();

            // Test Data

            // Test Addresses
            //upv.AddAddress("Daniel Collins", "1234 Virgina Avenue",
            //    "Fort Lauderdale", "FL", 33302);
            //upv.AddAddress("Jeffery Fillmore", "3845 7th Street", "Apt 13",
            //    "Des Moines", "IA", 50303);
            //upv.AddAddress("Shelby Miller", "6948 Grand blvd",
            //    "Little Rock", "AR", 72201);
            //upv.AddAddress("Giles Mason", "756 West Sycamore Street", "PO box 412",
            //    "Albany", "NY", 12202);
            //upv.AddAddress("Gerry Baxter", "9234 Brandy Street",
            //    "Honolulu", "HI", 96795);
            //upv.AddAddress("Barbara Thrasher", "555 Jackson Turnpike", "Apt 3",
            //    "Dallas", "TX", 75039);
            //upv.AddAddress("Kyle Douglas", "1272 Iroquois Parkway",
            //    "Louisville", "KY", 40258);
            //upv.AddAddress("Christine Beverly", "8302 Iron Road",
            //    "Las Vegas", "NV", 88905);

            //// Test Parcels
            //upv.AddLetter(upv.AddressAt(3), upv.AddressAt(7), 2.82M);
            //upv.AddLetter(upv.AddressAt(5), upv.AddressAt(2), 1.39M);
            //upv.AddGroundPackage(upv.AddressAt(4), upv.AddressAt(0), 17, 11, 9, 18.9);
            //upv.AddGroundPackage(upv.AddressAt(1), upv.AddressAt(6), 12.3, 5.6, 7.8, 9.7);
            //upv.AddNextDayAirPackage(upv.AddressAt(3), upv.AddressAt(5), 33, 7, 18,
            //    77, 8.59M);
            //upv.AddNextDayAirPackage(upv.AddressAt(7), upv.AddressAt(6), 15.5, 8.7, 3.6,
            //    3.56, 8.51M);
            //upv.AddTwoDayAirPackage(upv.AddressAt(1), upv.AddressAt(2), 82.5, 39.1, 33.4,
            //    81.7, TwoDayAirPackage.Delivery.Saver);
            //upv.AddTwoDayAirPackage(upv.AddressAt(2), upv.AddressAt(5), 55.7, 8.6, 17.2,
            //    45.6, TwoDayAirPackage.Delivery.Early);
        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // Newline shorthand

            MessageBox.Show("Program 3 By: 5394923");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Insert, Address menu item activated
        // Postcondition: The Address dialog box is displayed. If data entered
        //                are OK, an Address is created and added to the list
        //                of addresses
        private void addressToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();    // The address dialog box form
            DialogResult result = addressForm.ShowDialog(); // Show form as dialog and store result
            int zip; // Address zip code

            if (result == DialogResult.OK) // Only add if OK
            {
                if (int.TryParse(addressForm.ZipText, out zip))
                {
                    upv.AddAddress(addressForm.AddressName, addressForm.Address1,
                        addressForm.Address2, addressForm.City, addressForm.State,
                        zip); // Use form's properties to create address
                }
                else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
                }
            }

            addressForm.Dispose(); // Best practice for dialog boxes
                                   // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Addresses menu item activated
        // Postcondition: The list of addresses is displayed in the addressResultsTxt
        //                text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Addresses:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Address a in upv.AddressList)
            {
                result.Append(a.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
            }

            reportTxt.Text = result.ToString();

            // -- OR --
            // Not using StringBuilder, just use TextBox directly

            //reportTxt.Clear();
            //reportTxt.AppendText("Addresses:");
            //reportTxt.AppendText(NL); // Remember, \n doesn't always work in GUIs
            //reportTxt.AppendText(NL);

            //foreach (Address a in upv.AddressList)
            //{
            //    reportTxt.AppendText(a.ToString());
            //    reportTxt.AppendText(NL);
            //    reportTxt.AppendText("------------------------------");
            //    reportTxt.AppendText(NL);
            //}

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        // Precondition:  Insert, Letter menu item activated
        // Postcondition: The Letter dialog box is displayed. If data entered
        //                are OK, a Letter is created and added to the list
        //                of parcels
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm; // The letter dialog box form
            DialogResult result;   // The result of showing form as dialog
            decimal fixedCost;     // The letter's cost

            if (upv.AddressCount < LetterForm.MIN_ADDRESSES) // Make sure we have enough addresses
            {
                MessageBox.Show("Need " + LetterForm.MIN_ADDRESSES + " addresses to create letter!",
                    "Addresses Error");
                return; // Exit now since can't create valid letter
            }

            letterForm = new LetterForm(upv.AddressList); // Send list of addresses
            result = letterForm.ShowDialog();

            if (result == DialogResult.OK) // Only add if OK
            {
                if (decimal.TryParse(letterForm.FixedCostText, out fixedCost))
                {
                    // For this to work, LetterForm's combo boxes need to be in same
                    // order as upv's AddressList
                    upv.AddLetter(upv.AddressAt(letterForm.OriginAddressIndex),
                        upv.AddressAt(letterForm.DestinationAddressIndex),
                        fixedCost); // Letter to be inserted
                }
                else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Letter Validation!", "Validation Error");
                }
            }

            letterForm.Dispose(); // Best practice for dialog boxes
                                  // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: The list of parcels is displayed in the parcelResultsTxt
        //                text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            decimal totalCost = 0;                      // Running total of parcel shipping costs
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Parcels:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Parcel p in upv.ParcelList)
            {
                result.Append(p.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
                totalCost += p.CalcCost();
            }

            result.Append(NL);
            result.Append($"Total Cost: {totalCost:C}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        // Program 3 Code

        // Opens the Address editer provided there are addresses present
        // Allows the user to edit addresses within the saved contents
        private void addressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (upv.AddressList.Count > 0) 
            {
                ChooseAddressForm chooseAddForm = new ChooseAddressForm(upv.AddressList); 
                DialogResult result = chooseAddForm.ShowDialog();                         

                if (result == DialogResult.OK) 
                {
                    // Index of addresses
                    int editIndex; 
                    editIndex = chooseAddForm.AddressIndex;

                    if (editIndex >= 0)
                    {
                        Address editAddress = upv.AddressAt(editIndex); 
                        AddressForm addressForm = new AddressForm();   

                        // Populate the fileds of the form with provided content
                        addressForm.AddressName = editAddress.Name;
                        addressForm.Address1 = editAddress.Address1;
                        addressForm.Address2 = editAddress.Address2;
                        addressForm.City = editAddress.City;
                        addressForm.State = editAddress.State;
                        addressForm.ZipText = $"{editAddress.Zip:D5}";

                        result = addressForm.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            // Edit the address properties contents
                            editAddress.Name = addressForm.AddressName;
                            editAddress.Address1 = addressForm.Address1;
                            editAddress.Address2 = addressForm.Address2;
                            editAddress.City = addressForm.City;
                            editAddress.State = addressForm.State;
                            if (int.TryParse(addressForm.ZipText, out int zip))
                            {
                                editAddress.Zip = zip;
                            }
                            else
                            {
                                MessageBox.Show("Issue With Validating the Zip", "Validation Error");
                            }
                        }
                        addressForm.Dispose();
                    }
                }
                chooseAddForm.Dispose();
            }
            else
                MessageBox.Show("There is No Address to Edit", "No Addresses");
        }

        // The SaveAs toolstrip menu item was clicked and will save barring any errors using serialization 
        private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream output = null;             

            DialogResult result;
            string fileName;

            // Save dialog
            using (SaveFileDialog fileChooser = new SaveFileDialog()) 
            {
                fileChooser.CheckFileExists = false; 

                // retrieve results
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; 
            } 

            // Clicked OK button
            if (result == DialogResult.OK)
            {

                // Error for invalid file name
                if (fileName == string.Empty)
                    MessageBox.Show("File Name is Invalid","Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // will attempt to save file
                    try
                    {
                        output = new FileStream(fileName, FileMode.Create, FileAccess.Write);

                        formatter.Serialize(output, upv); 
                    }
                    // Handle potential exception
                    catch (IOException)
                    {
                        // notify if file can't be opened
                        MessageBox.Show("Error Writing Contents to File", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 

                    // notify if there is a serialization error
                    catch (SerializationException)
                    {
                        MessageBox.Show("Error With Serialization When Writing to File", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                    finally
                    {
                        output?.Close(); 
                    }
                } 
            } 
        }

        // The Open menu item has been clicked/ activated
        // serialization will overwrite existing program contents
        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BinaryFormatter reader = new BinaryFormatter();
            FileStream input = null;

            DialogResult result;
            string fileName;

            UserParcelView temp;                   

            // Create a dilaog box
            using (OpenFileDialog fileChooser = new OpenFileDialog()) 
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; 
            } 

            // Clicked OK button
            if (result == DialogResult.OK)
            {
                // Error if invalid file
                if (fileName == string.Empty)
                    MessageBox.Show("File Name is Invalid", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // Allows access for files to be read
                    try
                    {

                        input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                        temp = (UserParcelView)reader.Deserialize(input);

                        upv = temp;
                    } 

                    // Exception handler for file errors
                    catch (IOException)
                    {
                        // notify if file could not be opened
                        MessageBox.Show("Error Reading Contents From File", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 

                    catch (SerializationException)
                    {
                        MessageBox.Show("Error with Serialization When Reading From File", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    { 
                        input?.Close();
                    }
                } 
            } 
        }
       
    }
}