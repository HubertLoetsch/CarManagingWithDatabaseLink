namespace CsrRentaaApp
{
    partial class AddRentalRecord
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRented = new System.Windows.Forms.DateTimePicker();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpReturned = new System.Windows.Forms.DateTimePicker();
            this.cbTypeofCar = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.masterDataSet = new CsrRentaaApp.masterDataSet();
            this.zooBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zooTableAdapter = new CsrRentaaApp.masterDataSetTableAdapters.ZooTableAdapter();
            this.masterDataSet1 = new CsrRentaaApp.masterDataSet();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.carRentalDataSet = new CsrRentaaApp.CarRentalDataSet();
            this.carRentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalDataSet1 = new CsrRentaaApp.CarRentalDataSet();
            this.carRentalDataSet2 = new CsrRentaaApp.CarRentalDataSet();
            this.carRentalRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalRecordTableAdapter = new CsrRentaaApp.CarRentalDataSetTableAdapters.CarRentalRecordTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 22F);
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Rental System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "CustomerName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Rented";
            // 
            // dtpRented
            // 
            this.dtpRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpRented.Location = new System.Drawing.Point(16, 227);
            this.dtpRented.Name = "dtpRented";
            this.dtpRented.Size = new System.Drawing.Size(200, 26);
            this.dtpRented.TabIndex = 3;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCustomer.Location = new System.Drawing.Point(16, 137);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(216, 26);
            this.tbCustomer.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(12, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type of Car";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(390, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date Returned";
            // 
            // dtpReturned
            // 
            this.dtpReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpReturned.Location = new System.Drawing.Point(394, 227);
            this.dtpReturned.Name = "dtpReturned";
            this.dtpReturned.Size = new System.Drawing.Size(200, 26);
            this.dtpReturned.TabIndex = 7;
            // 
            // cbTypeofCar
            // 
            this.cbTypeofCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTypeofCar.FormattingEnabled = true;
            this.cbTypeofCar.Location = new System.Drawing.Point(16, 320);
            this.cbTypeofCar.Name = "cbTypeofCar";
            this.cbTypeofCar.Size = new System.Drawing.Size(200, 28);
            this.cbTypeofCar.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(394, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 102);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zooBindingSource
            // 
            this.zooBindingSource.DataMember = "Zoo";
            this.zooBindingSource.DataSource = this.masterDataSet;
            // 
            // zooTableAdapter
            // 
            this.zooTableAdapter.ClearBeforeFill = true;
            // 
            // masterDataSet1
            // 
            this.masterDataSet1.DataSetName = "masterDataSet";
            this.masterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCost.Location = new System.Drawing.Point(394, 137);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(216, 26);
            this.tbCost.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(390, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cost ";
            // 
            // carRentalDataSet
            // 
            this.carRentalDataSet.DataSetName = "CarRentalDataSet";
            this.carRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carRentalDataSetBindingSource
            // 
            this.carRentalDataSetBindingSource.DataSource = this.carRentalDataSet;
            this.carRentalDataSetBindingSource.Position = 0;
            // 
            // carRentalDataSet1
            // 
            this.carRentalDataSet1.DataSetName = "CarRentalDataSet";
            this.carRentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carRentalDataSet2
            // 
            this.carRentalDataSet2.DataSetName = "CarRentalDataSet";
            this.carRentalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carRentalRecordBindingSource
            // 
            this.carRentalRecordBindingSource.DataMember = "CarRentalRecord";
            this.carRentalRecordBindingSource.DataSource = this.carRentalDataSetBindingSource;
            // 
            // carRentalRecordTableAdapter
            // 
            this.carRentalRecordTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Himalaya", 20F);
            this.button2.Location = new System.Drawing.Point(19, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 71);
            this.button2.TabIndex = 12;
            this.button2.Text = "Launch Main Window";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(635, 471);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTypeofCar);
            this.Controls.Add(this.dtpReturned);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.dtpRented);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Himalaya", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Test#";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalRecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpRented;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpReturned;
        private System.Windows.Forms.ComboBox cbTypeofCar;
        private System.Windows.Forms.Button button1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource zooBindingSource;
        private masterDataSetTableAdapters.ZooTableAdapter zooTableAdapter;
        private masterDataSet masterDataSet1;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label6;
        private CarRentalDataSet carRentalDataSet;
        private System.Windows.Forms.BindingSource carRentalDataSetBindingSource;
        private CarRentalDataSet carRentalDataSet1;
        private CarRentalDataSet carRentalDataSet2;
        private System.Windows.Forms.BindingSource carRentalRecordBindingSource;
        private CarRentalDataSetTableAdapters.CarRentalRecordTableAdapter carRentalRecordTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}

