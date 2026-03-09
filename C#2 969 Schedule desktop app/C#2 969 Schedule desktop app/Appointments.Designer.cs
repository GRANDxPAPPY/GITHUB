namespace C_2_969_Schedule_desktop_app
{
    partial class Appointments
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
            this.addupdateAppointmentLabel = new System.Windows.Forms.Label();
            this.appointmentTypeLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.AppointmentTypeTextbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.UpdateApointmentButton = new System.Windows.Forms.Button();
            this.deleteAppoinmentUpdateButton = new System.Windows.Forms.Button();
            this.timeAppointmentLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.HourMinutesPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addupdateAppointmentLabel
            // 
            this.addupdateAppointmentLabel.AutoSize = true;
            this.addupdateAppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addupdateAppointmentLabel.Location = new System.Drawing.Point(12, 9);
            this.addupdateAppointmentLabel.Name = "addupdateAppointmentLabel";
            this.addupdateAppointmentLabel.Size = new System.Drawing.Size(360, 39);
            this.addupdateAppointmentLabel.TabIndex = 0;
            this.addupdateAppointmentLabel.Text = "Schedule Appointment";
            // 
            // appointmentTypeLabel
            // 
            this.appointmentTypeLabel.AutoSize = true;
            this.appointmentTypeLabel.Location = new System.Drawing.Point(16, 83);
            this.appointmentTypeLabel.Name = "appointmentTypeLabel";
            this.appointmentTypeLabel.Size = new System.Drawing.Size(93, 13);
            this.appointmentTypeLabel.TabIndex = 1;
            this.appointmentTypeLabel.Text = "Appointment Type";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(16, 133);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 3;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // AppointmentTypeTextbox
            // 
            this.AppointmentTypeTextbox.Location = new System.Drawing.Point(134, 76);
            this.AppointmentTypeTextbox.Name = "AppointmentTypeTextbox";
            this.AppointmentTypeTextbox.Size = new System.Drawing.Size(219, 20);
            this.AppointmentTypeTextbox.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.Location = new System.Drawing.Point(503, 73);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.addAppointmentButton.TabIndex = 7;
            this.addAppointmentButton.Text = "Add";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            this.addAppointmentButton.Click += new System.EventHandler(this.addAppointmentButton_Click);
            // 
            // UpdateApointmentButton
            // 
            this.UpdateApointmentButton.Location = new System.Drawing.Point(503, 133);
            this.UpdateApointmentButton.Name = "UpdateApointmentButton";
            this.UpdateApointmentButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateApointmentButton.TabIndex = 8;
            this.UpdateApointmentButton.Text = "Update";
            this.UpdateApointmentButton.UseVisualStyleBackColor = true;
            // 
            // deleteAppoinmentUpdateButton
            // 
            this.deleteAppoinmentUpdateButton.Location = new System.Drawing.Point(503, 186);
            this.deleteAppoinmentUpdateButton.Name = "deleteAppoinmentUpdateButton";
            this.deleteAppoinmentUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.deleteAppoinmentUpdateButton.TabIndex = 9;
            this.deleteAppoinmentUpdateButton.Text = "Delete";
            this.deleteAppoinmentUpdateButton.UseVisualStyleBackColor = true;
            this.deleteAppoinmentUpdateButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // timeAppointmentLabel
            // 
            this.timeAppointmentLabel.AutoSize = true;
            this.timeAppointmentLabel.Location = new System.Drawing.Point(41, 185);
            this.timeAppointmentLabel.Name = "timeAppointmentLabel";
            this.timeAppointmentLabel.Size = new System.Drawing.Size(30, 13);
            this.timeAppointmentLabel.TabIndex = 11;
            this.timeAppointmentLabel.Text = "Time";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(659, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(685, 354);
            this.dataGridView1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // HourMinutesPicker
            // 
            this.HourMinutesPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HourMinutesPicker.Location = new System.Drawing.Point(343, 185);
            this.HourMinutesPicker.Name = "HourMinutesPicker";
            this.HourMinutesPicker.ShowUpDown = true;
            this.HourMinutesPicker.Size = new System.Drawing.Size(77, 20);
            this.HourMinutesPicker.TabIndex = 14;
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1374, 527);
            this.Controls.Add(this.HourMinutesPicker);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.timeAppointmentLabel);
            this.Controls.Add(this.deleteAppoinmentUpdateButton);
            this.Controls.Add(this.UpdateApointmentButton);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AppointmentTypeTextbox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.appointmentTypeLabel);
            this.Controls.Add(this.addupdateAppointmentLabel);
            this.Name = "Appointments";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Appointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addupdateAppointmentLabel;
        private System.Windows.Forms.Label appointmentTypeLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox AppointmentTypeTextbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Button UpdateApointmentButton;
        private System.Windows.Forms.Button deleteAppoinmentUpdateButton;
        private System.Windows.Forms.Label timeAppointmentLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker HourMinutesPicker;
    }
}