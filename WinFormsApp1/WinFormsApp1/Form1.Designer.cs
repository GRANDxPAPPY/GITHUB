namespace WinFormsApp1
{
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
            components = new System.ComponentModel.Container();
            SearchButt = new Button();
            AddPageButton = new Button();
            ModPageButt = new Button();
            DeletePageButt = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            bindingSource1 = new BindingSource(components);
            textBox3 = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            Product_Box = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox4 = new PictureBox();
            button5 = new Button();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // SearchButt
            // 
            SearchButt.BackColor = SystemColors.HotTrack;
            SearchButt.BackgroundImageLayout = ImageLayout.None;
            SearchButt.FlatAppearance.BorderSize = 3;
            SearchButt.FlatStyle = FlatStyle.Popup;
            SearchButt.ForeColor = SystemColors.ButtonHighlight;
            SearchButt.Location = new Point(1069, 26);
            SearchButt.Name = "SearchButt";
            SearchButt.Size = new Size(105, 29);
            SearchButt.TabIndex = 0;
            SearchButt.Text = "Search";
            SearchButt.UseVisualStyleBackColor = false;
            SearchButt.Click += button1_Click;
            // 
            // AddPageButton
            // 
            AddPageButton.BackColor = SystemColors.ActiveBorder;
            AddPageButton.Location = new Point(62, 167);
            AddPageButton.Name = "AddPageButton";
            AddPageButton.Size = new Size(158, 29);
            AddPageButton.TabIndex = 1;
            AddPageButton.Text = "Add";
            AddPageButton.UseVisualStyleBackColor = false;
            AddPageButton.Click += button2_Click;
            // 
            // ModPageButt
            // 
            ModPageButt.BackColor = SystemColors.ActiveBorder;
            ModPageButt.ForeColor = SystemColors.ButtonFace;
            ModPageButt.Location = new Point(62, 220);
            ModPageButt.Name = "ModPageButt";
            ModPageButt.Size = new Size(158, 35);
            ModPageButt.TabIndex = 2;
            ModPageButt.Text = "Modify";
            ModPageButt.UseVisualStyleBackColor = false;
            ModPageButt.Click += button3_Click;
            // 
            // DeletePageButt
            // 
            DeletePageButt.BackColor = SystemColors.ActiveBorder;
            DeletePageButt.Location = new Point(62, 279);
            DeletePageButt.Name = "DeletePageButt";
            DeletePageButt.Size = new Size(158, 32);
            DeletePageButt.TabIndex = 3;
            DeletePageButt.Text = "Delete";
            DeletePageButt.UseVisualStyleBackColor = false;
            DeletePageButt.Click += DeletePageButt_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Location = new Point(1220, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1559, 540);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.InactiveCaption;
            pictureBox2.Location = new Point(226, 126);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1134, 364);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.ForeColor = Color.GhostWhite;
            textBox3.Location = new Point(30, 77);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(111, 39);
            textBox3.TabIndex = 10;
            textBox3.Text = "Parts";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(264, 46);
            label1.TabIndex = 13;
            label1.Text = "Capes Part Repo";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Thistle;
            pictureBox3.Location = new Point(0, 533);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1559, 540);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // Product_Box
            // 
            Product_Box.BackColor = Color.Thistle;
            Product_Box.BorderStyle = BorderStyle.None;
            Product_Box.Font = new Font("Segoe UI", 20F);
            Product_Box.ForeColor = Color.GhostWhite;
            Product_Box.Location = new Point(30, 617);
            Product_Box.Multiline = true;
            Product_Box.Name = "Product_Box";
            Product_Box.Size = new Size(111, 39);
            Product_Box.TabIndex = 18;
            Product_Box.Text = "Products";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(86, 701);
            button1.Name = "button1";
            button1.Size = new Size(158, 29);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(86, 756);
            button2.Name = "button2";
            button2.Size = new Size(158, 35);
            button2.TabIndex = 20;
            button2.Text = "Modify";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Location = new Point(86, 823);
            button3.Name = "button3";
            button3.Size = new Size(158, 32);
            button3.TabIndex = 21;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.Location = new Point(86, 1008);
            button4.Name = "button4";
            button4.Size = new Size(158, 31);
            button4.TabIndex = 22;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.InactiveCaption;
            pictureBox4.Location = new Point(250, 675);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1134, 364);
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HotTrack;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(1069, 567);
            button5.Name = "button5";
            button5.Size = new Size(105, 29);
            button5.TabIndex = 31;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ControlText;
            textBox2.Location = new Point(1209, 571);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 23);
            textBox2.TabIndex = 32;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(250, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1099, 333);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView2.Location = new Point(261, 691);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(1099, 333);
            dataGridView2.TabIndex = 34;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1560, 1072);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(pictureBox4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Product_Box);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(DeletePageButt);
            Controls.Add(ModPageButt);
            Controls.Add(AddPageButton);
            Controls.Add(SearchButt);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchButt;
        private Button AddPageButton;
        private Button ModPageButt;
        private Button DeletePageButt;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private BindingSource bindingSource1;
        private TextBox textBox3;
        private Label label1;
        private PictureBox pictureBox3;
        private TextBox Product_Box;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox4;
        private Button button5;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}
