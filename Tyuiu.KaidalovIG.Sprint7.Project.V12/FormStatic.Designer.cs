
namespace Tyuiu.KaidalovIG.Sprint7.Project.V12
{
    partial class FormStatic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelLeft_KIG = new System.Windows.Forms.Panel();
            this.buttonDiag_KIG = new System.Windows.Forms.Button();
            this.buttonMaxYadra_KIG = new System.Windows.Forms.Button();
            this.buttonSredOZU_KIG = new System.Windows.Forms.Button();
            this.chartstat_KIG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewStat_KIG = new System.Windows.Forms.DataGridView();
            this.textBoxSredOZU_KIG = new System.Windows.Forms.TextBox();
            this.textBoxMaxYadra_KIG = new System.Windows.Forms.TextBox();
            this.openFileDialogStat_KIG = new System.Windows.Forms.OpenFileDialog();
            this.panelLeft_KIG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartstat_KIG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStat_KIG)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft_KIG
            // 
            this.panelLeft_KIG.Controls.Add(this.buttonDiag_KIG);
            this.panelLeft_KIG.Controls.Add(this.buttonMaxYadra_KIG);
            this.panelLeft_KIG.Controls.Add(this.buttonSredOZU_KIG);
            this.panelLeft_KIG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLeft_KIG.Location = new System.Drawing.Point(0, 383);
            this.panelLeft_KIG.Name = "panelLeft_KIG";
            this.panelLeft_KIG.Size = new System.Drawing.Size(542, 67);
            this.panelLeft_KIG.TabIndex = 0;
            // 
            // buttonDiag_KIG
            // 
            this.buttonDiag_KIG.BackColor = System.Drawing.Color.Gray;
            this.buttonDiag_KIG.Location = new System.Drawing.Point(12, 13);
            this.buttonDiag_KIG.Name = "buttonDiag_KIG";
            this.buttonDiag_KIG.Size = new System.Drawing.Size(113, 42);
            this.buttonDiag_KIG.TabIndex = 0;
            this.buttonDiag_KIG.Text = "Диагонали ЭВМ";
            this.buttonDiag_KIG.UseVisualStyleBackColor = false;
            this.buttonDiag_KIG.Click += new System.EventHandler(this.buttonDiag_KIG_Click);
            // 
            // buttonMaxYadra_KIG
            // 
            this.buttonMaxYadra_KIG.BackColor = System.Drawing.Color.Gray;
            this.buttonMaxYadra_KIG.Location = new System.Drawing.Point(417, 13);
            this.buttonMaxYadra_KIG.Name = "buttonMaxYadra_KIG";
            this.buttonMaxYadra_KIG.Size = new System.Drawing.Size(113, 42);
            this.buttonMaxYadra_KIG.TabIndex = 0;
            this.buttonMaxYadra_KIG.Text = "Самое большое кол-во ядер";
            this.buttonMaxYadra_KIG.UseVisualStyleBackColor = false;
            this.buttonMaxYadra_KIG.Click += new System.EventHandler(this.buttonMaxYadra_KIG_Click);
            // 
            // buttonSredOZU_KIG
            // 
            this.buttonSredOZU_KIG.BackColor = System.Drawing.Color.Gray;
            this.buttonSredOZU_KIG.Location = new System.Drawing.Point(217, 13);
            this.buttonSredOZU_KIG.Name = "buttonSredOZU_KIG";
            this.buttonSredOZU_KIG.Size = new System.Drawing.Size(113, 42);
            this.buttonSredOZU_KIG.TabIndex = 0;
            this.buttonSredOZU_KIG.Text = "Среднее значение обьёма памяти";
            this.buttonSredOZU_KIG.UseVisualStyleBackColor = false;
            this.buttonSredOZU_KIG.Click += new System.EventHandler(this.buttonSredOZU_KIG_Click);
            // 
            // chartstat_KIG
            // 
            chartArea1.Name = "ChartArea1";
            this.chartstat_KIG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartstat_KIG.Legends.Add(legend1);
            this.chartstat_KIG.Location = new System.Drawing.Point(21, 12);
            this.chartstat_KIG.Name = "chartstat_KIG";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartstat_KIG.Series.Add(series1);
            this.chartstat_KIG.Size = new System.Drawing.Size(309, 320);
            this.chartstat_KIG.TabIndex = 1;
            // 
            // dataGridViewStat_KIG
            // 
            this.dataGridViewStat_KIG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStat_KIG.Location = new System.Drawing.Point(336, 12);
            this.dataGridViewStat_KIG.Name = "dataGridViewStat_KIG";
            this.dataGridViewStat_KIG.Size = new System.Drawing.Size(194, 123);
            this.dataGridViewStat_KIG.TabIndex = 2;
            // 
            // textBoxSredOZU_KIG
            // 
            this.textBoxSredOZU_KIG.Location = new System.Drawing.Point(217, 348);
            this.textBoxSredOZU_KIG.Name = "textBoxSredOZU_KIG";
            this.textBoxSredOZU_KIG.Size = new System.Drawing.Size(113, 20);
            this.textBoxSredOZU_KIG.TabIndex = 3;
            // 
            // textBoxMaxYadra_KIG
            // 
            this.textBoxMaxYadra_KIG.Location = new System.Drawing.Point(417, 348);
            this.textBoxMaxYadra_KIG.Name = "textBoxMaxYadra_KIG";
            this.textBoxMaxYadra_KIG.Size = new System.Drawing.Size(113, 20);
            this.textBoxMaxYadra_KIG.TabIndex = 3;
            // 
            // openFileDialogStat_KIG
            // 
            this.openFileDialogStat_KIG.FileName = "openFileDialog1";
            // 
            // FormStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.textBoxMaxYadra_KIG);
            this.Controls.Add(this.textBoxSredOZU_KIG);
            this.Controls.Add(this.dataGridViewStat_KIG);
            this.Controls.Add(this.chartstat_KIG);
            this.Controls.Add(this.panelLeft_KIG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormStatic";
            this.Text = "Статистика";
            this.panelLeft_KIG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartstat_KIG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStat_KIG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft_KIG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartstat_KIG;
        private System.Windows.Forms.Button buttonSredOZU_KIG;
        private System.Windows.Forms.DataGridView dataGridViewStat_KIG;
        private System.Windows.Forms.Button buttonDiag_KIG;
        private System.Windows.Forms.Button buttonMaxYadra_KIG;
        private System.Windows.Forms.TextBox textBoxSredOZU_KIG;
        private System.Windows.Forms.TextBox textBoxMaxYadra_KIG;
        private System.Windows.Forms.OpenFileDialog openFileDialogStat_KIG;
    }
}