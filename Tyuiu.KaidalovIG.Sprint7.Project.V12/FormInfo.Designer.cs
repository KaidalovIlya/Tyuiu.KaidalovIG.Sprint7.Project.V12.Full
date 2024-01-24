
namespace Tyuiu.KaidalovIG.Sprint7.Project.V12
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.labelInfo_KIG = new System.Windows.Forms.Label();
            this.buttonClose_KIG = new System.Windows.Forms.Button();
            this.pictureBoxME_KIG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxME_KIG)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_KIG
            // 
            this.labelInfo_KIG.AutoSize = true;
            this.labelInfo_KIG.Location = new System.Drawing.Point(107, 9);
            this.labelInfo_KIG.Name = "labelInfo_KIG";
            this.labelInfo_KIG.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_KIG.TabIndex = 0;
            this.labelInfo_KIG.Text = "Разработчик: Кайдалов И.Г.\r\nГруппа СМАРТб-23-1\r\n\r\nПрограмма разработана в рамках " +
    "изучения языка C#\r\n\r\nТюменский индустриальный университет (с) 2024\r\nВысшая школа" +
    " цифровых технологий (с) 2024\r\n\r\n\r\n";
            // 
            // buttonClose_KIG
            // 
            this.buttonClose_KIG.Location = new System.Drawing.Point(288, 114);
            this.buttonClose_KIG.Name = "buttonClose_KIG";
            this.buttonClose_KIG.Size = new System.Drawing.Size(94, 35);
            this.buttonClose_KIG.TabIndex = 1;
            this.buttonClose_KIG.Text = "OK";
            this.buttonClose_KIG.UseVisualStyleBackColor = true;
            this.buttonClose_KIG.Click += new System.EventHandler(this.buttonClose_KIG_Click);
            // 
            // pictureBoxME_KIG
            // 
            this.pictureBoxME_KIG.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxME_KIG.Image")));
            this.pictureBoxME_KIG.Location = new System.Drawing.Point(9, 10);
            this.pictureBoxME_KIG.Name = "pictureBoxME_KIG";
            this.pictureBoxME_KIG.Size = new System.Drawing.Size(82, 139);
            this.pictureBoxME_KIG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxME_KIG.TabIndex = 2;
            this.pictureBoxME_KIG.TabStop = false;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 161);
            this.Controls.Add(this.pictureBoxME_KIG);
            this.Controls.Add(this.buttonClose_KIG);
            this.Controls.Add(this.labelInfo_KIG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxME_KIG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_KIG;
        private System.Windows.Forms.Button buttonClose_KIG;
        private System.Windows.Forms.PictureBox pictureBoxME_KIG;
    }
}