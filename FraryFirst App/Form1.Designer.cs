namespace FraryFirst_App
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumDice = new System.Windows.Forms.TextBox();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo20Sided = new System.Windows.Forms.RadioButton();
            this.rdo10Sided = new System.Windows.Forms.RadioButton();
            this.rdo6Sided = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(309, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Test Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Dice";
            // 
            // txtNumDice
            // 
            this.txtNumDice.Location = new System.Drawing.Point(333, 154);
            this.txtNumDice.Name = "txtNumDice";
            this.txtNumDice.Size = new System.Drawing.Size(100, 20);
            this.txtNumDice.TabIndex = 2;
            // 
            // lstOut
            // 
            this.lstOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 20;
            this.lstOut.Location = new System.Drawing.Point(44, 202);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(604, 164);
            this.lstOut.TabIndex = 5;
            this.lstOut.TabStop = false;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(73, 397);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(293, 397);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(586, 397);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo20Sided);
            this.groupBox1.Controls.Add(this.rdo10Sided);
            this.groupBox1.Controls.Add(this.rdo6Sided);
            this.groupBox1.Location = new System.Drawing.Point(53, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 57);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dice Type";
            // 
            // rdo20Sided
            // 
            this.rdo20Sided.AutoSize = true;
            this.rdo20Sided.Location = new System.Drawing.Point(433, 19);
            this.rdo20Sided.Name = "rdo20Sided";
            this.rdo20Sided.Size = new System.Drawing.Size(67, 17);
            this.rdo20Sided.TabIndex = 2;
            this.rdo20Sided.Text = "20 Sided";
            this.rdo20Sided.UseVisualStyleBackColor = true;
            this.rdo20Sided.CheckedChanged += new System.EventHandler(this.rdo20Sided_CheckedChanged);
            // 
            // rdo10Sided
            // 
            this.rdo10Sided.AutoSize = true;
            this.rdo10Sided.Location = new System.Drawing.Point(214, 19);
            this.rdo10Sided.Name = "rdo10Sided";
            this.rdo10Sided.Size = new System.Drawing.Size(67, 17);
            this.rdo10Sided.TabIndex = 1;
            this.rdo10Sided.Text = "10 Sided";
            this.rdo10Sided.UseVisualStyleBackColor = true;
            this.rdo10Sided.CheckedChanged += new System.EventHandler(this.rdo10Sidded_CheckedChanged);
            // 
            // rdo6Sided
            // 
            this.rdo6Sided.AutoSize = true;
            this.rdo6Sided.Location = new System.Drawing.Point(30, 19);
            this.rdo6Sided.Name = "rdo6Sided";
            this.rdo6Sided.Size = new System.Drawing.Size(61, 17);
            this.rdo6Sided.TabIndex = 0;
            this.rdo6Sided.Text = "6 Sided";
            this.rdo6Sided.UseVisualStyleBackColor = true;
            this.rdo6Sided.CheckedChanged += new System.EventHandler(this.rdo6Sided_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.txtNumDice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Test App by Barbara Frary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumDice;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo20Sided;
        private System.Windows.Forms.RadioButton rdo10Sided;
        private System.Windows.Forms.RadioButton rdo6Sided;
    }
}

