namespace ConfigureMyAuto2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.car1 = new System.Windows.Forms.RadioButton();
            this.car2 = new System.Windows.Forms.RadioButton();
            this.car3 = new System.Windows.Forms.RadioButton();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.abs = new System.Windows.Forms.CheckBox();
            this.fLights = new System.Windows.Forms.CheckBox();
            this.Chains = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CCard = new System.Windows.Forms.RadioButton();
            this.Check = new System.Windows.Forms.RadioButton();
            this.Cash = new System.Windows.Forms.RadioButton();
            this.calcDiss = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a Car";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Lime;
            this.price.Location = new System.Drawing.Point(560, 351);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(66, 25);
            this.price.TabIndex = 1;
            this.price.Text = "0,00€";
            // 
            // car1
            // 
            this.car1.AutoSize = true;
            this.car1.Location = new System.Drawing.Point(33, 30);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(88, 17);
            this.car1.TabIndex = 2;
            this.car1.TabStop = true;
            this.car1.Text = "Renault Kwid";
            this.car1.UseVisualStyleBackColor = true;
            this.car1.CheckedChanged += new System.EventHandler(this.car1_CheckedChanged);
            // 
            // car2
            // 
            this.car2.AutoSize = true;
            this.car2.Location = new System.Drawing.Point(33, 53);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(93, 17);
            this.car2.TabIndex = 3;
            this.car2.TabStop = true;
            this.car2.Text = "Toyota Corolla";
            this.car2.UseVisualStyleBackColor = true;
            this.car2.CheckedChanged += new System.EventHandler(this.car2_CheckedChanged);
            // 
            // car3
            // 
            this.car3.AutoSize = true;
            this.car3.Location = new System.Drawing.Point(33, 76);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(73, 17);
            this.car3.TabIndex = 4;
            this.car3.TabStop = true;
            this.car3.Text = "Seat Swift";
            this.car3.UseVisualStyleBackColor = true;
            this.car3.CheckedChanged += new System.EventHandler(this.car3_CheckedChanged);
            // 
            // picBox
            // 
            this.picBox.InitialImage = global::ConfigureMyAuto2.Properties.Resources.Tcorolla;
            this.picBox.Location = new System.Drawing.Point(160, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(486, 295);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 5;
            this.picBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Chains);
            this.groupBox1.Controls.Add(this.fLights);
            this.groupBox1.Controls.Add(this.abs);
            this.groupBox1.Location = new System.Drawing.Point(33, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 97);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optional Add-ons";
            // 
            // abs
            // 
            this.abs.AutoSize = true;
            this.abs.Location = new System.Drawing.Point(6, 19);
            this.abs.Name = "abs";
            this.abs.Size = new System.Drawing.Size(47, 17);
            this.abs.TabIndex = 0;
            this.abs.Text = "ABS";
            this.abs.UseVisualStyleBackColor = true;
            this.abs.CheckedChanged += new System.EventHandler(this.abs_CheckedChanged);
            // 
            // fLights
            // 
            this.fLights.AutoSize = true;
            this.fLights.Location = new System.Drawing.Point(6, 42);
            this.fLights.Name = "fLights";
            this.fLights.Size = new System.Drawing.Size(75, 17);
            this.fLights.TabIndex = 1;
            this.fLights.Text = "Fog Lights";
            this.fLights.UseVisualStyleBackColor = true;
            this.fLights.CheckedChanged += new System.EventHandler(this.fLights_CheckedChanged);
            // 
            // Chains
            // 
            this.Chains.AutoSize = true;
            this.Chains.Location = new System.Drawing.Point(6, 65);
            this.Chains.Name = "Chains";
            this.Chains.Size = new System.Drawing.Size(58, 17);
            this.Chains.TabIndex = 2;
            this.Chains.Text = "Chains";
            this.Chains.UseVisualStyleBackColor = true;
            this.Chains.CheckedChanged += new System.EventHandler(this.Chains_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cash);
            this.groupBox2.Controls.Add(this.Check);
            this.groupBox2.Controls.Add(this.CCard);
            this.groupBox2.Location = new System.Drawing.Point(33, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 89);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Method";
            // 
            // CCard
            // 
            this.CCard.AutoSize = true;
            this.CCard.Location = new System.Drawing.Point(6, 16);
            this.CCard.Name = "CCard";
            this.CCard.Size = new System.Drawing.Size(77, 17);
            this.CCard.TabIndex = 0;
            this.CCard.TabStop = true;
            this.CCard.Text = "Credit Card";
            this.CCard.UseVisualStyleBackColor = true;
            // 
            // Check
            // 
            this.Check.AutoSize = true;
            this.Check.Location = new System.Drawing.Point(6, 39);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(56, 17);
            this.Check.TabIndex = 1;
            this.Check.TabStop = true;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.Location = new System.Drawing.Point(6, 62);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(49, 17);
            this.Cash.TabIndex = 2;
            this.Cash.TabStop = true;
            this.Cash.Text = "Cash";
            this.Cash.UseVisualStyleBackColor = true;
            // 
            // calcDiss
            // 
            this.calcDiss.Location = new System.Drawing.Point(479, 322);
            this.calcDiss.Name = "calcDiss";
            this.calcDiss.Size = new System.Drawing.Size(75, 23);
            this.calcDiss.TabIndex = 8;
            this.calcDiss.Text = "Discount";
            this.calcDiss.UseVisualStyleBackColor = true;
            this.calcDiss.Click += new System.EventHandler(this.calcDiss_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(479, 351);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 9;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 385);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.calcDiss);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.car3);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ConfigureMyAuto";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.RadioButton car1;
        private System.Windows.Forms.RadioButton car2;
        private System.Windows.Forms.RadioButton car3;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Chains;
        private System.Windows.Forms.CheckBox fLights;
        private System.Windows.Forms.CheckBox abs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Cash;
        private System.Windows.Forms.RadioButton Check;
        private System.Windows.Forms.RadioButton CCard;
        private System.Windows.Forms.Button calcDiss;
        private System.Windows.Forms.Button reset;
    }
}

