namespace PizzaProjectBt
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
            this.GroubSizeBox1 = new System.Windows.Forms.GroupBox();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.grbToppingsBox2 = new System.Windows.Forms.GroupBox();
            this.chkBoxExtraChe6 = new System.Windows.Forms.CheckBox();
            this.chkBoxOives5 = new System.Windows.Forms.CheckBox();
            this.chkBoxOni4 = new System.Windows.Forms.CheckBox();
            this.chkBoxGrePaper3 = new System.Windows.Forms.CheckBox();
            this.chkBoxMash2 = new System.Windows.Forms.CheckBox();
            this.chkBoxTom1 = new System.Windows.Forms.CheckBox();
            this.groupBoxCrustType3 = new System.Windows.Forms.GroupBox();
            this.rbtnThin = new System.Windows.Forms.RadioButton();
            this.rbtnThic = new System.Windows.Forms.RadioButton();
            this.grbwhereYoueatBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnInSide = new System.Windows.Forms.RadioButton();
            this.rbtntakeout = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1Size = new System.Windows.Forms.Label();
            this.label3Size = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3CrustType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3wheretoeat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3TotalPrice = new System.Windows.Forms.Label();
            this.label7TotalPrice = new System.Windows.Forms.Label();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.lab3Toppings = new System.Windows.Forms.Label();
            this.GroubSizeBox1.SuspendLayout();
            this.grbToppingsBox2.SuspendLayout();
            this.groupBoxCrustType3.SuspendLayout();
            this.grbwhereYoueatBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroubSizeBox1
            // 
            this.GroubSizeBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GroubSizeBox1.Controls.Add(this.rbMedium);
            this.GroubSizeBox1.Controls.Add(this.rbSmall);
            this.GroubSizeBox1.Controls.Add(this.rbLarge);
            this.GroubSizeBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroubSizeBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroubSizeBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GroubSizeBox1.Location = new System.Drawing.Point(63, 63);
            this.GroubSizeBox1.Name = "GroubSizeBox1";
            this.GroubSizeBox1.Size = new System.Drawing.Size(175, 130);
            this.GroubSizeBox1.TabIndex = 0;
            this.GroubSizeBox1.TabStop = false;
            this.GroubSizeBox1.Text = "Size";
            this.GroubSizeBox1.Enter += new System.EventHandler(this.GroubSizeBox1_Enter);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbMedium.Location = new System.Drawing.Point(6, 63);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(84, 20);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "20";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = false;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbSmall.Location = new System.Drawing.Point(6, 107);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(66, 20);
            this.rbSmall.TabIndex = 3;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = false;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbLarge.Checked = true;
            this.rbLarge.Location = new System.Drawing.Point(6, 19);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(67, 20);
            this.rbLarge.TabIndex = 1;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "30";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = false;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(60, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prepare Your Pizza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbToppingsBox2
            // 
            this.grbToppingsBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grbToppingsBox2.Controls.Add(this.chkBoxExtraChe6);
            this.grbToppingsBox2.Controls.Add(this.chkBoxOives5);
            this.grbToppingsBox2.Controls.Add(this.chkBoxOni4);
            this.grbToppingsBox2.Controls.Add(this.chkBoxGrePaper3);
            this.grbToppingsBox2.Controls.Add(this.chkBoxMash2);
            this.grbToppingsBox2.Controls.Add(this.chkBoxTom1);
            this.grbToppingsBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbToppingsBox2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbToppingsBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grbToppingsBox2.Location = new System.Drawing.Point(271, 63);
            this.grbToppingsBox2.Name = "grbToppingsBox2";
            this.grbToppingsBox2.Size = new System.Drawing.Size(273, 130);
            this.grbToppingsBox2.TabIndex = 4;
            this.grbToppingsBox2.TabStop = false;
            this.grbToppingsBox2.Text = "Toppings";
            this.grbToppingsBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkBoxExtraChe6
            // 
            this.chkBoxExtraChe6.AutoSize = true;
            this.chkBoxExtraChe6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkBoxExtraChe6.Location = new System.Drawing.Point(141, 94);
            this.chkBoxExtraChe6.Name = "chkBoxExtraChe6";
            this.chkBoxExtraChe6.Size = new System.Drawing.Size(114, 20);
            this.chkBoxExtraChe6.TabIndex = 9;
            this.chkBoxExtraChe6.Tag = "5";
            this.chkBoxExtraChe6.Text = "Extra Chees";
            this.chkBoxExtraChe6.UseVisualStyleBackColor = false;
            this.chkBoxExtraChe6.CheckedChanged += new System.EventHandler(this.chkBox6_CheckedChanged);
            // 
            // chkBoxOives5
            // 
            this.chkBoxOives5.AutoSize = true;
            this.chkBoxOives5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkBoxOives5.Location = new System.Drawing.Point(141, 59);
            this.chkBoxOives5.Name = "chkBoxOives5";
            this.chkBoxOives5.Size = new System.Drawing.Size(73, 20);
            this.chkBoxOives5.TabIndex = 10;
            this.chkBoxOives5.Tag = "5";
            this.chkBoxOives5.Text = "Olives";
            this.chkBoxOives5.UseVisualStyleBackColor = false;
            this.chkBoxOives5.CheckedChanged += new System.EventHandler(this.chkBox5_CheckedChanged);
            // 
            // chkBoxOni4
            // 
            this.chkBoxOni4.AutoSize = true;
            this.chkBoxOni4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkBoxOni4.Location = new System.Drawing.Point(141, 25);
            this.chkBoxOni4.Name = "chkBoxOni4";
            this.chkBoxOni4.Size = new System.Drawing.Size(71, 20);
            this.chkBoxOni4.TabIndex = 8;
            this.chkBoxOni4.Tag = "5";
            this.chkBoxOni4.Text = "Onion";
            this.chkBoxOni4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBoxOni4.UseVisualStyleBackColor = false;
            this.chkBoxOni4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkBoxGrePaper3
            // 
            this.chkBoxGrePaper3.AutoSize = true;
            this.chkBoxGrePaper3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkBoxGrePaper3.Location = new System.Drawing.Point(6, 95);
            this.chkBoxGrePaper3.Name = "chkBoxGrePaper3";
            this.chkBoxGrePaper3.Size = new System.Drawing.Size(116, 20);
            this.chkBoxGrePaper3.TabIndex = 6;
            this.chkBoxGrePaper3.Tag = "5";
            this.chkBoxGrePaper3.Text = "Green Paper";
            this.chkBoxGrePaper3.UseVisualStyleBackColor = false;
            this.chkBoxGrePaper3.CheckedChanged += new System.EventHandler(this.chkBox3_CheckedChanged);
            // 
            // chkBoxMash2
            // 
            this.chkBoxMash2.AutoSize = true;
            this.chkBoxMash2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkBoxMash2.Location = new System.Drawing.Point(6, 60);
            this.chkBoxMash2.Name = "chkBoxMash2";
            this.chkBoxMash2.Size = new System.Drawing.Size(118, 20);
            this.chkBoxMash2.TabIndex = 7;
            this.chkBoxMash2.Tag = "5";
            this.chkBoxMash2.Text = "Mashruooms";
            this.chkBoxMash2.UseVisualStyleBackColor = false;
            this.chkBoxMash2.CheckedChanged += new System.EventHandler(this.chkBox2_CheckedChanged);
            // 
            // chkBoxTom1
            // 
            this.chkBoxTom1.AutoSize = true;
            this.chkBoxTom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkBoxTom1.Location = new System.Drawing.Point(6, 25);
            this.chkBoxTom1.Name = "chkBoxTom1";
            this.chkBoxTom1.Size = new System.Drawing.Size(88, 20);
            this.chkBoxTom1.TabIndex = 5;
            this.chkBoxTom1.Tag = "5";
            this.chkBoxTom1.Text = "Tomatos";
            this.chkBoxTom1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBoxTom1.UseVisualStyleBackColor = false;
            this.chkBoxTom1.CheckedChanged += new System.EventHandler(this.chkBox1_CheckedChanged);
            // 
            // groupBoxCrustType3
            // 
            this.groupBoxCrustType3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBoxCrustType3.Controls.Add(this.rbtnThin);
            this.groupBoxCrustType3.Controls.Add(this.rbtnThic);
            this.groupBoxCrustType3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxCrustType3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCrustType3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBoxCrustType3.Location = new System.Drawing.Point(63, 258);
            this.groupBoxCrustType3.Name = "groupBoxCrustType3";
            this.groupBoxCrustType3.Size = new System.Drawing.Size(175, 87);
            this.groupBoxCrustType3.TabIndex = 4;
            this.groupBoxCrustType3.TabStop = false;
            this.groupBoxCrustType3.Text = "CrustType";
            this.groupBoxCrustType3.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbtnThin
            // 
            this.rbtnThin.AutoSize = true;
            this.rbtnThin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbtnThin.Location = new System.Drawing.Point(10, 25);
            this.rbtnThin.Name = "rbtnThin";
            this.rbtnThin.Size = new System.Drawing.Size(59, 20);
            this.rbtnThin.TabIndex = 2;
            this.rbtnThin.Tag = "0";
            this.rbtnThin.Text = "Thin";
            this.rbtnThin.UseVisualStyleBackColor = false;
            this.rbtnThin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // rbtnThic
            // 
            this.rbtnThic.AutoSize = true;
            this.rbtnThic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbtnThic.Checked = true;
            this.rbtnThic.Location = new System.Drawing.Point(98, 25);
            this.rbtnThic.Name = "rbtnThic";
            this.rbtnThic.Size = new System.Drawing.Size(58, 20);
            this.rbtnThic.TabIndex = 3;
            this.rbtnThic.TabStop = true;
            this.rbtnThic.Tag = "5";
            this.rbtnThic.Text = "Thic";
            this.rbtnThic.UseVisualStyleBackColor = false;
            this.rbtnThic.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // grbwhereYoueatBox4
            // 
            this.grbwhereYoueatBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grbwhereYoueatBox4.Controls.Add(this.rbtnInSide);
            this.grbwhereYoueatBox4.Controls.Add(this.rbtntakeout);
            this.grbwhereYoueatBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbwhereYoueatBox4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbwhereYoueatBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grbwhereYoueatBox4.Location = new System.Drawing.Point(271, 258);
            this.grbwhereYoueatBox4.Name = "grbwhereYoueatBox4";
            this.grbwhereYoueatBox4.Size = new System.Drawing.Size(273, 87);
            this.grbwhereYoueatBox4.TabIndex = 4;
            this.grbwhereYoueatBox4.TabStop = false;
            this.grbwhereYoueatBox4.Text = "         ";
            this.grbwhereYoueatBox4.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rbtnInSide
            // 
            this.rbtnInSide.AutoSize = true;
            this.rbtnInSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbtnInSide.Checked = true;
            this.rbtnInSide.Location = new System.Drawing.Point(7, 21);
            this.rbtnInSide.Name = "rbtnInSide";
            this.rbtnInSide.Size = new System.Drawing.Size(77, 20);
            this.rbtnInSide.TabIndex = 2;
            this.rbtnInSide.TabStop = true;
            this.rbtnInSide.Text = "In Side";
            this.rbtnInSide.UseVisualStyleBackColor = false;
            this.rbtnInSide.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_3);
            // 
            // rbtntakeout
            // 
            this.rbtntakeout.AutoSize = true;
            this.rbtntakeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbtntakeout.Location = new System.Drawing.Point(122, 21);
            this.rbtntakeout.Name = "rbtntakeout";
            this.rbtntakeout.Size = new System.Drawing.Size(93, 20);
            this.rbtntakeout.TabIndex = 3;
            this.rbtntakeout.TabStop = true;
            this.rbtntakeout.Text = "Take Out";
            this.rbtntakeout.UseVisualStyleBackColor = false;
            this.rbtntakeout.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(566, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order Summary";
            // 
            // label1Size
            // 
            this.label1Size.AutoSize = true;
            this.label1Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Size.ForeColor = System.Drawing.Color.White;
            this.label1Size.Location = new System.Drawing.Point(560, 90);
            this.label1Size.Name = "label1Size";
            this.label1Size.Size = new System.Drawing.Size(65, 25);
            this.label1Size.TabIndex = 6;
            this.label1Size.Text = "Size:";
            this.label1Size.Click += new System.EventHandler(this.label1Size_Click);
            // 
            // label3Size
            // 
            this.label3Size.AutoSize = true;
            this.label3Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Size.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3Size.Location = new System.Drawing.Point(560, 125);
            this.label3Size.Name = "label3Size";
            this.label3Size.Size = new System.Drawing.Size(23, 13);
            this.label3Size.TabIndex = 7;
            this.label3Size.Text = "    ";
            this.label3Size.Click += new System.EventHandler(this.label3Size_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(560, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Toppings:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3CrustType
            // 
            this.label3CrustType.AutoSize = true;
            this.label3CrustType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3CrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3CrustType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3CrustType.Location = new System.Drawing.Point(572, 271);
            this.label3CrustType.Name = "label3CrustType";
            this.label3CrustType.Size = new System.Drawing.Size(11, 13);
            this.label3CrustType.TabIndex = 11;
            this.label3CrustType.Text = " ";
            this.label3CrustType.Click += new System.EventHandler(this.label3wheretoeat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(560, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Crust Type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3wheretoeat
            // 
            this.label3wheretoeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3wheretoeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3wheretoeat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3wheretoeat.Location = new System.Drawing.Point(572, 324);
            this.label3wheretoeat.Name = "label3wheretoeat";
            this.label3wheretoeat.Size = new System.Drawing.Size(63, 34);
            this.label3wheretoeat.TabIndex = 13;
            this.label3wheretoeat.Text = "   ";
            this.label3wheretoeat.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(566, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "where To Eat";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3TotalPrice
            // 
            this.label3TotalPrice.AutoSize = true;
            this.label3TotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3TotalPrice.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3TotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3TotalPrice.Location = new System.Drawing.Point(504, 371);
            this.label3TotalPrice.Name = "label3TotalPrice";
            this.label3TotalPrice.Size = new System.Drawing.Size(154, 33);
            this.label3TotalPrice.TabIndex = 14;
            this.label3TotalPrice.Text = "Total Price:";
            // 
            // label7TotalPrice
            // 
            this.label7TotalPrice.AutoSize = true;
            this.label7TotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7TotalPrice.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7TotalPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7TotalPrice.Location = new System.Drawing.Point(673, 372);
            this.label7TotalPrice.Name = "label7TotalPrice";
            this.label7TotalPrice.Size = new System.Drawing.Size(39, 33);
            this.label7TotalPrice.TabIndex = 15;
            this.label7TotalPrice.Text = "   ";
            this.label7TotalPrice.Click += new System.EventHandler(this.label7TotalPrice_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetForm.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResetForm.Location = new System.Drawing.Point(161, 370);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(118, 43);
            this.btnResetForm.TabIndex = 16;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConfirmOrder.Location = new System.Drawing.Point(338, 370);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(118, 43);
            this.btnConfirmOrder.TabIndex = 17;
            this.btnConfirmOrder.Text = "Confirm ";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // lab3Toppings
            // 
            this.lab3Toppings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab3Toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab3Toppings.Location = new System.Drawing.Point(558, 193);
            this.lab3Toppings.Name = "lab3Toppings";
            this.lab3Toppings.Size = new System.Drawing.Size(181, 48);
            this.lab3Toppings.TabIndex = 18;
            this.lab3Toppings.Text = "              ";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PizzaProjectBt.Properties.Resources.pexels_brettjordan_842519;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab3Toppings);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.label7TotalPrice);
            this.Controls.Add(this.label3TotalPrice);
            this.Controls.Add(this.label3wheretoeat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3CrustType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3Size);
            this.Controls.Add(this.label1Size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbwhereYoueatBox4);
            this.Controls.Add(this.groupBoxCrustType3);
            this.Controls.Add(this.grbToppingsBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroubSizeBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroubSizeBox1.ResumeLayout(false);
            this.GroubSizeBox1.PerformLayout();
            this.grbToppingsBox2.ResumeLayout(false);
            this.grbToppingsBox2.PerformLayout();
            this.groupBoxCrustType3.ResumeLayout(false);
            this.groupBoxCrustType3.PerformLayout();
            this.grbwhereYoueatBox4.ResumeLayout(false);
            this.grbwhereYoueatBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroubSizeBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbToppingsBox2;
        private System.Windows.Forms.CheckBox chkBoxGrePaper3;
        private System.Windows.Forms.CheckBox chkBoxMash2;
        private System.Windows.Forms.CheckBox chkBoxTom1;
        private System.Windows.Forms.CheckBox chkBoxExtraChe6;
        private System.Windows.Forms.CheckBox chkBoxOives5;
        private System.Windows.Forms.CheckBox chkBoxOni4;
        private System.Windows.Forms.GroupBox groupBoxCrustType3;
        private System.Windows.Forms.RadioButton rbtnThin;
        private System.Windows.Forms.RadioButton rbtnThic;
        private System.Windows.Forms.GroupBox grbwhereYoueatBox4;
        private System.Windows.Forms.RadioButton rbtnInSide;
        private System.Windows.Forms.RadioButton rbtntakeout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1Size;
        private System.Windows.Forms.Label label3Size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3CrustType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3wheretoeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3TotalPrice;
        private System.Windows.Forms.Label label7TotalPrice;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Label lab3Toppings;
    }
}

