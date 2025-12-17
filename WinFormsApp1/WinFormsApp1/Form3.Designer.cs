namespace WinFormsApp1
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            Label_BotGrid = new Label();
            dataGridView2 = new DataGridView();
            Label_TopGrid = new Label();
            dataGridView1 = new DataGridView();
            Button_Cancel = new Button();
            Button_Save = new Button();
            textBox6 = new TextBox();
            Label_Max = new Label();
            textBox7 = new TextBox();
            Label_Min = new Label();
            textBox4 = new TextBox();
            Label_Price = new Label();
            textBox3 = new TextBox();
            Label_Inv = new Label();
            textBox2 = new TextBox();
            Label_Name = new Label();
            textBox1 = new TextBox();
            Label_ID = new Label();
            AddPartLabel = new Label();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView3 = new DataGridView();
            label2 = new Label();
            dataGridView4 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            textBox8 = new TextBox();
            label3 = new Label();
            textBox9 = new TextBox();
            label4 = new Label();
            textBox10 = new TextBox();
            label5 = new Label();
            textBox11 = new TextBox();
            label6 = new Label();
            textBox12 = new TextBox();
            label7 = new Label();
            textBox13 = new TextBox();
            label8 = new Label();
            Label_ModifyPage = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(Label_BotGrid);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(Label_TopGrid);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(Button_Cancel);
            panel1.Controls.Add(Button_Save);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(Label_Max);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(Label_Min);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(Label_Price);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(Label_Inv);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(Label_Name);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Label_ID);
            panel1.Controls.Add(AddPartLabel);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 655);
            panel1.TabIndex = 1;
            // 
            // Label_BotGrid
            // 
            Label_BotGrid.AutoSize = true;
            Label_BotGrid.Font = new Font("Segoe UI", 15F);
            Label_BotGrid.ForeColor = SystemColors.ButtonHighlight;
            Label_BotGrid.Location = new Point(499, 316);
            Label_BotGrid.Name = "Label_BotGrid";
            Label_BotGrid.Size = new Size(153, 28);
            Label_BotGrid.TabIndex = 30;
            Label_BotGrid.Text = "Associated Parts";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2.Location = new Point(499, 347);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(657, 220);
            dataGridView2.TabIndex = 29;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Label_TopGrid
            // 
            Label_TopGrid.AutoSize = true;
            Label_TopGrid.Font = new Font("Segoe UI", 15F);
            Label_TopGrid.ForeColor = SystemColors.ButtonHighlight;
            Label_TopGrid.Location = new Point(499, 56);
            Label_TopGrid.Name = "Label_TopGrid";
            Label_TopGrid.Size = new Size(82, 28);
            Label_TopGrid.TabIndex = 28;
            Label_TopGrid.Text = "All Parts";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(499, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(657, 220);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Button_Cancel
            // 
            Button_Cancel.Location = new Point(1030, 597);
            Button_Cancel.Name = "Button_Cancel";
            Button_Cancel.Size = new Size(75, 23);
            Button_Cancel.TabIndex = 24;
            Button_Cancel.Text = "Cancel";
            Button_Cancel.UseVisualStyleBackColor = true;
            Button_Cancel.Click += Button_Cancel_Click;
            // 
            // Button_Save
            // 
            Button_Save.Location = new Point(917, 597);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(75, 23);
            Button_Save.TabIndex = 23;
            Button_Save.Text = "Save";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Button_Save_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(330, 296);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(64, 23);
            textBox6.TabIndex = 22;
            // 
            // Label_Max
            // 
            Label_Max.AutoSize = true;
            Label_Max.Font = new Font("Segoe UI", 13F);
            Label_Max.ForeColor = SystemColors.ButtonHighlight;
            Label_Max.Location = new Point(239, 293);
            Label_Max.Name = "Label_Max";
            Label_Max.Size = new Size(45, 25);
            Label_Max.TabIndex = 21;
            Label_Max.Text = "Max";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(150, 296);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(64, 23);
            textBox7.TabIndex = 20;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // Label_Min
            // 
            Label_Min.AutoSize = true;
            Label_Min.Font = new Font("Segoe UI", 13F);
            Label_Min.ForeColor = SystemColors.ButtonHighlight;
            Label_Min.Location = new Point(59, 293);
            Label_Min.Name = "Label_Min";
            Label_Min.Size = new Size(42, 25);
            Label_Min.TabIndex = 19;
            Label_Min.Text = "Min";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(179, 224);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 23);
            textBox4.TabIndex = 16;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Label_Price
            // 
            Label_Price.AutoSize = true;
            Label_Price.Font = new Font("Segoe UI", 13F);
            Label_Price.ForeColor = SystemColors.ButtonHighlight;
            Label_Price.Location = new Point(88, 221);
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
            Label_Inv.Location = new Point(73, 178);
            Label_Inv.Name = "Label_Inv";
            Label_Inv.Size = new Size(87, 25);
            Label_Inv.TabIndex = 13;
            Label_Inv.Text = "Inventory";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Label_Name
            // 
            Label_Name.AutoSize = true;
            Label_Name.Font = new Font("Segoe UI", 13F);
            Label_Name.ForeColor = SystemColors.ButtonHighlight;
            Label_Name.Location = new Point(78, 130);
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
            Label_ID.Location = new Point(88, 84);
            Label_ID.Name = "Label_ID";
            Label_ID.Size = new Size(30, 25);
            Label_ID.TabIndex = 3;
            Label_ID.Text = "ID";
            // 
            // AddPartLabel
            // 
            AddPartLabel.AutoSize = true;
            AddPartLabel.Font = new Font("Segoe UI", 15F);
            AddPartLabel.ForeColor = SystemColors.ButtonHighlight;
            AddPartLabel.Location = new Point(30, 19);
            AddPartLabel.Name = "AddPartLabel";
            AddPartLabel.Size = new Size(123, 28);
            AddPartLabel.TabIndex = 0;
            AddPartLabel.Text = "Add Product";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dataGridView4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox11);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox12);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox13);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(Label_ModifyPage);
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1159, 655);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(499, 316);
            label1.Name = "label1";
            label1.Size = new Size(153, 28);
            label1.TabIndex = 30;
            label1.Text = "Associated Parts";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView3.Location = new Point(499, 347);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(657, 220);
            dataGridView3.TabIndex = 29;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(499, 56);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 28;
            label2.Text = "All Parts";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView4.Location = new Point(499, 87);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(657, 220);
            dataGridView4.TabIndex = 25;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(1030, 597);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 24;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(920, 597);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 23;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(330, 296);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(64, 23);
            textBox8.TabIndex = 22;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(239, 293);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 21;
            label3.Text = "Max";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(150, 296);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(64, 23);
            textBox9.TabIndex = 20;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(59, 293);
            label4.Name = "label4";
            label4.Size = new Size(42, 25);
            label4.TabIndex = 19;
            label4.Text = "Min";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(179, 224);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(182, 23);
            textBox10.TabIndex = 16;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(88, 221);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 15;
            label5.Text = "Price";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(179, 178);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(182, 23);
            textBox11.TabIndex = 14;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(73, 178);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 13;
            label6.Text = "Inventory";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(179, 131);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(182, 23);
            textBox12.TabIndex = 12;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(78, 130);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 11;
            label7.Text = "Name";
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.DarkGray;
            textBox13.Location = new Point(179, 87);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(182, 23);
            textBox13.TabIndex = 10;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(88, 84);
            label8.Name = "label8";
            label8.Size = new Size(30, 25);
            label8.TabIndex = 3;
            label8.Text = "ID";
            // 
            // Label_ModifyPage
            // 
            Label_ModifyPage.AutoSize = true;
            Label_ModifyPage.Font = new Font("Segoe UI", 15F);
            Label_ModifyPage.ForeColor = SystemColors.ButtonHighlight;
            Label_ModifyPage.Location = new Point(30, 19);
            Label_ModifyPage.Name = "Label_ModifyPage";
            Label_ModifyPage.Size = new Size(149, 28);
            Label_ModifyPage.TabIndex = 0;
            Label_ModifyPage.Text = "Modify Product";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 654);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private Button Button_Cancel;
        private Button Button_Save;
        private TextBox textBox6;
        private Label Label_Max;
        private TextBox textBox7;
        private Label Label_Min;
        private TextBox textBox4;
        private Label Label_Price;
        private TextBox textBox3;
        private Label Label_Inv;
        private TextBox textBox2;
        private Label Label_Name;
        private TextBox textBox1;
        private Label Label_ID;
        private Label AddPartLabel;
        private Label Label_BotGrid;
        private DataGridView dataGridView2;
        private Label Label_TopGrid;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        public Panel panel2;
        private Label label1;
        private DataGridView dataGridView3;
        private Label label2;
        private DataGridView dataGridView4;
        private Button button3;
        private Button button4;
        private TextBox textBox8;
        private Label label3;
        private TextBox textBox9;
        private Label label4;
        private TextBox textBox10;
        private Label label5;
        private TextBox textBox11;
        private Label label6;
        private TextBox textBox12;
        private Label label7;
        private TextBox textBox13;
        private Label label8;
        private Label Label_ModifyPage;
    }
}