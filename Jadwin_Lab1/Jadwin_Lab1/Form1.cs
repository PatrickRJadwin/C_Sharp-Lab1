
/* * * * * * * * * * * * *
 * Name: Patrick Jadwin  *
 * Date: 10-09-2018      *
 * Class: CITC 2375      *
 * * * * * * * * * * * * */

using System;
using System.Collections;
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
            List<decimal> charges = new List<decimal>() { oilChange, lubeJob };
            List<bool> bools = new List<bool>() { oilChkd, lubeChkd };

            oilLubeCharge = ifChkd(oilLubeCharge, charges, bools);

            return oilLubeCharge;
        }

        // Determine total cost of flush charges by checking if boolean is true
        private decimal flush_Charges(bool radChkd, bool transChkd)
        {
            decimal flushCharge = 0;
            const decimal radFlush = 30.00m;
            const decimal transFlush = 80.00m;
            List<decimal> charges = new List<decimal>() { radFlush, transFlush };
            List<bool> bools = new List<bool>() { radChkd, transChkd };

            flushCharge = ifChkd(flushCharge, charges, bools);

            return flushCharge;
        }

        // Determine total cost of Misc charges
        private decimal misc_Charges(bool inspChkd, bool muffChkd, bool tireChkd)
        {
            decimal miscCharge = 0;
            const decimal inspection = 15.00m;
            const decimal rplcMuff = 100.00m;
            const decimal tireRot = 20.00m;
            List<decimal> charges = new List<decimal>() { inspection, rplcMuff, tireRot};
            List<bool> bools = new List<bool>() { inspChkd, muffChkd, tireChkd };

            miscCharge = ifChkd(miscCharge, charges, bools);

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

        // Determines charges based on if checkboxes are checked
        private decimal ifChkd(decimal totCharge, List<decimal> charges, List<bool> bools)
        {
            // loop cycles through boolean w/ checked or not checked
            for (int i = 0; i < bools.Count; i++)
            {
                // adds to total charge if checked
                if (bools[i] == true)
                {
                    totCharge = totCharge + charges[i];
                }
                else
                {
                    continue;
                }
            }
            return totCharge;
        }

        // Checks part and labor boxes for valid input
        private List<decimal> err_Handl()
        {
            // Booleans to determine if text field is number
            List<bool> isNum = new List<bool> { true, true };

            // Get text from text fields
            List<string> str = new List<string>() { partsBox.Text.Trim(), laborBox.Text.Trim()};

            // parts and labor default values
            decimal parts = 0;
            decimal labor = 0;

            // Check if box is empty, if not, parse for number, if string set to false
            if (partsBox.Text != "")
            {
                isNum[0] = decimal.TryParse(str[0], out parts);
            }

            if (laborBox.Text != "")
            {
                isNum[1] = decimal.TryParse(str[1], out labor);
            }

            List<decimal> prtsLabor = new List<decimal>() { parts, labor };

            // if either is not a valid digit, print error
            if (isNum[0] == false || isNum[1] == false)
            {
                MessageBox.Show("Not a valid number!!!!!!");
            }

            return prtsLabor;
        }

        // Method to handle calculate button event
        private void calc_Click(object sender, EventArgs e)
        {
            List<decimal> errHandlr = err_Handl();
            decimal parts = errHandlr[0];
            decimal labor = errHandlr[1];

            // boolean if checkbox is checked
            List<bool> chkd = new List<bool>() { oilChange.Checked, lubeJob.Checked, radFlush.Checked,
                transFlush.Checked, inspect.Checked, rplcMuffler.Checked, tireRot.Checked};

            // Link values to methods and store in decimal var
            decimal oilLube = oil_Lube_Charges(chkd[0], chkd[1]);
            decimal flush = flush_Charges(chkd[2], chkd[3]);
            decimal misc = misc_Charges(chkd[4], chkd[5], chkd[6]);
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
