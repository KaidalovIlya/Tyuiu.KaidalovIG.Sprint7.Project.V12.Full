
namespace Tyuiu.KaidalovIG.Sprint7.Project.V12
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonSave_KIG = new System.Windows.Forms.Button();
            this.panelDown_KIG = new System.Windows.Forms.Panel();
            this.buttonSortData_KIG = new System.Windows.Forms.Button();
            this.buttonSortAlp_KIG = new System.Windows.Forms.Button();
            this.buttonStat_KIG = new System.Windows.Forms.Button();
            this.buttonInfoMe_KIG = new System.Windows.Forms.Button();
            this.groupBoxData_KIG = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_KIG = new System.Windows.Forms.DataGridView();
            this.buttonAdd_KIG = new System.Windows.Forms.Button();
            this.groupBoxSearch_KIG = new System.Windows.Forms.GroupBox();
            this.textBoxFind_KIG = new System.Windows.Forms.TextBox();
            this.buttonFirma_KIG = new System.Windows.Forms.Button();
            this.saveFileDialog_KIG = new System.Windows.Forms.SaveFileDialog();
            this.toolTip_KIG = new System.Windows.Forms.ToolTip(this.components);
            this.panelDown_KIG.SuspendLayout();
            this.groupBoxData_KIG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KIG)).BeginInit();
            this.groupBoxSearch_KIG.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave_KIG
            // 
            this.buttonSave_KIG.BackColor = System.Drawing.Color.Gray;
            this.buttonSave_KIG.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_KIG.Location = new System.Drawing.Point(684, 29);
            this.buttonSave_KIG.Name = "buttonSave_KIG";
            this.buttonSave_KIG.Size = new System.Drawing.Size(104, 59);
            this.buttonSave_KIG.TabIndex = 5;
            this.buttonSave_KIG.Text = "Сохранить";
            this.toolTip_KIG.SetToolTip(this.buttonSave_KIG, "Сохранение в формате CSV");
            this.buttonSave_KIG.UseVisualStyleBackColor = false;
            this.buttonSave_KIG.Click += new System.EventHandler(this.buttonSave_KIG_Click);
            // 
            // panelDown_KIG
            // 
            this.panelDown_KIG.Controls.Add(this.buttonSortData_KIG);
            this.panelDown_KIG.Controls.Add(this.buttonSortAlp_KIG);
            this.panelDown_KIG.Controls.Add(this.buttonStat_KIG);
            this.panelDown_KIG.Controls.Add(this.buttonSave_KIG);
            this.panelDown_KIG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown_KIG.Location = new System.Drawing.Point(0, 350);
            this.panelDown_KIG.Name = "panelDown_KIG";
            this.panelDown_KIG.Size = new System.Drawing.Size(800, 100);
            this.panelDown_KIG.TabIndex = 1;
            // 
            // buttonSortData_KIG
            // 
            this.buttonSortData_KIG.BackColor = System.Drawing.Color.Gray;
            this.buttonSortData_KIG.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortData_KIG.Location = new System.Drawing.Point(218, 29);
            this.buttonSortData_KIG.Name = "buttonSortData_KIG";
            this.buttonSortData_KIG.Size = new System.Drawing.Size(109, 41);
            this.buttonSortData_KIG.TabIndex = 7;
            this.buttonSortData_KIG.Text = " Отсортировать\r\nпо году выпуска";
            this.buttonSortData_KIG.UseVisualStyleBackColor = false;
            this.buttonSortData_KIG.Click += new System.EventHandler(this.buttonSortData_KIG_Click);
            // 
            // buttonSortAlp_KIG
            // 
            this.buttonSortAlp_KIG.BackColor = System.Drawing.Color.Gray;
            this.buttonSortAlp_KIG.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortAlp_KIG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSortAlp_KIG.Location = new System.Drawing.Point(109, 29);
            this.buttonSortAlp_KIG.Name = "buttonSortAlp_KIG";
            this.buttonSortAlp_KIG.Size = new System.Drawing.Size(103, 41);
            this.buttonSortAlp_KIG.TabIndex = 6;
            this.buttonSortAlp_KIG.Text = "Отсортировать\r\n по алфавиту";
            this.buttonSortAlp_KIG.UseVisualStyleBackColor = false;
            this.buttonSortAlp_KIG.Click += new System.EventHandler(this.buttonSortAlp_KIG_Click);
            // 
            // buttonStat_KIG
            // 
            this.buttonStat_KIG.BackColor = System.Drawing.Color.DarkGray;
            this.buttonStat_KIG.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStat_KIG.Location = new System.Drawing.Point(12, 29);
            this.buttonStat_KIG.Name = "buttonStat_KIG";
            this.buttonStat_KIG.Size = new System.Drawing.Size(91, 39);
            this.buttonStat_KIG.TabIndex = 5;
            this.buttonStat_KIG.Text = "Статистика";
            this.buttonStat_KIG.UseVisualStyleBackColor = false;
            this.buttonStat_KIG.Click += new System.EventHandler(this.buttonStat_KIG_Click);
            // 
            // buttonInfoMe_KIG
            // 
            this.buttonInfoMe_KIG.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonInfoMe_KIG.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfoMe_KIG.Image")));
            this.buttonInfoMe_KIG.Location = new System.Drawing.Point(12, 12);
            this.buttonInfoMe_KIG.Name = "buttonInfoMe_KIG";
            this.buttonInfoMe_KIG.Size = new System.Drawing.Size(42, 45);
            this.buttonInfoMe_KIG.TabIndex = 2;
            this.buttonInfoMe_KIG.UseVisualStyleBackColor = false;
            this.buttonInfoMe_KIG.Click += new System.EventHandler(this.buttonInfoMe_KIG_Click);
            // 
            // groupBoxData_KIG
            // 
            this.groupBoxData_KIG.Controls.Add(this.dataGridViewIn_KIG);
            this.groupBoxData_KIG.Location = new System.Drawing.Point(178, 12);
            this.groupBoxData_KIG.Name = "groupBoxData_KIG";
            this.groupBoxData_KIG.Size = new System.Drawing.Size(622, 332);
            this.groupBoxData_KIG.TabIndex = 3;
            this.groupBoxData_KIG.TabStop = false;
            this.groupBoxData_KIG.Text = "Вводимые данные:";
            // 
            // dataGridViewIn_KIG
            // 
            this.dataGridViewIn_KIG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_KIG.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewIn_KIG.Name = "dataGridViewIn_KIG";
            this.dataGridViewIn_KIG.Size = new System.Drawing.Size(604, 307);
            this.dataGridViewIn_KIG.TabIndex = 0;
            // 
            // buttonAdd_KIG
            // 
            this.buttonAdd_KIG.BackColor = System.Drawing.Color.SlateGray;
            this.buttonAdd_KIG.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd_KIG.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd_KIG.Image")));
            this.buttonAdd_KIG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd_KIG.Location = new System.Drawing.Point(12, 295);
            this.buttonAdd_KIG.Name = "buttonAdd_KIG";
            this.buttonAdd_KIG.Size = new System.Drawing.Size(140, 43);
            this.buttonAdd_KIG.TabIndex = 4;
            this.buttonAdd_KIG.Text = "Добавить CSV";
            this.buttonAdd_KIG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd_KIG.UseVisualStyleBackColor = false;
            this.buttonAdd_KIG.Click += new System.EventHandler(this.buttonAdd_KIG_Click);
            // 
            // groupBoxSearch_KIG
            // 
            this.groupBoxSearch_KIG.Controls.Add(this.textBoxFind_KIG);
            this.groupBoxSearch_KIG.Location = new System.Drawing.Point(12, 63);
            this.groupBoxSearch_KIG.Name = "groupBoxSearch_KIG";
            this.groupBoxSearch_KIG.Size = new System.Drawing.Size(140, 61);
            this.groupBoxSearch_KIG.TabIndex = 4;
            this.groupBoxSearch_KIG.TabStop = false;
            this.groupBoxSearch_KIG.Text = "Поиск по названию";
            // 
            // textBoxFind_KIG
            // 
            this.textBoxFind_KIG.Location = new System.Drawing.Point(6, 19);
            this.textBoxFind_KIG.Name = "textBoxFind_KIG";
            this.textBoxFind_KIG.Size = new System.Drawing.Size(100, 20);
            this.textBoxFind_KIG.TabIndex = 0;
            this.textBoxFind_KIG.TextChanged += new System.EventHandler(this.textBoxFind_KIG_TextChanged);
            // 
            // buttonFirma_KIG
            // 
            this.buttonFirma_KIG.BackColor = System.Drawing.Color.SlateGray;
            this.buttonFirma_KIG.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFirma_KIG.Location = new System.Drawing.Point(12, 247);
            this.buttonFirma_KIG.Name = "buttonFirma_KIG";
            this.buttonFirma_KIG.Size = new System.Drawing.Size(140, 42);
            this.buttonFirma_KIG.TabIndex = 5;
            this.buttonFirma_KIG.Text = "Существующие фирмы";
            this.buttonFirma_KIG.UseVisualStyleBackColor = false;
            this.buttonFirma_KIG.Click += new System.EventHandler(this.buttonFirma_KIG_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFirma_KIG);
            this.Controls.Add(this.groupBoxSearch_KIG);
            this.Controls.Add(this.buttonAdd_KIG);
            this.Controls.Add(this.groupBoxData_KIG);
            this.Controls.Add(this.buttonInfoMe_KIG);
            this.Controls.Add(this.panelDown_KIG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Проект | Вариант 12 | Кайдалов И. Г.";
            this.panelDown_KIG.ResumeLayout(false);
            this.groupBoxData_KIG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KIG)).EndInit();
            this.groupBoxSearch_KIG.ResumeLayout(false);
            this.groupBoxSearch_KIG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSave_KIG;
        private System.Windows.Forms.Panel panelDown_KIG;
        private System.Windows.Forms.Button buttonInfoMe_KIG;
        private System.Windows.Forms.GroupBox groupBoxData_KIG;
        private System.Windows.Forms.DataGridView dataGridViewIn_KIG;
        private System.Windows.Forms.Button buttonAdd_KIG;
        private System.Windows.Forms.GroupBox groupBoxSearch_KIG;
        private System.Windows.Forms.TextBox textBoxFind_KIG;
        private System.Windows.Forms.Button buttonStat_KIG;
        private System.Windows.Forms.Button buttonSortData_KIG;
        private System.Windows.Forms.Button buttonSortAlp_KIG;
        private System.Windows.Forms.Button buttonFirma_KIG;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_KIG;
        private System.Windows.Forms.ToolTip toolTip_KIG;
    }
}

