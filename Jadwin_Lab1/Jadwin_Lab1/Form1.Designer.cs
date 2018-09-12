namespace Jadwin_Lab1
{
    partial class Automotive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oilAndLube = new System.Windows.Forms.GroupBox();
            this.lubeJob = new System.Windows.Forms.CheckBox();
            this.oilChange = new System.Windows.Forms.CheckBox();
            this.flushes = new System.Windows.Forms.GroupBox();
            this.transFlush = new System.Windows.Forms.CheckBox();
            this.radFlush = new System.Windows.Forms.CheckBox();
            this.misc = new System.Windows.Forms.GroupBox();
            this.tireRot = new System.Windows.Forms.CheckBox();
            this.rplcMuffler = new System.Windows.Forms.CheckBox();
            this.inspect = new System.Windows.Forms.CheckBox();
            this.partsAndLabor = new System.Windows.Forms.GroupBox();
            this.laborBox = new System.Windows.Forms.TextBox();
            this.laborLbl = new System.Windows.Forms.Label();
            this.partsLbl = new System.Windows.Forms.Label();
            this.partsBox = new System.Windows.Forms.TextBox();
            this.summary = new System.Windows.Forms.GroupBox();
            this.totLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.sumPartsLbl = new System.Windows.Forms.Label();
            this.srvcLaborLbl = new System.Windows.Forms.Label();
            this.totBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.sumPartsBox = new System.Windows.Forms.TextBox();
            this.srvcLaborBox = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.oilAndLube.SuspendLayout();
            this.flushes.SuspendLayout();
            this.misc.SuspendLayout();
            this.partsAndLabor.SuspendLayout();
            this.summary.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilAndLube
            // 
            this.oilAndLube.Controls.Add(this.lubeJob);
            this.oilAndLube.Controls.Add(this.oilChange);
            this.oilAndLube.Location = new System.Drawing.Point(13, 13);
            this.oilAndLube.Name = "oilAndLube";
            this.oilAndLube.Size = new System.Drawing.Size(166, 74);
            this.oilAndLube.TabIndex = 0;
            this.oilAndLube.TabStop = false;
            this.oilAndLube.Text = "Oil and Lube";
            // 
            // lubeJob
            // 
            this.lubeJob.AutoSize = true;
            this.lubeJob.Location = new System.Drawing.Point(7, 44);
            this.lubeJob.Name = "lubeJob";
            this.lubeJob.Size = new System.Drawing.Size(112, 17);
            this.lubeJob.TabIndex = 1;
            this.lubeJob.Text = "Lube Job ($18.00)";
            this.lubeJob.UseVisualStyleBackColor = true;
            // 
            // oilChange
            // 
            this.oilChange.AutoSize = true;
            this.oilChange.Location = new System.Drawing.Point(7, 20);
            this.oilChange.Name = "oilChange";
            this.oilChange.Size = new System.Drawing.Size(120, 17);
            this.oilChange.TabIndex = 0;
            this.oilChange.Text = "Oil Change ($26.00)";
            this.oilChange.UseVisualStyleBackColor = true;
            // 
            // flushes
            // 
            this.flushes.Controls.Add(this.transFlush);
            this.flushes.Controls.Add(this.radFlush);
            this.flushes.Location = new System.Drawing.Point(185, 13);
            this.flushes.Name = "flushes";
            this.flushes.Size = new System.Drawing.Size(175, 74);
            this.flushes.TabIndex = 1;
            this.flushes.TabStop = false;
            this.flushes.Text = "Flushes";
            // 
            // transFlush
            // 
            this.transFlush.AutoSize = true;
            this.transFlush.Location = new System.Drawing.Point(7, 44);
            this.transFlush.Name = "transFlush";
            this.transFlush.Size = new System.Drawing.Size(157, 17);
            this.transFlush.TabIndex = 1;
            this.transFlush.Text = "Transmission Rush ($80.00)";
            this.transFlush.UseVisualStyleBackColor = true;
            // 
            // radFlush
            // 
            this.radFlush.AutoSize = true;
            this.radFlush.Location = new System.Drawing.Point(7, 20);
            this.radFlush.Name = "radFlush";
            this.radFlush.Size = new System.Drawing.Size(136, 17);
            this.radFlush.TabIndex = 0;
            this.radFlush.Text = "Radiator Flush ($30.00)";
            this.radFlush.UseVisualStyleBackColor = true;
            // 
            // misc
            // 
            this.misc.Controls.Add(this.tireRot);
            this.misc.Controls.Add(this.rplcMuffler);
            this.misc.Controls.Add(this.inspect);
            this.misc.Location = new System.Drawing.Point(13, 93);
            this.misc.Name = "misc";
            this.misc.Size = new System.Drawing.Size(166, 98);
            this.misc.TabIndex = 2;
            this.misc.TabStop = false;
            this.misc.Text = "Misc";
            // 
            // tireRot
            // 
            this.tireRot.AutoSize = true;
            this.tireRot.Location = new System.Drawing.Point(7, 68);
            this.tireRot.Name = "tireRot";
            this.tireRot.Size = new System.Drawing.Size(129, 17);
            this.tireRot.TabIndex = 2;
            this.tireRot.Text = "Tire Rotation ($20.00)";
            this.tireRot.UseVisualStyleBackColor = true;
            // 
            // rplcMuffler
            // 
            this.rplcMuffler.AutoSize = true;
            this.rplcMuffler.Location = new System.Drawing.Point(7, 44);
            this.rplcMuffler.Name = "rplcMuffler";
            this.rplcMuffler.Size = new System.Drawing.Size(149, 17);
            this.rplcMuffler.TabIndex = 1;
            this.rplcMuffler.Text = "Replace Muffler ($100.00)";
            this.rplcMuffler.UseVisualStyleBackColor = true;
            // 
            // inspect
            // 
            this.inspect.AutoSize = true;
            this.inspect.Location = new System.Drawing.Point(7, 20);
            this.inspect.Name = "inspect";
            this.inspect.Size = new System.Drawing.Size(117, 17);
            this.inspect.TabIndex = 0;
            this.inspect.Text = "Inspection ($15.00)";
            this.inspect.UseVisualStyleBackColor = true;
            // 
            // partsAndLabor
            // 
            this.partsAndLabor.Controls.Add(this.laborBox);
            this.partsAndLabor.Controls.Add(this.laborLbl);
            this.partsAndLabor.Controls.Add(this.partsLbl);
            this.partsAndLabor.Controls.Add(this.partsBox);
            this.partsAndLabor.Location = new System.Drawing.Point(185, 93);
            this.partsAndLabor.Name = "partsAndLabor";
            this.partsAndLabor.Size = new System.Drawing.Size(175, 98);
            this.partsAndLabor.TabIndex = 3;
            this.partsAndLabor.TabStop = false;
            this.partsAndLabor.Text = "Parts and Labor";
            // 
            // laborBox
            // 
            this.laborBox.Location = new System.Drawing.Point(77, 58);
            this.laborBox.Name = "laborBox";
            this.laborBox.Size = new System.Drawing.Size(56, 20);
            this.laborBox.TabIndex = 3;
            // 
            // laborLbl
            // 
            this.laborLbl.AutoSize = true;
            this.laborLbl.Location = new System.Drawing.Point(22, 61);
            this.laborLbl.Name = "laborLbl";
            this.laborLbl.Size = new System.Drawing.Size(49, 13);
            this.laborLbl.TabIndex = 2;
            this.laborLbl.Text = "Labor ($)";
            // 
            // partsLbl
            // 
            this.partsLbl.AutoSize = true;
            this.partsLbl.Location = new System.Drawing.Point(40, 26);
            this.partsLbl.Name = "partsLbl";
            this.partsLbl.Size = new System.Drawing.Size(31, 13);
            this.partsLbl.TabIndex = 1;
            this.partsLbl.Text = "Parts";
            // 
            // partsBox
            // 
            this.partsBox.Location = new System.Drawing.Point(77, 23);
            this.partsBox.Name = "partsBox";
            this.partsBox.Size = new System.Drawing.Size(56, 20);
            this.partsBox.TabIndex = 0;
            // 
            // summary
            // 
            this.summary.Controls.Add(this.totLbl);
            this.summary.Controls.Add(this.taxLbl);
            this.summary.Controls.Add(this.sumPartsLbl);
            this.summary.Controls.Add(this.srvcLaborLbl);
            this.summary.Controls.Add(this.totBox);
            this.summary.Controls.Add(this.taxBox);
            this.summary.Controls.Add(this.sumPartsBox);
            this.summary.Controls.Add(this.srvcLaborBox);
            this.summary.Location = new System.Drawing.Point(13, 197);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(347, 138);
            this.summary.TabIndex = 4;
            this.summary.TabStop = false;
            this.summary.Text = "Summary";
            // 
            // totLbl
            // 
            this.totLbl.AutoSize = true;
            this.totLbl.Location = new System.Drawing.Point(50, 103);
            this.totLbl.Name = "totLbl";
            this.totLbl.Size = new System.Drawing.Size(57, 13);
            this.totLbl.TabIndex = 7;
            this.totLbl.Text = "Total Fees";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(35, 76);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(72, 13);
            this.taxLbl.TabIndex = 6;
            this.taxLbl.Text = "Tax (on parts)";
            // 
            // sumPartsLbl
            // 
            this.sumPartsLbl.AutoSize = true;
            this.sumPartsLbl.Location = new System.Drawing.Point(76, 49);
            this.sumPartsLbl.Name = "sumPartsLbl";
            this.sumPartsLbl.Size = new System.Drawing.Size(31, 13);
            this.sumPartsLbl.TabIndex = 5;
            this.sumPartsLbl.Text = "Parts";
            // 
            // srvcLaborLbl
            // 
            this.srvcLaborLbl.AutoSize = true;
            this.srvcLaborLbl.Location = new System.Drawing.Point(13, 22);
            this.srvcLaborLbl.Name = "srvcLaborLbl";
            this.srvcLaborLbl.Size = new System.Drawing.Size(94, 13);
            this.srvcLaborLbl.TabIndex = 4;
            this.srvcLaborLbl.Text = "Service and Labor";
            // 
            // totBox
            // 
            this.totBox.Location = new System.Drawing.Point(113, 100);
            this.totBox.Name = "totBox";
            this.totBox.ReadOnly = true;
            this.totBox.Size = new System.Drawing.Size(100, 20);
            this.totBox.TabIndex = 3;
            // 
            // taxBox
            // 
            this.taxBox.Location = new System.Drawing.Point(113, 73);
            this.taxBox.Name = "taxBox";
            this.taxBox.ReadOnly = true;
            this.taxBox.Size = new System.Drawing.Size(100, 20);
            this.taxBox.TabIndex = 2;
            // 
            // sumPartsBox
            // 
            this.sumPartsBox.Location = new System.Drawing.Point(113, 46);
            this.sumPartsBox.Name = "sumPartsBox";
            this.sumPartsBox.ReadOnly = true;
            this.sumPartsBox.Size = new System.Drawing.Size(100, 20);
            this.sumPartsBox.TabIndex = 1;
            // 
            // srvcLaborBox
            // 
            this.srvcLaborBox.Location = new System.Drawing.Point(113, 19);
            this.srvcLaborBox.Name = "srvcLaborBox";
            this.srvcLaborBox.ReadOnly = true;
            this.srvcLaborBox.Size = new System.Drawing.Size(100, 20);
            this.srvcLaborBox.TabIndex = 0;
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(66, 350);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 5;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(147, 350);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(75, 23);
            this.clr.TabIndex = 6;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(228, 350);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Automotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 385);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.partsAndLabor);
            this.Controls.Add(this.misc);
            this.Controls.Add(this.flushes);
            this.Controls.Add(this.oilAndLube);
            this.Name = "Automotive";
            this.Text = "Automotive";
            this.oilAndLube.ResumeLayout(false);
            this.oilAndLube.PerformLayout();
            this.flushes.ResumeLayout(false);
            this.flushes.PerformLayout();
            this.misc.ResumeLayout(false);
            this.misc.PerformLayout();
            this.partsAndLabor.ResumeLayout(false);
            this.partsAndLabor.PerformLayout();
            this.summary.ResumeLayout(false);
            this.summary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilAndLube;
        private System.Windows.Forms.CheckBox lubeJob;
        private System.Windows.Forms.CheckBox oilChange;
        private System.Windows.Forms.GroupBox flushes;
        private System.Windows.Forms.CheckBox transFlush;
        private System.Windows.Forms.CheckBox radFlush;
        private System.Windows.Forms.GroupBox misc;
        private System.Windows.Forms.CheckBox tireRot;
        private System.Windows.Forms.CheckBox rplcMuffler;
        private System.Windows.Forms.CheckBox inspect;
        private System.Windows.Forms.GroupBox partsAndLabor;
        private System.Windows.Forms.TextBox laborBox;
        private System.Windows.Forms.Label laborLbl;
        private System.Windows.Forms.Label partsLbl;
        private System.Windows.Forms.TextBox partsBox;
        private System.Windows.Forms.GroupBox summary;
        private System.Windows.Forms.Label totLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label sumPartsLbl;
        private System.Windows.Forms.Label srvcLaborLbl;
        private System.Windows.Forms.TextBox totBox;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.TextBox sumPartsBox;
        private System.Windows.Forms.TextBox srvcLaborBox;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Button exit;
    }
}

