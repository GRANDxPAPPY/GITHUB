namespace WinFormsApp1
{
    partial class Form2
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
        public void InitializeComponent()
        {
            panel1 = new Panel();
            Button_Cancel = new Button();
            Button_Save = new Button();
            textBoxMax = new TextBox();
            Label_Max = new Label();
            textBox_Min = new TextBox();
            Label_Min = new Label();
            textBox5 = new TextBox();
            Label_MachID = new Label();
            textBox_Price = new TextBox();
            Label_Price = new Label();
            textBox3 = new TextBox();
            Label_Inv = new Label();
            textBox_Name = new TextBox();
            Label_Name = new Label();
            textBox1 = new TextBox();
            Label_ID = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            AddPartLabel = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            textBox8 = new TextBox();
            label1 = new Label();
            textBox9 = new TextBox();
            label2 = new Label();
            textBox10 = new TextBox();
            label3 = new Label();
            textBox11 = new TextBox();
            label4 = new Label();
            textBox12 = new TextBox();
            label5 = new Label();
            textBox13 = new TextBox();
            label6 = new Label();
            textBox14 = new TextBox();
            label7 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            Label_Modify = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(Button_Cancel);
            panel1.Controls.Add(Button_Save);
            panel1.Controls.Add(textBoxMax);
            panel1.Controls.Add(Label_Max);
            panel1.Controls.Add(textBox_Min);
            panel1.Controls.Add(Label_Min);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(Label_MachID);
            panel1.Controls.Add(textBox_Price);
            panel1.Controls.Add(Label_Price);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(Label_Inv);
            panel1.Controls.Add(textBox_Name);
            panel1.Controls.Add(Label_Name);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Label_ID);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(AddPartLabel);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 393);
            panel1.TabIndex = 0;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Location = new Point(554, 330);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(75, 23);
            Button_Cancel.TabIndex = 24;
            Button_Cancel.Text = "Cancel";
            Button_Cancel.UseVisualStyleBackColor = true;
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // Button_Save
            // 
            Button_Save.Location = new Point(456, 330);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(75, 23);
            Button_Save.TabIndex = 23;
            Button_Save.Text = "Save";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Button_Save_Click;
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(477, 132);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(64, 23);
            textBoxMax.TabIndex = 22;
            textBoxMax.TextChanged += textBox6_TextChanged;
            // 
            // Label_Max
            // 
            Label_Max.AutoSize = true;
            Label_Max.Font = new Font("Segoe UI", 13F);
            Label_Max.ForeColor = SystemColors.ButtonHighlight;
            Label_Max.Location = new Point(386, 129);
            Label_Max.Name = "Label_Max";
            Label_Max.Size = new Size(45, 25);
            Label_Max.TabIndex = 21;
            Label_Max.Text = "Max";
            // 
            // textBox_Min
            // 
            textBox_Min.Location = new Point(477, 87);
            textBox_Min.Name = "textBox_Min";
            textBox_Min.Size = new Size(64, 23);
            textBox_Min.TabIndex = 20;
            textBox_Min.TextChanged += textBox7_TextChanged;
            // 
            // Label_Min
            // 
            Label_Min.AutoSize = true;
            Label_Min.Font = new Font("Segoe UI", 13F);
            Label_Min.ForeColor = SystemColors.ButtonHighlight;
            Label_Min.Location = new Point(386, 84);
            Label_Min.Name = "Label_Min";
            Label_Min.Size = new Size(42, 25);
            Label_Min.TabIndex = 19;
            Label_Min.Text = "Min";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(179, 269);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(182, 23);
            textBox5.TabIndex = 18;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Label_MachID
            // 
            Label_MachID.AutoSize = true;
            Label_MachID.Font = new Font("Segoe UI", 13F);
            Label_MachID.ForeColor = SystemColors.ButtonHighlight;
            Label_MachID.Location = new Point(17, 269);
            Label_MachID.Name = "Label_MachID";
            Label_MachID.Size = new Size(101, 25);
            Label_MachID.TabIndex = 17;
            Label_MachID.Text = "Machine ID";
            Label_MachID.Click += Label_MachID_Click;
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new Point(179, 224);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(182, 23);
            textBox_Price.TabIndex = 16;
            textBox_Price.TextChanged += textBox4_TextChanged;
            // 
            // Label_Price
            // 
            Label_Price.AutoSize = true;
            Label_Price.Font = new Font("Segoe UI", 13F);
            Label_Price.ForeColor = SystemColors.ButtonHighlight;
            Label_Price.Location = new Point(41, 222);
            Label_Price.Name = "Label_Price";
            Label_Price.Size = new Size(49, 25);
            Label_Price.TabIndex = 15;
            Label_Price.Text = "Price";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(179, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 23);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Label_Inv
            // 
            Label_Inv.AutoSize = true;
            Label_Inv.Font = new Font("Segoe UI", 13F);
            Label_Inv.ForeColor = SystemColors.ButtonHighlight;
            Label_Inv.Location = new Point(31, 178);
            Label_Inv.Name = "Label_Inv";
            Label_Inv.Size = new Size(87, 25);
            Label_Inv.TabIndex = 13;
            Label_Inv.Text = "Inventory";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(179, 131);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(182, 23);
            textBox_Name.TabIndex = 12;
            textBox_Name.TextChanged += textBox2_TextChanged;
            // 
            // Label_Name
            // 
            Label_Name.AutoSize = true;
            Label_Name.Font = new Font("Segoe UI", 13F);
            Label_Name.ForeColor = SystemColors.ButtonHighlight;
            Label_Name.Location = new Point(42, 132);
            Label_Name.Name = "Label_Name";
            Label_Name.Size = new Size(59, 25);
            Label_Name.TabIndex = 11;
            Label_Name.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Label_ID
            // 
            Label_ID.AutoSize = true;
            Label_ID.Font = new Font("Segoe UI", 13F);
            Label_ID.ForeColor = SystemColors.ButtonHighlight;
            Label_ID.Location = new Point(60, 85);
            Label_ID.Name = "Label_ID";
            Label_ID.Size = new Size(30, 25);
            Label_ID.TabIndex = 3;
            Label_ID.Text = "ID";
            Label_ID.Click += label1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(375, 28);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "OutSourced";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(210, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(74, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "In-House";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // AddPartLabel
            // 
            AddPartLabel.AutoSize = true;
            AddPartLabel.Font = new Font("Segoe UI", 15F);
            AddPartLabel.ForeColor = SystemColors.ButtonHighlight;
            AddPartLabel.Location = new Point(13, 19);
            AddPartLabel.Name = "AddPartLabel";
            AddPartLabel.Size = new Size(88, 28);
            AddPartLabel.TabIndex = 0;
            AddPartLabel.Text = "Add Part";
            AddPartLabel.Click += AddPartLabel_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox11);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox12);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox13);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox14);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton4);
            panel2.Controls.Add(Label_Modify);
            panel2.Location = new Point(-1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 393);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(554, 330);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 24;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(456, 330);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(477, 132);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(64, 23);
            textBox8.TabIndex = 22;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(386, 129);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 21;
            label1.Text = "Max";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(477, 87);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(64, 23);
            textBox9.TabIndex = 20;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(386, 84);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 19;
            label2.Text = "Min";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(179, 269);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(182, 23);
            textBox10.TabIndex = 18;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(26, 266);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 17;
            label3.Text = "Machine ID";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(179, 224);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(182, 23);
            textBox11.TabIndex = 16;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(49, 221);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 15;
            label4.Text = "Price";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(179, 178);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(182, 23);
            textBox12.TabIndex = 14;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(31, 178);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 13;
            label5.Text = "Inventory";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(179, 131);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(182, 23);
            textBox13.TabIndex = 12;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(49, 132);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 11;
            label6.Text = "Name";
            // 
            // textBox14
            // 
            textBox14.BackColor = SystemColors.ScrollBar;
            textBox14.BorderStyle = BorderStyle.FixedSingle;
            textBox14.Location = new Point(179, 87);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(182, 23);
            textBox14.TabIndex = 10;
            textBox14.TextChanged += textBox14_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(68, 87);
            label7.Name = "label7";
            label7.Size = new Size(30, 25);
            label7.TabIndex = 3;
            label7.Text = "ID";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = SystemColors.ButtonHighlight;
            radioButton3.Location = new Point(375, 28);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(88, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "OutSourced";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.ForeColor = SystemColors.ButtonHighlight;
            radioButton4.Location = new Point(210, 28);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(74, 19);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "In-House";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // Label_Modify
            // 
            Label_Modify.AutoSize = true;
            Label_Modify.Font = new Font("Segoe UI", 15F);
            Label_Modify.ForeColor = SystemColors.ButtonHighlight;
            Label_Modify.Location = new Point(13, 19);
            Label_Modify.Name = "Label_Modify";
            Label_Modify.Size = new Size(114, 28);
            Label_Modify.TabIndex = 0;
            Label_Modify.Text = "Modify Part";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 388);
            Controls.Add(panel2);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private Label AddPartLabel;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label Label_ID;
        private TextBox textBox1;
        private TextBox textBoxMax;
        private Label Label_Max;
        private TextBox textBox_Min;
        private Label Label_Min;
        private TextBox textBox5;
        private Label Label_MachID;
        private TextBox textBox_Price;
        private Label Label_Price;
        private TextBox textBox3;
        private Label Label_Inv;
        private TextBox textBox_Name;
        private Label Label_Name;
        private Button Button_Cancel;
        private Button Button_Save;
        public Panel panel2;
        private Button button1;
        private Button button2;
        private TextBox textBox8;
        private Label label1;
        private TextBox textBox9;
        private Label label2;
        private TextBox textBox10;
        private Label label3;
        private TextBox textBox11;
        private Label label4;
        private TextBox textBox12;
        private Label label5;
        private TextBox textBox13;
        private Label label6;
        private TextBox textBox14;
        private Label label7;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label Label_Modify;
    }
}