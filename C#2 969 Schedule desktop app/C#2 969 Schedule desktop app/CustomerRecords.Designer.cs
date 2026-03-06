namespace C_2_969_Schedule_desktop_app
{
    partial class CustomerRecords
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
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.customerRecordsLabel = new System.Windows.Forms.Label();
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.customerAddressTextbox = new System.Windows.Forms.TextBox();
            this.addUserRecordButton = new System.Windows.Forms.Button();
            this.updateUserRecordButton = new System.Windows.Forms.Button();
            this.deleteUserRecordButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerPhoneNumberTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(91, 124);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(77, 26);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Name:";
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressLabel.Location = new System.Drawing.Point(91, 161);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(98, 26);
            this.customerAddressLabel.TabIndex = 1;
            this.customerAddressLabel.Text = "Address:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(91, 203);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(81, 26);
            this.phoneNumberLabel.TabIndex = 2;
            this.phoneNumberLabel.Text = "Phone:";
            // 
            // customerRecordsLabel
            // 
            this.customerRecordsLabel.AutoSize = true;
            this.customerRecordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerRecordsLabel.Location = new System.Drawing.Point(55, 25);
            this.customerRecordsLabel.Name = "customerRecordsLabel";
            this.customerRecordsLabel.Size = new System.Drawing.Size(300, 39);
            this.customerRecordsLabel.TabIndex = 3;
            this.customerRecordsLabel.Text = "Customer Records";
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Location = new System.Drawing.Point(226, 124);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(250, 20);
            this.customerNameTextbox.TabIndex = 4;
            // 
            // customerAddressTextbox
            // 
            this.customerAddressTextbox.Location = new System.Drawing.Point(226, 167);
            this.customerAddressTextbox.Name = "customerAddressTextbox";
            this.customerAddressTextbox.Size = new System.Drawing.Size(250, 20);
            this.customerAddressTextbox.TabIndex = 5;
            // 
            // addUserRecordButton
            // 
            this.addUserRecordButton.Location = new System.Drawing.Point(537, 121);
            this.addUserRecordButton.Name = "addUserRecordButton";
            this.addUserRecordButton.Size = new System.Drawing.Size(75, 23);
            this.addUserRecordButton.TabIndex = 11;
            this.addUserRecordButton.Text = "Add";
            this.addUserRecordButton.UseVisualStyleBackColor = true;
            this.addUserRecordButton.Click += new System.EventHandler(this.addUserRecordButton_Click);
            // 
            // updateUserRecordButton
            // 
            this.updateUserRecordButton.Location = new System.Drawing.Point(537, 161);
            this.updateUserRecordButton.Name = "updateUserRecordButton";
            this.updateUserRecordButton.Size = new System.Drawing.Size(75, 23);
            this.updateUserRecordButton.TabIndex = 12;
            this.updateUserRecordButton.Text = "Update";
            this.updateUserRecordButton.UseVisualStyleBackColor = true;
            this.updateUserRecordButton.Click += new System.EventHandler(this.updateUserRecordButton_Click);
            // 
            // deleteUserRecordButton
            // 
            this.deleteUserRecordButton.Location = new System.Drawing.Point(537, 209);
            this.deleteUserRecordButton.Name = "deleteUserRecordButton";
            this.deleteUserRecordButton.Size = new System.Drawing.Size(75, 23);
            this.deleteUserRecordButton.TabIndex = 13;
            this.deleteUserRecordButton.Text = "Delete";
            this.deleteUserRecordButton.UseVisualStyleBackColor = true;
            this.deleteUserRecordButton.Click += new System.EventHandler(this.deleteUserRecordButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(770, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(689, 443);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerPhoneNumberTextbox
            // 
            this.customerPhoneNumberTextbox.Location = new System.Drawing.Point(226, 209);
            this.customerPhoneNumberTextbox.Name = "customerPhoneNumberTextbox";
            this.customerPhoneNumberTextbox.Size = new System.Drawing.Size(250, 20);
            this.customerPhoneNumberTextbox.TabIndex = 6;
            // 
            // CustomerRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1505, 634);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteUserRecordButton);
            this.Controls.Add(this.updateUserRecordButton);
            this.Controls.Add(this.addUserRecordButton);
            this.Controls.Add(this.customerPhoneNumberTextbox);
            this.Controls.Add(this.customerAddressTextbox);
            this.Controls.Add(this.customerNameTextbox);
            this.Controls.Add(this.customerRecordsLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.customerAddressLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Name = "CustomerRecords";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CustomerRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label customerRecordsLabel;
        private System.Windows.Forms.TextBox customerNameTextbox;
        private System.Windows.Forms.TextBox customerAddressTextbox;
        private System.Windows.Forms.Button addUserRecordButton;
        private System.Windows.Forms.Button updateUserRecordButton;
        private System.Windows.Forms.Button deleteUserRecordButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox customerPhoneNumberTextbox;
    }
}