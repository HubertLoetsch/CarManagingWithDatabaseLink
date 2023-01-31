namespace CsrRentaaApp
{
    partial class ManageVehile_Listing
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
            this.carRentalDataSet = new CsrRentaaApp.CarRentalDataSet();
            this.carRentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carRentalRecordTableAdapter = new CsrRentaaApp.CarRentalDataSetTableAdapters.CarRentalRecordTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.gvVehicleList = new System.Windows.Forms.DataGridView();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).BeginInit();
            this.SuspendLayout();
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
            // carRentalRecordBindingSource
            // 
            this.carRentalRecordBindingSource.DataMember = "CarRentalRecord";
            this.carRentalRecordBindingSource.DataSource = this.carRentalDataSetBindingSource;
            // 
            // carRentalRecordTableAdapter
            // 
            this.carRentalRecordTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Vehicle Listing";
            // 
            // gvVehicleList
            // 
            this.gvVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVehicleList.Location = new System.Drawing.Point(27, 57);
            this.gvVehicleList.Name = "gvVehicleList";
            this.gvVehicleList.Size = new System.Drawing.Size(282, 381);
            this.gvVehicleList.TabIndex = 2;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(484, 105);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(125, 53);
            this.btnAddCar.TabIndex = 3;
            this.btnAddCar.Text = "Add New Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(484, 196);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(125, 53);
            this.btnEditCar.TabIndex = 4;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(484, 275);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(125, 53);
            this.btnDeleteCar.TabIndex = 5;
            this.btnDeleteCar.Text = "DeleteCar";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // ManageVehile_Listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.gvVehicleList);
            this.Controls.Add(this.label1);
            this.Name = "ManageVehile_Listing";
            this.Text = "ManageVehile_Listing";
            this.Load += new System.EventHandler(this.ManageVehile_Listing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource carRentalDataSetBindingSource;
        private CarRentalDataSet carRentalDataSet;
        private System.Windows.Forms.BindingSource carRentalRecordBindingSource;
        private CarRentalDataSetTableAdapters.CarRentalRecordTableAdapter carRentalRecordTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvVehicleList;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
    }
}