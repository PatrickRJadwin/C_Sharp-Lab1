
/* * * * * * * * * * * * *
 * Name: Patrick Jadwin  *
 * Date: 10-09-2018      *
 * Class: CITC 2375      *
 * * * * * * * * * * * * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jadwin_Lab1
{
    public partial class Automotive : Form
    {
        public Automotive()
        {
            InitializeComponent();
        }

        // Determine total cost of oil/lube by checking if boolean is true
        private decimal oil_Lube_Charges(bool oilChkd, bool lubeChkd)
        {
            decimal oilLubeCharge = 0;
            const decimal oilChange = 26.00m;
            const decimal lubeJob = 18.00m;

            // If oil is checked
            if (oilChkd == true)
            {
                oilLubeCharge = oilLubeCharge + oilChange;
            }

            // If lube is checked
            if (lubeChkd == true)
            {
                oilLubeCharge = oilLubeCharge + lubeJob;
            }

            return oilLubeCharge;
        }

        // Determine total cost of flush charges by checking if boolean is true
        private decimal flush_Charges(bool radChkd, bool transChkd)
        {
            decimal flushCharge = 0;
            const decimal radFlush = 30.00m;
            const decimal transFlush = 80.00m;

            // If radiator is checked
            if (radChkd == true)
            {
                flushCharge = flushCharge + radFlush;
            }

            // If transmission is checked
            if (transChkd == true)
            {
                flushCharge = flushCharge + transFlush;
            }

            return flushCharge;
        }

        // Determine total cost of Misc charges
        private decimal misc_Charges(bool inspChkd, bool muffChkd, bool tireChkd)
        {
            decimal miscCharge = 0;
            const decimal inspection = 15.00m;
            const decimal rplcMuff = 100.00m;
            const decimal tireRot = 20.00m;

            // If inspection is checked
            if (inspChkd == true)
            {
                miscCharge = miscCharge + inspection;
            }

            // If muffler replacement is checked
            if (muffChkd == true)
            {
                miscCharge = miscCharge + rplcMuff;
            }

            // If tire rotation is checked
            if (tireChkd == true)
            {
                miscCharge = miscCharge + tireRot;
            }

            return miscCharge;
        }

        // Add parts and labor boxes to get total other cost
        private decimal other_Charges(decimal parts, decimal labor)
        {
            decimal other = parts + labor;
            return other;
        }

        // Determine tax on parts
        private decimal tax_Charges(decimal parts)
        {
            decimal tax = 0.06m * parts;
            return tax;
        }

        // Determine total cost
        private decimal total_Charges(decimal oilLube, decimal flush, decimal misc, decimal other, decimal tax)
        {
            decimal total = oilLube + flush + misc + other + tax;
            return total;
        }

        // Method to handle calculate button event
        private void calc_Click(object sender, EventArgs e)
        {
            // Booleans to determine if text field is number
            bool prtsIsNum = true;
            bool lbrIsNum = true;

            // Get text from text fields
            string str = partsBox.Text.Trim();
            string str2 = laborBox.Text.Trim();

            // parts and labor default values
            decimal parts = 0;
            decimal labor = 0;
            
            // Check if box is empty, if not, parse for number, if string set to false
            if (partsBox.Text != "")
            {
                prtsIsNum = decimal.TryParse(str, out parts);
            }

            if (laborBox.Text != "")
            {
                lbrIsNum = decimal.TryParse(str2, out labor);
            }

            // if either is not a valid digit, print error
            if (prtsIsNum == false || lbrIsNum == false)
            {
                MessageBox.Show("Not a valid number!!!!!!");
            }
            
            else
            {
                // boolean if checkbox is checked
                bool oilChkd = oilChange.Checked;
                bool lubeChkd = lubeJob.Checked;
                bool radChkd = radFlush.Checked;
                bool transChkd = transFlush.Checked;
                bool inspChkd = inspect.Checked;
                bool muffChkd = rplcMuffler.Checked;
                bool tireChkd = tireRot.Checked;

                // Link values to methods and store in decimal var
                decimal oilLube = oil_Lube_Charges(oilChkd, lubeChkd);
                decimal flush = flush_Charges(radChkd, transChkd);
                decimal misc = misc_Charges(inspChkd, muffChkd, tireChkd);
                decimal other = other_Charges(parts, labor);
                decimal tax = tax_Charges(parts);

                // Calculate total
                decimal total = total_Charges(oilLube, flush, misc, other, tax);

                // Set summary text boxes
                srvcLaborBox.Text = labor.ToString("c2");
                sumPartsBox.Text = parts.ToString("c2");
                taxBox.Text = tax.ToString("c2");
                totBox.Text = total.ToString("c2");
            }

        }

        // Clear checkbox methods, set checkboxes to false (clear)
        private void clear_Oil_Lube()
        {
            oilChange.Checked = false;
            lubeJob.Checked = false;
        }

        private void clear_Flushes()
        {
            radFlush.Checked = false;
            transFlush.Checked = false;
        }

        private void clear_Misc()
        {
            inspect.Checked = false;
            rplcMuffler.Checked = false;
            tireRot.Checked = false;
        }

        // Clear text boxes by setting to empty
        private void clear_Other()
        {
            partsBox.Text = "";
            laborBox.Text = "";
        }

        private void clear_Fees()
        {
            srvcLaborBox.Text = "";
            sumPartsBox.Text = "";
            taxBox.Text = "";
            totBox.Text = "";
        }

        // run void methods to clear application
        private void clr_Click(object sender, EventArgs e)
        {
            clear_Oil_Lube();
            clear_Flushes();
            clear_Misc();
            clear_Other();
            clear_Fees();
        }

        // exit
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
