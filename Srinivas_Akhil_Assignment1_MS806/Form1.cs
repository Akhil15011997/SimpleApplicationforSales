using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Srinivas_Akhil_Assignment1_MS806
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //TootTips for Clear and Exit Buttons
            ToolTips.SetToolTip(ClearButton, "Press to Clear form for the next user");
            ToolTips.SetToolTip(ExitButton, "Press to Exit Application");
            ToolTips.SetToolTip(OrderButton, "Enter quantity of your favourite Pizza/s");
        }

        //setting maximum length for ServerNameTextBox
        private void ServerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ServerNameTextBox.MaxLength = 50;
        }

        //Disabling numeric values for servername
        private void ServerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        //Disabling alphabetical values for table Number
        private void TableNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        //Limiting the table numbers -- Upto 15
        private void TableNoTextBox_TextChanged(object sender, EventArgs e)
        {
            int TableNo;
            int.TryParse(this.TableNoTextBox.Text, out TableNo);
            if (TableNo > 15)
            {
                MessageBox.Show("Enter a Table Number value between 1-15 in numeric format");
                TableNoTextBox.Focus();
            }
            if (TableNoTextBox.Text == "0")
            {
                MessageBox.Show("Enter a Table Number value between 1-15 in numeric format");
                TableNoTextBox.Focus();
            }
        }

        //Start Button Function
        private void StartButton_Click(object sender, EventArgs e)
        {
            int TableNo;
            int.TryParse(this.TableNoTextBox.Text, out TableNo);
            string firstname;
            firstname = this.ServerNameTextBox.Text;
          
            //Getting the first name for Form Text
            int spacesep;
            spacesep = firstname.IndexOf(' ');
            string TableNoinstr = Convert.ToString(TableNo);
           
            //Changing the form Text
            if (ServerNameTextBox.Text.Contains(' '))
            {
                firstname = ServerNameTextBox.Text.Remove(spacesep);
                this.Text = firstname + " " + "@ Table Number" + " " + TableNoinstr;
            }
            else
            {
                this.Text = ServerNameTextBox.Text + " " + "@ Table Number" + " " + TableNoinstr;
            }
          
            //Condition statement for empty value of Server name or Table Number
            if (ServerNameTextBox.Text.Trim() == string.Empty | TableNoTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter valid name and table no to continue", "Oops!");
                this.Text = "Welcome to Sult";
            }
           
            //Displaying and hiding required Panels
            else
            {
                StartPanel.Visible = false;
                SultLogo.Visible = true;
                OverallPizzaPanel.Visible = true;
                FunctionPanel.Visible = true;
                OrderButton.Enabled = true;
                SummaryButton.Enabled = true;
                MargheritaPizzatextBox.Focus();
            }

        }
       
        //Declaring Global Variables for Overall Summary
        int totalcompanytranscation;
        int totalcompanypizza;
        float totalcompanyreceipts;
        
        private void OrderButton_Click(object sender, EventArgs e)
        {
           
            //Arithmetic Calculations for Receipt and total pizza
            int pizza1, pizza2, pizza3;
            int.TryParse(this.MargheritaPizzatextBox.Text, out pizza1);
            int.TryParse(this.PepperoniPizzaTextBox.Text, out pizza2);
            int.TryParse(this.HamPineappleTextBox.Text, out pizza3);
            int totalpizzaordered = pizza1 + pizza2 + pizza3;
            totalcompanypizza += totalpizzaordered;
            string totalpizzaorderedstring = totalpizzaordered.ToString();
            float pizza1cost = pizza1 * 9;
            float pizza2cost = (float)(pizza2 * 11.50);
            float pizza3cost = (float)(pizza3 * 12.79);
            float singleordercost = (float)(pizza1cost + pizza2cost + pizza3cost + 2.49);
           
            //Overall Company Receipt using Global Variable
            totalcompanyreceipts += singleordercost;
          
            //Handling Exception if no pizza is ordered
            try
            {
                if (totalpizzaorderedstring != "0")
                {
                    if (MessageBox.Show("Is this your final order?\nNote : Server fee of €2.49 will be added to the total bill", "Order", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        OrderNameServerNameDisplayLabel.Text = this.ServerNameTextBox.Text;
                        OrderTotalNumberOfPizzaLabel.Text = totalpizzaordered.ToString();
                        OrderTotalTableReceiptsLabel.Text = "€"+singleordercost.ToString();
                        OverallPizzaPanel.Enabled = false;
                        OverallOrderPanel.Visible = true;
                        OverallSummaryPanel.Visible = false;
                        //Overall CompanyTranscation using Global Variable
                        totalcompanytranscation += 1;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }   
        //Clear Button to reset to the start Panel
        private void ClearButton_Click(object sender, EventArgs e)
        {
            OverallPizzaPanel.Enabled = true;
            OverallPizzaPanel.Visible = false;
            OverallOrderPanel.Visible = false;
            OverallSummaryPanel.Visible = false;
            FunctionPanel.Visible = false;
            SultLogo.Visible = false;
            OverallSummaryPanel.Visible = false;
            MargheritaPizzatextBox.Text = "0";
            PepperoniPizzaTextBox.Text = "0";
            HamPineappleTextBox.Text = "0";
            StartPanel.Visible = true;
            TableNoTextBox.Text = "";
            ServerNameTextBox.Text = "";
            this.Text = "Welcome to Sult";

        }
        //Summary Button function
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            OrderButton.Enabled = false;
            SummaryButton.Enabled = false;
            OverallOrderPanel.Visible = false;
            OverallSummaryPanel.Visible = true;
            OverallPizzaPanel.Visible = false;
            //Changing the form Text
            this.Text = "Sult Company Summary Data";

            //Displaying the Overall Company values from Global Variables calculated in Order Function
            TotalCompanyTranscationsDisplayLabel.Text = totalcompanytranscation.ToString();
            TotalCompanyPizzaDisplayLabel.Text = totalcompanypizza.ToString();
            TotalCompanyReceiptsDisplayLabel.Text = "€" + totalcompanyreceipts.ToString();
            float avgcompanytranscation = totalcompanyreceipts / totalcompanytranscation;
           
            //Rounding off Avg Transcation to 2 Decimal Places
                Math.Round(avgcompanytranscation, 2);
            AvgTranscationValueDisplayLabel.Text = "€" + avgcompanytranscation.ToString();
        }
        //Exit Button to Close the Application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
