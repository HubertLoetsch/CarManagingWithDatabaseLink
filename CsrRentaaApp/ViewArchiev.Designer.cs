namespace CsrRentaaApp
{
    partial class ViewArchiev
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
            this.gvViewArchiv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvViewArchiv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Archiv";
            // 
            // gvViewArchiv
            // 
            this.gvViewArchiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvViewArchiv.Location = new System.Drawing.Point(13, 81);
            this.gvViewArchiv.Name = "gvViewArchiv";
            this.gvViewArchiv.Size = new System.Drawing.Size(775, 268);
            this.gvViewArchiv.TabIndex = 1;
            // 
            // ViewArchiev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvViewArchiv);
            this.Controls.Add(this.label1);
            this.Name = "ViewArchiev";
            this.Text = "ViewArchiev";
            this.Load += new System.EventHandler(this.ViewArchiev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvViewArchiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvViewArchiv;
    }
}