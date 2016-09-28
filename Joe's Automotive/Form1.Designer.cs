namespace Joe_s_Automotive
{
    partial class Form1
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
            this.grbxOil = new System.Windows.Forms.GroupBox();
            this.chbxoil = new System.Windows.Forms.CheckBox();
            this.chbxlub = new System.Windows.Forms.CheckBox();
            this.grbxFlush = new System.Windows.Forms.GroupBox();
            this.chbxRFlush = new System.Windows.Forms.CheckBox();
            this.chbxTFlush = new System.Windows.Forms.CheckBox();
            this.grbxMisc = new System.Windows.Forms.GroupBox();
            this.chbxIns = new System.Windows.Forms.CheckBox();
            this.chbxReplace = new System.Windows.Forms.CheckBox();
            this.chbxTire = new System.Windows.Forms.CheckBox();
            this.grbxParts = new System.Windows.Forms.GroupBox();
            this.lblParts = new System.Windows.Forms.Label();
            this.lblLabor = new System.Windows.Forms.Label();
            this.tbxparts = new System.Windows.Forms.TextBox();
            this.tbxLabor = new System.Windows.Forms.TextBox();
            this.grbxSum = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.grbxOil.SuspendLayout();
            this.grbxFlush.SuspendLayout();
            this.grbxMisc.SuspendLayout();
            this.grbxParts.SuspendLayout();
            this.grbxSum.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxOil
            // 
            this.grbxOil.Controls.Add(this.chbxlub);
            this.grbxOil.Controls.Add(this.chbxoil);
            this.grbxOil.Location = new System.Drawing.Point(12, 12);
            this.grbxOil.Name = "grbxOil";
            this.grbxOil.Size = new System.Drawing.Size(160, 71);
            this.grbxOil.TabIndex = 0;
            this.grbxOil.TabStop = false;
            this.grbxOil.Text = "Oil and Lube";
            // 
            // chbxoil
            // 
            this.chbxoil.AutoSize = true;
            this.chbxoil.Location = new System.Drawing.Point(7, 20);
            this.chbxoil.Name = "chbxoil";
            this.chbxoil.Size = new System.Drawing.Size(120, 17);
            this.chbxoil.TabIndex = 0;
            this.chbxoil.Text = "Oil Change ($26.00)";
            this.chbxoil.UseVisualStyleBackColor = true;
            // 
            // chbxlub
            // 
            this.chbxlub.AutoSize = true;
            this.chbxlub.Location = new System.Drawing.Point(7, 44);
            this.chbxlub.Name = "chbxlub";
            this.chbxlub.Size = new System.Drawing.Size(103, 17);
            this.chbxlub.TabIndex = 1;
            this.chbxlub.Text = "Lub job ($18.00)";
            this.chbxlub.UseVisualStyleBackColor = true;
            // 
            // grbxFlush
            // 
            this.grbxFlush.Controls.Add(this.chbxTFlush);
            this.grbxFlush.Controls.Add(this.chbxRFlush);
            this.grbxFlush.Location = new System.Drawing.Point(178, 12);
            this.grbxFlush.Name = "grbxFlush";
            this.grbxFlush.Size = new System.Drawing.Size(172, 71);
            this.grbxFlush.TabIndex = 1;
            this.grbxFlush.TabStop = false;
            this.grbxFlush.Text = "Flushes";
            // 
            // chbxRFlush
            // 
            this.chbxRFlush.AutoSize = true;
            this.chbxRFlush.Location = new System.Drawing.Point(7, 20);
            this.chbxRFlush.Name = "chbxRFlush";
            this.chbxRFlush.Size = new System.Drawing.Size(136, 17);
            this.chbxRFlush.TabIndex = 0;
            this.chbxRFlush.Text = "Radiator Flush ($30.00)";
            this.chbxRFlush.UseVisualStyleBackColor = true;
            // 
            // chbxTFlush
            // 
            this.chbxTFlush.AutoSize = true;
            this.chbxTFlush.Location = new System.Drawing.Point(7, 44);
            this.chbxTFlush.Name = "chbxTFlush";
            this.chbxTFlush.Size = new System.Drawing.Size(157, 17);
            this.chbxTFlush.TabIndex = 1;
            this.chbxTFlush.Text = "Transmission Flush ($80.00)";
            this.chbxTFlush.UseVisualStyleBackColor = true;
            // 
            // grbxMisc
            // 
            this.grbxMisc.Controls.Add(this.chbxTire);
            this.grbxMisc.Controls.Add(this.chbxReplace);
            this.grbxMisc.Controls.Add(this.chbxIns);
            this.grbxMisc.Location = new System.Drawing.Point(12, 90);
            this.grbxMisc.Name = "grbxMisc";
            this.grbxMisc.Size = new System.Drawing.Size(160, 100);
            this.grbxMisc.TabIndex = 2;
            this.grbxMisc.TabStop = false;
            this.grbxMisc.Text = "Misc";
            // 
            // chbxIns
            // 
            this.chbxIns.AutoSize = true;
            this.chbxIns.Location = new System.Drawing.Point(7, 20);
            this.chbxIns.Name = "chbxIns";
            this.chbxIns.Size = new System.Drawing.Size(117, 17);
            this.chbxIns.TabIndex = 0;
            this.chbxIns.Text = "Inspection ($15.00)";
            this.chbxIns.UseVisualStyleBackColor = true;
            // 
            // chbxReplace
            // 
            this.chbxReplace.AutoSize = true;
            this.chbxReplace.Location = new System.Drawing.Point(7, 44);
            this.chbxReplace.Name = "chbxReplace";
            this.chbxReplace.Size = new System.Drawing.Size(149, 17);
            this.chbxReplace.TabIndex = 1;
            this.chbxReplace.Text = "Repalce Muffler ($100.00)";
            this.chbxReplace.UseVisualStyleBackColor = true;
            // 
            // chbxTire
            // 
            this.chbxTire.AutoSize = true;
            this.chbxTire.Location = new System.Drawing.Point(7, 68);
            this.chbxTire.Name = "chbxTire";
            this.chbxTire.Size = new System.Drawing.Size(129, 17);
            this.chbxTire.TabIndex = 2;
            this.chbxTire.Text = "Tire Rotation ($20.00)";
            this.chbxTire.UseVisualStyleBackColor = true;
            // 
            // grbxParts
            // 
            this.grbxParts.Controls.Add(this.tbxLabor);
            this.grbxParts.Controls.Add(this.tbxparts);
            this.grbxParts.Controls.Add(this.lblLabor);
            this.grbxParts.Controls.Add(this.lblParts);
            this.grbxParts.Location = new System.Drawing.Point(179, 90);
            this.grbxParts.Name = "grbxParts";
            this.grbxParts.Size = new System.Drawing.Size(171, 100);
            this.grbxParts.TabIndex = 3;
            this.grbxParts.TabStop = false;
            this.grbxParts.Text = "Parts and Labor";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(34, 23);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(31, 13);
            this.lblParts.TabIndex = 0;
            this.lblParts.Text = "Parts";
            // 
            // lblLabor
            // 
            this.lblLabor.AutoSize = true;
            this.lblLabor.Location = new System.Drawing.Point(16, 55);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(49, 13);
            this.lblLabor.TabIndex = 1;
            this.lblLabor.Text = "Labor ($)";
            // 
            // tbxparts
            // 
            this.tbxparts.Location = new System.Drawing.Point(71, 20);
            this.tbxparts.Name = "tbxparts";
            this.tbxparts.Size = new System.Drawing.Size(57, 20);
            this.tbxparts.TabIndex = 2;
            // 
            // tbxLabor
            // 
            this.tbxLabor.Location = new System.Drawing.Point(71, 52);
            this.tbxLabor.Name = "tbxLabor";
            this.tbxLabor.Size = new System.Drawing.Size(57, 20);
            this.tbxLabor.TabIndex = 3;
            // 
            // grbxSum
            // 
            this.grbxSum.Controls.Add(this.textBox4);
            this.grbxSum.Controls.Add(this.textBox3);
            this.grbxSum.Controls.Add(this.textBox2);
            this.grbxSum.Controls.Add(this.textBox1);
            this.grbxSum.Controls.Add(this.label4);
            this.grbxSum.Controls.Add(this.label3);
            this.grbxSum.Controls.Add(this.label2);
            this.grbxSum.Controls.Add(this.label1);
            this.grbxSum.Location = new System.Drawing.Point(12, 197);
            this.grbxSum.Name = "grbxSum";
            this.grbxSum.Size = new System.Drawing.Size(338, 136);
            this.grbxSum.TabIndex = 4;
            this.grbxSum.TabStop = false;
            this.grbxSum.Text = "Summary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service and Labor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tax (on parts)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Fees";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(107, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(107, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(107, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(91, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(107, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(91, 20);
            this.textBox4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 345);
            this.Controls.Add(this.grbxSum);
            this.Controls.Add(this.grbxParts);
            this.Controls.Add(this.grbxMisc);
            this.Controls.Add(this.grbxFlush);
            this.Controls.Add(this.grbxOil);
            this.Name = "Form1";
            this.Text = "Automotive";
            this.grbxOil.ResumeLayout(false);
            this.grbxOil.PerformLayout();
            this.grbxFlush.ResumeLayout(false);
            this.grbxFlush.PerformLayout();
            this.grbxMisc.ResumeLayout(false);
            this.grbxMisc.PerformLayout();
            this.grbxParts.ResumeLayout(false);
            this.grbxParts.PerformLayout();
            this.grbxSum.ResumeLayout(false);
            this.grbxSum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxOil;
        private System.Windows.Forms.CheckBox chbxlub;
        private System.Windows.Forms.CheckBox chbxoil;
        private System.Windows.Forms.GroupBox grbxFlush;
        private System.Windows.Forms.CheckBox chbxTFlush;
        private System.Windows.Forms.CheckBox chbxRFlush;
        private System.Windows.Forms.GroupBox grbxMisc;
        private System.Windows.Forms.CheckBox chbxTire;
        private System.Windows.Forms.CheckBox chbxReplace;
        private System.Windows.Forms.CheckBox chbxIns;
        private System.Windows.Forms.GroupBox grbxParts;
        private System.Windows.Forms.TextBox tbxparts;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox tbxLabor;
        private System.Windows.Forms.GroupBox grbxSum;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

