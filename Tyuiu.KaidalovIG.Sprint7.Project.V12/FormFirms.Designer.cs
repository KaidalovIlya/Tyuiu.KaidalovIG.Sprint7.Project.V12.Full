
namespace Tyuiu.KaidalovIG.Sprint7.Project.V12
{
    partial class FormFirma_KIG
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
            this.dataGridViewFirms_KIG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirms_KIG)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFirms_KIG
            // 
            this.dataGridViewFirms_KIG.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFirms_KIG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFirms_KIG.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewFirms_KIG.Name = "dataGridViewFirms_KIG";
            this.dataGridViewFirms_KIG.Size = new System.Drawing.Size(609, 345);
            this.dataGridViewFirms_KIG.TabIndex = 0;
            this.dataGridViewFirms_KIG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFirms_KIG_CellContentClick);
            // 
            // FormFirma_KIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 369);
            this.Controls.Add(this.dataGridViewFirms_KIG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFirma_KIG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Существующие фирмы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirms_KIG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFirms_KIG;
    }
}