
partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.RefuelGroupBox = new System.Windows.Forms.GroupBox();
            this.CashEntry = new System.Windows.Forms.TextBox();
            this.CountEntry = new System.Windows.Forms.TextBox();
            this.PaymentTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.CashRadioButton = new System.Windows.Forms.RadioButton();
            this.CountRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RefuelPrice = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FuelPrice = new System.Windows.Forms.TextBox();
            this.CafeGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CocaColaPrice = new System.Windows.Forms.TextBox();
            this.HamburgerCheckBox = new System.Windows.Forms.CheckBox();
            this.HotDogCheckBox = new System.Windows.Forms.CheckBox();
            this.CocaColaCount = new System.Windows.Forms.TextBox();
            this.FrenchFriesCheckBox = new System.Windows.Forms.CheckBox();
            this.FrenchFriesCount = new System.Windows.Forms.TextBox();
            this.CocaColaCheckBox = new System.Windows.Forms.CheckBox();
            this.HamburgerCount = new System.Windows.Forms.TextBox();
            this.HotDogCount = new System.Windows.Forms.TextBox();
            this.FrenchFriesPrice = new System.Windows.Forms.TextBox();
            this.HamburgerPrice = new System.Windows.Forms.TextBox();
            this.HotDogPrice = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DishPrice = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.TotalGroupBox = new System.Windows.Forms.Label();
            this.RefuelGroupBox.SuspendLayout();
            this.PaymentTypeGroupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.CafeGroupBox.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.TotalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefuelGroupBox
            // 
            this.RefuelGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.RefuelGroupBox.Controls.Add(this.CashEntry);
            this.RefuelGroupBox.Controls.Add(this.CountEntry);
            this.RefuelGroupBox.Controls.Add(this.PaymentTypeGroupBox);
            this.RefuelGroupBox.Controls.Add(this.label2);
            this.RefuelGroupBox.Controls.Add(this.label5);
            this.RefuelGroupBox.Controls.Add(this.label4);
            this.RefuelGroupBox.Controls.Add(this.label3);
            this.RefuelGroupBox.Controls.Add(this.label1);
            this.RefuelGroupBox.Controls.Add(this.comboBox1);
            this.RefuelGroupBox.Controls.Add(this.groupBox5);
            this.RefuelGroupBox.Controls.Add(this.groupBox4);
            this.RefuelGroupBox.Controls.Add(this.FuelPrice);
            this.RefuelGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefuelGroupBox.ForeColor = System.Drawing.Color.Bisque;
            this.RefuelGroupBox.Location = new System.Drawing.Point(389, 12);
            this.RefuelGroupBox.Name = "RefuelGroupBox";
            this.RefuelGroupBox.Size = new System.Drawing.Size(318, 312);
            this.RefuelGroupBox.TabIndex = 0;
            this.RefuelGroupBox.TabStop = false;
            this.RefuelGroupBox.Text = "FUEL";
            this.RefuelGroupBox.Enter += new System.EventHandler(this.RefuelGroupBox_Enter);
            // 
            // CashEntry
            // 
            this.CashEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CashEntry.Enabled = false;
            this.CashEntry.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CashEntry.Location = new System.Drawing.Point(159, 184);
            this.CashEntry.Name = "CashEntry";
            this.CashEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CashEntry.Size = new System.Drawing.Size(121, 31);
            this.CashEntry.TabIndex = 2;
            this.CashEntry.Text = "0";
            this.CashEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CashEntry.TextChanged += new System.EventHandler(this.FuelCount);
            // 
            // CountEntry
            // 
            this.CountEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CountEntry.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountEntry.Location = new System.Drawing.Point(159, 141);
            this.CountEntry.Name = "CountEntry";
            this.CountEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CountEntry.Size = new System.Drawing.Size(121, 31);
            this.CountEntry.TabIndex = 2;
            this.CountEntry.Text = "0";
            this.CountEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountEntry.TextChanged += new System.EventHandler(this.FuelCount);
            // 
            // PaymentTypeGroupBox
            // 
            this.PaymentTypeGroupBox.Controls.Add(this.CashRadioButton);
            this.PaymentTypeGroupBox.Controls.Add(this.CountRadioButton);
            this.PaymentTypeGroupBox.Location = new System.Drawing.Point(12, 131);
            this.PaymentTypeGroupBox.Name = "PaymentTypeGroupBox";
            this.PaymentTypeGroupBox.Size = new System.Drawing.Size(133, 84);
            this.PaymentTypeGroupBox.TabIndex = 4;
            this.PaymentTypeGroupBox.TabStop = false;
            // 
            // CashRadioButton
            // 
            this.CashRadioButton.AutoSize = true;
            this.CashRadioButton.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CashRadioButton.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.CashRadioButton.Location = new System.Drawing.Point(16, 50);
            this.CashRadioButton.Name = "CashRadioButton";
            this.CashRadioButton.Size = new System.Drawing.Size(64, 27);
            this.CashRadioButton.TabIndex = 0;
            this.CashRadioButton.Text = "Cash";
            this.CashRadioButton.UseVisualStyleBackColor = true;
            this.CashRadioButton.CheckedChanged += new System.EventHandler(this.PaymentType_CheckedChanged);
            // 
            // CountRadioButton
            // 
            this.CountRadioButton.AutoSize = true;
            this.CountRadioButton.Checked = true;
            this.CountRadioButton.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountRadioButton.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.CountRadioButton.Location = new System.Drawing.Point(16, 18);
            this.CountRadioButton.Name = "CountRadioButton";
            this.CountRadioButton.Size = new System.Drawing.Size(74, 27);
            this.CountRadioButton.TabIndex = 0;
            this.CountRadioButton.TabStop = true;
            this.CountRadioButton.Text = "Count";
            this.CountRadioButton.UseVisualStyleBackColor = true;
            this.CountRadioButton.CheckedChanged += new System.EventHandler(this.PaymentType_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Location = new System.Drawing.Point(280, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "AZN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Location = new System.Drawing.Point(280, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "AZN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Location = new System.Drawing.Point(286, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "L";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Petrol";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Items.AddRange(new object[] {
            "AI-99",
            "AI-95",
            "AI-98"});
            this.comboBox1.Location = new System.Drawing.Point(124, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(156, 31);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "AI-99";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RefuelPrice);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(6, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(306, 79);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // RefuelPrice
            // 
            this.RefuelPrice.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefuelPrice.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.RefuelPrice.Location = new System.Drawing.Point(88, 12);
            this.RefuelPrice.Name = "RefuelPrice";
            this.RefuelPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RefuelPrice.Size = new System.Drawing.Size(126, 64);
            this.RefuelPrice.TabIndex = 0;
            this.RefuelPrice.Text = "0";
            this.RefuelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefuelPrice.TextChanged += new System.EventHandler(this.Payment);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(528, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // FuelPrice
            // 
            this.FuelPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FuelPrice.Enabled = false;
            this.FuelPrice.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FuelPrice.Location = new System.Drawing.Point(124, 86);
            this.FuelPrice.Name = "FuelPrice";
            this.FuelPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FuelPrice.Size = new System.Drawing.Size(156, 31);
            this.FuelPrice.TabIndex = 2;
            this.FuelPrice.Text = "0.90";
            this.FuelPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CafeGroupBox
            // 
            this.CafeGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.CafeGroupBox.Controls.Add(this.label9);
            this.CafeGroupBox.Controls.Add(this.label11);
            this.CafeGroupBox.Controls.Add(this.CocaColaPrice);
            this.CafeGroupBox.Controls.Add(this.HamburgerCheckBox);
            this.CafeGroupBox.Controls.Add(this.HotDogCheckBox);
            this.CafeGroupBox.Controls.Add(this.CocaColaCount);
            this.CafeGroupBox.Controls.Add(this.FrenchFriesCheckBox);
            this.CafeGroupBox.Controls.Add(this.FrenchFriesCount);
            this.CafeGroupBox.Controls.Add(this.CocaColaCheckBox);
            this.CafeGroupBox.Controls.Add(this.HamburgerCount);
            this.CafeGroupBox.Controls.Add(this.HotDogCount);
            this.CafeGroupBox.Controls.Add(this.FrenchFriesPrice);
            this.CafeGroupBox.Controls.Add(this.HamburgerPrice);
            this.CafeGroupBox.Controls.Add(this.HotDogPrice);
            this.CafeGroupBox.Controls.Add(this.groupBox6);
            this.CafeGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CafeGroupBox.ForeColor = System.Drawing.Color.Bisque;
            this.CafeGroupBox.Location = new System.Drawing.Point(17, 12);
            this.CafeGroupBox.Name = "CafeGroupBox";
            this.CafeGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CafeGroupBox.Size = new System.Drawing.Size(307, 312);
            this.CafeGroupBox.TabIndex = 0;
            this.CafeGroupBox.TabStop = false;
            this.CafeGroupBox.Text = "CAFE";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label9.Location = new System.Drawing.Point(88, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Count";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label11.Location = new System.Drawing.Point(10, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Price";
            // 
            // CocaColaPrice
            // 
            this.CocaColaPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CocaColaPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CocaColaPrice.Enabled = false;
            this.CocaColaPrice.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CocaColaPrice.Location = new System.Drawing.Point(7, 185);
            this.CocaColaPrice.Name = "CocaColaPrice";
            this.CocaColaPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CocaColaPrice.Size = new System.Drawing.Size(51, 31);
            this.CocaColaPrice.TabIndex = 2;
            this.CocaColaPrice.Text = "1.0";
            this.CocaColaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HamburgerCheckBox
            // 
            this.HamburgerCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HamburgerCheckBox.AutoSize = true;
            this.HamburgerCheckBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HamburgerCheckBox.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.HamburgerCheckBox.Location = new System.Drawing.Point(168, 113);
            this.HamburgerCheckBox.Name = "HamburgerCheckBox";
            this.HamburgerCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HamburgerCheckBox.Size = new System.Drawing.Size(133, 26);
            this.HamburgerCheckBox.TabIndex = 1;
            this.HamburgerCheckBox.Text = "Hamburger";
            this.HamburgerCheckBox.UseVisualStyleBackColor = true;
            this.HamburgerCheckBox.CheckedChanged += new System.EventHandler(this.Dish_Checked);
            // 
            // HotDogCheckBox
            // 
            this.HotDogCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HotDogCheckBox.AutoSize = true;
            this.HotDogCheckBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HotDogCheckBox.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.HotDogCheckBox.Location = new System.Drawing.Point(168, 75);
            this.HotDogCheckBox.Name = "HotDogCheckBox";
            this.HotDogCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HotDogCheckBox.Size = new System.Drawing.Size(104, 26);
            this.HotDogCheckBox.TabIndex = 1;
            this.HotDogCheckBox.Text = "Hot-Dog";
            this.HotDogCheckBox.UseVisualStyleBackColor = true;
            this.HotDogCheckBox.CheckedChanged += new System.EventHandler(this.Dish_Checked);
            // 
            // CocaColaCount
            // 
            this.CocaColaCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CocaColaCount.Enabled = false;
            this.CocaColaCount.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CocaColaCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CocaColaCount.Location = new System.Drawing.Point(91, 185);
            this.CocaColaCount.Name = "CocaColaCount";
            this.CocaColaCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CocaColaCount.Size = new System.Drawing.Size(51, 31);
            this.CocaColaCount.TabIndex = 2;
            this.CocaColaCount.Text = "0";
            this.CocaColaCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CocaColaCount.EnabledChanged += new System.EventHandler(this.DishPrice_Text);
            this.CocaColaCount.TextChanged += new System.EventHandler(this.DishPrice_Text);
            // 
            // FrenchFriesCheckBox
            // 
            this.FrenchFriesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrenchFriesCheckBox.AutoSize = true;
            this.FrenchFriesCheckBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FrenchFriesCheckBox.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.FrenchFriesCheckBox.Location = new System.Drawing.Point(168, 150);
            this.FrenchFriesCheckBox.Name = "FrenchFriesCheckBox";
            this.FrenchFriesCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FrenchFriesCheckBox.Size = new System.Drawing.Size(147, 26);
            this.FrenchFriesCheckBox.TabIndex = 1;
            this.FrenchFriesCheckBox.Text = "French Fries";
            this.FrenchFriesCheckBox.UseVisualStyleBackColor = true;
            this.FrenchFriesCheckBox.CheckedChanged += new System.EventHandler(this.Dish_Checked);
            // 
            // FrenchFriesCount
            // 
            this.FrenchFriesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrenchFriesCount.Enabled = false;
            this.FrenchFriesCount.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FrenchFriesCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FrenchFriesCount.Location = new System.Drawing.Point(91, 148);
            this.FrenchFriesCount.Name = "FrenchFriesCount";
            this.FrenchFriesCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FrenchFriesCount.Size = new System.Drawing.Size(51, 31);
            this.FrenchFriesCount.TabIndex = 2;
            this.FrenchFriesCount.Text = "0";
            this.FrenchFriesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FrenchFriesCount.EnabledChanged += new System.EventHandler(this.DishPrice_Text);
            this.FrenchFriesCount.TextChanged += new System.EventHandler(this.DishPrice_Text);
            // 
            // CocaColaCheckBox
            // 
            this.CocaColaCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CocaColaCheckBox.AutoSize = true;
            this.CocaColaCheckBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CocaColaCheckBox.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.CocaColaCheckBox.Location = new System.Drawing.Point(168, 187);
            this.CocaColaCheckBox.Name = "CocaColaCheckBox";
            this.CocaColaCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CocaColaCheckBox.Size = new System.Drawing.Size(83, 26);
            this.CocaColaCheckBox.TabIndex = 1;
            this.CocaColaCheckBox.Text = "COLA";
            this.CocaColaCheckBox.UseVisualStyleBackColor = true;
            this.CocaColaCheckBox.CheckedChanged += new System.EventHandler(this.Dish_Checked);
            // 
            // HamburgerCount
            // 
            this.HamburgerCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HamburgerCount.Enabled = false;
            this.HamburgerCount.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HamburgerCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HamburgerCount.Location = new System.Drawing.Point(91, 111);
            this.HamburgerCount.Name = "HamburgerCount";
            this.HamburgerCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HamburgerCount.Size = new System.Drawing.Size(51, 31);
            this.HamburgerCount.TabIndex = 2;
            this.HamburgerCount.Text = "0";
            this.HamburgerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HamburgerCount.EnabledChanged += new System.EventHandler(this.DishPrice_Text);
            this.HamburgerCount.TextChanged += new System.EventHandler(this.DishPrice_Text);
            // 
            // HotDogCount
            // 
            this.HotDogCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HotDogCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HotDogCount.Enabled = false;
            this.HotDogCount.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HotDogCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HotDogCount.Location = new System.Drawing.Point(91, 73);
            this.HotDogCount.Name = "HotDogCount";
            this.HotDogCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HotDogCount.Size = new System.Drawing.Size(51, 31);
            this.HotDogCount.TabIndex = 2;
            this.HotDogCount.Text = "0";
            this.HotDogCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HotDogCount.EnabledChanged += new System.EventHandler(this.DishPrice_Text);
            this.HotDogCount.TextChanged += new System.EventHandler(this.DishPrice_Text);
            // 
            // FrenchFriesPrice
            // 
            this.FrenchFriesPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrenchFriesPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FrenchFriesPrice.Enabled = false;
            this.FrenchFriesPrice.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FrenchFriesPrice.Location = new System.Drawing.Point(7, 148);
            this.FrenchFriesPrice.Name = "FrenchFriesPrice";
            this.FrenchFriesPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FrenchFriesPrice.Size = new System.Drawing.Size(51, 31);
            this.FrenchFriesPrice.TabIndex = 2;
            this.FrenchFriesPrice.Text = "3.5";
            this.FrenchFriesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HamburgerPrice
            // 
            this.HamburgerPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HamburgerPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HamburgerPrice.Enabled = false;
            this.HamburgerPrice.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HamburgerPrice.Location = new System.Drawing.Point(7, 111);
            this.HamburgerPrice.Name = "HamburgerPrice";
            this.HamburgerPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HamburgerPrice.Size = new System.Drawing.Size(51, 31);
            this.HamburgerPrice.TabIndex = 2;
            this.HamburgerPrice.Text = "2.0";
            this.HamburgerPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HotDogPrice
            // 
            this.HotDogPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HotDogPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HotDogPrice.Enabled = false;
            this.HotDogPrice.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HotDogPrice.Location = new System.Drawing.Point(7, 73);
            this.HotDogPrice.Name = "HotDogPrice";
            this.HotDogPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HotDogPrice.Size = new System.Drawing.Size(51, 31);
            this.HotDogPrice.TabIndex = 2;
            this.HotDogPrice.Text = "0.70";
            this.HotDogPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.DishPrice);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.ForeColor = System.Drawing.Color.Black;
            this.groupBox6.Location = new System.Drawing.Point(6, 224);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(295, 79);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // DishPrice
            // 
            this.DishPrice.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DishPrice.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.DishPrice.Location = new System.Drawing.Point(95, 12);
            this.DishPrice.Name = "DishPrice";
            this.DishPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DishPrice.Size = new System.Drawing.Size(126, 64);
            this.DishPrice.TabIndex = 0;
            this.DishPrice.Text = "0";
            this.DishPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DishPrice.TextChanged += new System.EventHandler(this.Payment);
            // 
            // TotalBox
            // 
            this.TotalBox.BackColor = System.Drawing.Color.Transparent;
            this.TotalBox.Controls.Add(this.label8);
            this.TotalBox.Controls.Add(this.BuyButton);
            this.TotalBox.Controls.Add(this.TotalGroupBox);
            this.TotalBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalBox.ForeColor = System.Drawing.Color.Black;
            this.TotalBox.Location = new System.Drawing.Point(257, 330);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(193, 151);
            this.TotalBox.TabIndex = 1;
            this.TotalBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.label8.Location = new System.Drawing.Point(103, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "AZN";
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.Color.White;
            this.BuyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BuyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyButton.FlatAppearance.BorderSize = 0;
            this.BuyButton.Font = new System.Drawing.Font("Bookman Old Style", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuyButton.ForeColor = System.Drawing.Color.Tan;
            this.BuyButton.Location = new System.Drawing.Point(48, 85);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(98, 48);
            this.BuyButton.TabIndex = 0;
            this.BuyButton.Text = "Pay";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // TotalGroupBox
            // 
            this.TotalGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.TotalGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalGroupBox.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalGroupBox.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.TotalGroupBox.Location = new System.Drawing.Point(-27, 16);
            this.TotalGroupBox.Name = "TotalGroupBox";
            this.TotalGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalGroupBox.Size = new System.Drawing.Size(182, 64);
            this.TotalGroupBox.TabIndex = 0;
            this.TotalGroupBox.Text = "0";
            this.TotalGroupBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 503);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.CafeGroupBox);
            this.Controls.Add(this.RefuelGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "BestOil";
            this.RefuelGroupBox.ResumeLayout(false);
            this.RefuelGroupBox.PerformLayout();
            this.PaymentTypeGroupBox.ResumeLayout(false);
            this.PaymentTypeGroupBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.CafeGroupBox.ResumeLayout(false);
            this.CafeGroupBox.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.TotalBox.ResumeLayout(false);
            this.TotalBox.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox RefuelGroupBox;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.GroupBox CafeGroupBox;
    private System.Windows.Forms.TextBox CocaColaCount;
    private System.Windows.Forms.TextBox FrenchFriesCount;
    private System.Windows.Forms.TextBox HamburgerCount;
    private System.Windows.Forms.TextBox HotDogCount;
    private System.Windows.Forms.TextBox FrenchFriesPrice;
    private System.Windows.Forms.TextBox CocaColaPrice;
    private System.Windows.Forms.TextBox HamburgerPrice;
    private System.Windows.Forms.TextBox HotDogPrice;
    private System.Windows.Forms.CheckBox CocaColaCheckBox;
    private System.Windows.Forms.CheckBox FrenchFriesCheckBox;
    private System.Windows.Forms.CheckBox HamburgerCheckBox;
    private System.Windows.Forms.CheckBox HotDogCheckBox;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.GroupBox TotalBox;
    private System.Windows.Forms.Button BuyButton;
    private System.Windows.Forms.Label DishPrice;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TextBox CashEntry;
    private System.Windows.Forms.TextBox CountEntry;
    private System.Windows.Forms.GroupBox PaymentTypeGroupBox;
    private System.Windows.Forms.RadioButton CashRadioButton;
    private System.Windows.Forms.RadioButton CountRadioButton;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label RefuelPrice;
    private System.Windows.Forms.TextBox FuelPrice;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label TotalGroupBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label11;
}
