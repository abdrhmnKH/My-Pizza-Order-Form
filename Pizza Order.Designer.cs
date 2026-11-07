namespace WindowsFormsApp2
{
    partial class Pizza_Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.RdSmallSize = new System.Windows.Forms.RadioButton();
            this.RdMediumSize = new System.Windows.Forms.RadioButton();
            this.RdLargeSize = new System.Windows.Forms.RadioButton();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.chkBoxExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.chkBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.chkBoxOnion = new System.Windows.Forms.CheckBox();
            this.chkBoxOlives = new System.Windows.Forms.CheckBox();
            this.chkBoxGreenPeppers = new System.Windows.Forms.CheckBox();
            this.GrpBox2 = new System.Windows.Forms.GroupBox();
            this.GrpBox3 = new System.Windows.Forms.GroupBox();
            this.RdThickCrust = new System.Windows.Forms.RadioButton();
            this.RdThinCrust = new System.Windows.Forms.RadioButton();
            this.GrpBox4 = new System.Windows.Forms.GroupBox();
            this.RdTakeOut = new System.Windows.Forms.RadioButton();
            this.RdEatIn = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ToppingSelect = new System.Windows.Forms.Label();
            this.SizeRadioLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBox1.SuspendLayout();
            this.GrpBox2.SuspendLayout();
            this.GrpBox3.SuspendLayout();
            this.GrpBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseWaitCursor = true;
            // 
            // RdSmallSize
            // 
            this.RdSmallSize.AutoSize = true;
            this.RdSmallSize.Location = new System.Drawing.Point(15, 24);
            this.RdSmallSize.Name = "RdSmallSize";
            this.RdSmallSize.Size = new System.Drawing.Size(66, 23);
            this.RdSmallSize.TabIndex = 1;
            this.RdSmallSize.TabStop = true;
            this.RdSmallSize.Tag = "10";
            this.RdSmallSize.Text = "Small";
            this.RdSmallSize.UseVisualStyleBackColor = true;
            this.RdSmallSize.CheckedChanged += new System.EventHandler(this.RdBtn1_CheckedChanged);
            // 
            // RdMediumSize
            // 
            this.RdMediumSize.AutoSize = true;
            this.RdMediumSize.Location = new System.Drawing.Point(15, 63);
            this.RdMediumSize.Name = "RdMediumSize";
            this.RdMediumSize.Size = new System.Drawing.Size(83, 23);
            this.RdMediumSize.TabIndex = 2;
            this.RdMediumSize.TabStop = true;
            this.RdMediumSize.Tag = "20";
            this.RdMediumSize.Text = "Medium";
            this.RdMediumSize.UseVisualStyleBackColor = true;
            this.RdMediumSize.CheckedChanged += new System.EventHandler(this.RdBtn2_CheckedChanged);
            // 
            // RdLargeSize
            // 
            this.RdLargeSize.AutoSize = true;
            this.RdLargeSize.Location = new System.Drawing.Point(15, 102);
            this.RdLargeSize.Name = "RdLargeSize";
            this.RdLargeSize.Size = new System.Drawing.Size(66, 23);
            this.RdLargeSize.TabIndex = 3;
            this.RdLargeSize.TabStop = true;
            this.RdLargeSize.Tag = "30";
            this.RdLargeSize.Text = "Large";
            this.RdLargeSize.UseVisualStyleBackColor = true;
            this.RdLargeSize.CheckedChanged += new System.EventHandler(this.RdBtn3_CheckedChanged);
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.RdLargeSize);
            this.grpBox1.Controls.Add(this.RdMediumSize);
            this.grpBox1.Controls.Add(this.RdSmallSize);
            this.grpBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox1.Location = new System.Drawing.Point(12, 72);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(110, 131);
            this.grpBox1.TabIndex = 4;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Size";
            // 
            // chkBoxExtraCheese
            // 
            this.chkBoxExtraCheese.AutoSize = true;
            this.chkBoxExtraCheese.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxExtraCheese.Location = new System.Drawing.Point(15, 30);
            this.chkBoxExtraCheese.Name = "chkBoxExtraCheese";
            this.chkBoxExtraCheese.Size = new System.Drawing.Size(119, 23);
            this.chkBoxExtraCheese.TabIndex = 5;
            this.chkBoxExtraCheese.Tag = "10";
            this.chkBoxExtraCheese.Text = "Extra Cheese";
            this.chkBoxExtraCheese.UseVisualStyleBackColor = true;
            this.chkBoxExtraCheese.CheckedChanged += new System.EventHandler(this.chkBoxExtraCheese_CheckedChanged);
            // 
            // chkBoxMushrooms
            // 
            this.chkBoxMushrooms.AutoSize = true;
            this.chkBoxMushrooms.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxMushrooms.Location = new System.Drawing.Point(15, 55);
            this.chkBoxMushrooms.Name = "chkBoxMushrooms";
            this.chkBoxMushrooms.Size = new System.Drawing.Size(110, 23);
            this.chkBoxMushrooms.TabIndex = 6;
            this.chkBoxMushrooms.Tag = "10";
            this.chkBoxMushrooms.Text = "Mushrooms";
            this.chkBoxMushrooms.UseVisualStyleBackColor = true;
            this.chkBoxMushrooms.CheckedChanged += new System.EventHandler(this.chkBoxMushrooms_CheckedChanged);
            // 
            // chkBoxTomatoes
            // 
            this.chkBoxTomatoes.AutoSize = true;
            this.chkBoxTomatoes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxTomatoes.Location = new System.Drawing.Point(15, 80);
            this.chkBoxTomatoes.Name = "chkBoxTomatoes";
            this.chkBoxTomatoes.Size = new System.Drawing.Size(98, 23);
            this.chkBoxTomatoes.TabIndex = 7;
            this.chkBoxTomatoes.Tag = "5";
            this.chkBoxTomatoes.Text = "Tomatoes";
            this.chkBoxTomatoes.UseVisualStyleBackColor = true;
            this.chkBoxTomatoes.CheckedChanged += new System.EventHandler(this.chkBoxTomatoes_CheckedChanged);
            // 
            // chkBoxOnion
            // 
            this.chkBoxOnion.AutoSize = true;
            this.chkBoxOnion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxOnion.Location = new System.Drawing.Point(155, 30);
            this.chkBoxOnion.Name = "chkBoxOnion";
            this.chkBoxOnion.Size = new System.Drawing.Size(71, 23);
            this.chkBoxOnion.TabIndex = 8;
            this.chkBoxOnion.Tag = "5";
            this.chkBoxOnion.Text = "Onion";
            this.chkBoxOnion.UseVisualStyleBackColor = true;
            this.chkBoxOnion.CheckedChanged += new System.EventHandler(this.chkBoxOnion_CheckedChanged);
            // 
            // chkBoxOlives
            // 
            this.chkBoxOlives.AutoSize = true;
            this.chkBoxOlives.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxOlives.Location = new System.Drawing.Point(155, 55);
            this.chkBoxOlives.Name = "chkBoxOlives";
            this.chkBoxOlives.Size = new System.Drawing.Size(71, 23);
            this.chkBoxOlives.TabIndex = 9;
            this.chkBoxOlives.Tag = "5";
            this.chkBoxOlives.Text = "Olives";
            this.chkBoxOlives.UseVisualStyleBackColor = true;
            this.chkBoxOlives.CheckedChanged += new System.EventHandler(this.chkBoxOlives_CheckedChanged);
            // 
            // chkBoxGreenPeppers
            // 
            this.chkBoxGreenPeppers.AutoSize = true;
            this.chkBoxGreenPeppers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxGreenPeppers.Location = new System.Drawing.Point(155, 80);
            this.chkBoxGreenPeppers.Name = "chkBoxGreenPeppers";
            this.chkBoxGreenPeppers.Size = new System.Drawing.Size(131, 23);
            this.chkBoxGreenPeppers.TabIndex = 10;
            this.chkBoxGreenPeppers.Tag = "5";
            this.chkBoxGreenPeppers.Text = "Green Peppers";
            this.chkBoxGreenPeppers.UseVisualStyleBackColor = true;
            this.chkBoxGreenPeppers.CheckedChanged += new System.EventHandler(this.chkBoxGreenPeppers_CheckedChanged);
            // 
            // GrpBox2
            // 
            this.GrpBox2.Controls.Add(this.chkBoxGreenPeppers);
            this.GrpBox2.Controls.Add(this.chkBoxOlives);
            this.GrpBox2.Controls.Add(this.chkBoxOnion);
            this.GrpBox2.Controls.Add(this.chkBoxTomatoes);
            this.GrpBox2.Controls.Add(this.chkBoxMushrooms);
            this.GrpBox2.Controls.Add(this.chkBoxExtraCheese);
            this.GrpBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBox2.Location = new System.Drawing.Point(224, 72);
            this.GrpBox2.Name = "GrpBox2";
            this.GrpBox2.Size = new System.Drawing.Size(300, 108);
            this.GrpBox2.TabIndex = 11;
            this.GrpBox2.TabStop = false;
            this.GrpBox2.Text = "Toppings";
            // 
            // GrpBox3
            // 
            this.GrpBox3.Controls.Add(this.RdThickCrust);
            this.GrpBox3.Controls.Add(this.RdThinCrust);
            this.GrpBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBox3.Location = new System.Drawing.Point(12, 235);
            this.GrpBox3.Name = "GrpBox3";
            this.GrpBox3.Size = new System.Drawing.Size(195, 63);
            this.GrpBox3.TabIndex = 12;
            this.GrpBox3.TabStop = false;
            this.GrpBox3.Text = "Crust";
            // 
            // RdThickCrust
            // 
            this.RdThickCrust.AutoSize = true;
            this.RdThickCrust.Location = new System.Drawing.Point(109, 26);
            this.RdThickCrust.Name = "RdThickCrust";
            this.RdThickCrust.Size = new System.Drawing.Size(65, 23);
            this.RdThickCrust.TabIndex = 2;
            this.RdThickCrust.TabStop = true;
            this.RdThickCrust.Tag = "10";
            this.RdThickCrust.Text = "Thick";
            this.RdThickCrust.UseVisualStyleBackColor = true;
            this.RdThickCrust.CheckedChanged += new System.EventHandler(this.RdBtn2Grp3_CheckedChanged);
            // 
            // RdThinCrust
            // 
            this.RdThinCrust.AutoSize = true;
            this.RdThinCrust.Location = new System.Drawing.Point(15, 24);
            this.RdThinCrust.Name = "RdThinCrust";
            this.RdThinCrust.Size = new System.Drawing.Size(59, 23);
            this.RdThinCrust.TabIndex = 1;
            this.RdThinCrust.TabStop = true;
            this.RdThinCrust.Tag = "0";
            this.RdThinCrust.Text = "Thin";
            this.RdThinCrust.UseVisualStyleBackColor = true;
            this.RdThinCrust.CheckedChanged += new System.EventHandler(this.RdBtn1Grp3_CheckedChanged);
            // 
            // GrpBox4
            // 
            this.GrpBox4.Controls.Add(this.RdTakeOut);
            this.GrpBox4.Controls.Add(this.RdEatIn);
            this.GrpBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBox4.Location = new System.Drawing.Point(224, 235);
            this.GrpBox4.Name = "GrpBox4";
            this.GrpBox4.Size = new System.Drawing.Size(224, 63);
            this.GrpBox4.TabIndex = 13;
            this.GrpBox4.TabStop = false;
            this.GrpBox4.Text = "Where To Eat";
            // 
            // RdTakeOut
            // 
            this.RdTakeOut.AutoSize = true;
            this.RdTakeOut.Location = new System.Drawing.Point(110, 24);
            this.RdTakeOut.Name = "RdTakeOut";
            this.RdTakeOut.Size = new System.Drawing.Size(92, 23);
            this.RdTakeOut.TabIndex = 2;
            this.RdTakeOut.TabStop = true;
            this.RdTakeOut.Text = "Take Out";
            this.RdTakeOut.UseVisualStyleBackColor = true;
            this.RdTakeOut.CheckedChanged += new System.EventHandler(this.RdBtn2Grp4_CheckedChanged);
            // 
            // RdEatIn
            // 
            this.RdEatIn.AutoSize = true;
            this.RdEatIn.Location = new System.Drawing.Point(15, 24);
            this.RdEatIn.Name = "RdEatIn";
            this.RdEatIn.Size = new System.Drawing.Size(69, 23);
            this.RdEatIn.TabIndex = 1;
            this.RdEatIn.TabStop = true;
            this.RdEatIn.Text = "Eat In";
            this.RdEatIn.UseVisualStyleBackColor = true;
            this.RdEatIn.CheckedChanged += new System.EventHandler(this.RdBtn1Grp4_CheckedChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(262, 337);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(106, 39);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "Order Pizza";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(393, 337);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(106, 39);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "Reset Form";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblPrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ToppingSelect);
            this.panel1.Controls.Add(this.SizeRadioLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(544, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 356);
            this.panel1.TabIndex = 16;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.BackColor = System.Drawing.Color.Black;
            this.LblPrice.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.ForeColor = System.Drawing.Color.Lime;
            this.LblPrice.Location = new System.Drawing.Point(66, 306);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(60, 45);
            this.LblPrice.TabIndex = 11;
            this.LblPrice.Text = "$0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Unselected";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(118, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Unselected";
            // 
            // ToppingSelect
            // 
            this.ToppingSelect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToppingSelect.Location = new System.Drawing.Point(3, 99);
            this.ToppingSelect.MaximumSize = new System.Drawing.Size(170, 60);
            this.ToppingSelect.Name = "ToppingSelect";
            this.ToppingSelect.Size = new System.Drawing.Size(78, 16);
            this.ToppingSelect.TabIndex = 7;
            this.ToppingSelect.Text = "No Toppings";
            // 
            // SizeRadioLabel
            // 
            this.SizeRadioLabel.AutoSize = true;
            this.SizeRadioLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeRadioLabel.Location = new System.Drawing.Point(71, 48);
            this.SizeRadioLabel.Name = "SizeRadioLabel";
            this.SizeRadioLabel.Size = new System.Drawing.Size(69, 16);
            this.SizeRadioLabel.TabIndex = 6;
            this.SizeRadioLabel.Text = "Unselected";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Where To eat  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Crust Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Size :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Toppings : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order Summery :";
            // 
            // Pizza_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.GrpBox4);
            this.Controls.Add(this.GrpBox3);
            this.Controls.Add(this.GrpBox2);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.label1);
            this.Name = "Pizza_Order";
            this.Text = "Pizza_Order";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.GrpBox2.ResumeLayout(false);
            this.GrpBox2.PerformLayout();
            this.GrpBox3.ResumeLayout(false);
            this.GrpBox3.PerformLayout();
            this.GrpBox4.ResumeLayout(false);
            this.GrpBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RdSmallSize;
        private System.Windows.Forms.RadioButton RdMediumSize;
        private System.Windows.Forms.RadioButton RdLargeSize;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.CheckBox chkBoxExtraCheese;
        private System.Windows.Forms.CheckBox chkBoxMushrooms;
        private System.Windows.Forms.CheckBox chkBoxTomatoes;
        private System.Windows.Forms.CheckBox chkBoxOnion;
        private System.Windows.Forms.CheckBox chkBoxOlives;
        private System.Windows.Forms.CheckBox chkBoxGreenPeppers;
        private System.Windows.Forms.GroupBox GrpBox2;
        private System.Windows.Forms.GroupBox GrpBox3;
        private System.Windows.Forms.RadioButton RdThickCrust;
        private System.Windows.Forms.RadioButton RdThinCrust;
        private System.Windows.Forms.GroupBox GrpBox4;
        private System.Windows.Forms.RadioButton RdTakeOut;
        private System.Windows.Forms.RadioButton RdEatIn;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ToppingSelect;
        private System.Windows.Forms.Label SizeRadioLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblPrice;
    }
}