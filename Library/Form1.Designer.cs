namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnStudentsChange = new System.Windows.Forms.Button();
            this.btnStudentsDelete = new System.Windows.Forms.Button();
            this.btnStudentsAdd = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBooksChange = new System.Windows.Forms.Button();
            this.btnBooksDelete = new System.Windows.Forms.Button();
            this.btnBooksAdd = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnIssuesChange = new System.Windows.Forms.Button();
            this.btnIssuesDelete = new System.Windows.Forms.Button();
            this.btnIssuesAdd = new System.Windows.Forms.Button();
            this.dgvIssues = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.DateTimePicker();
            this.endPeriod = new System.Windows.Forms.DateTimePicker();
            this.startPeriod = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1216, 747);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnStudentsChange);
            this.tabPage1.Controls.Add(this.btnStudentsDelete);
            this.tabPage1.Controls.Add(this.btnStudentsAdd);
            this.tabPage1.Controls.Add(this.dgvStudents);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1200, 700);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnStudentsChange
            // 
            this.btnStudentsChange.BackColor = System.Drawing.Color.Pink;
            this.btnStudentsChange.Location = new System.Drawing.Point(312, 622);
            this.btnStudentsChange.Name = "btnStudentsChange";
            this.btnStudentsChange.Size = new System.Drawing.Size(300, 69);
            this.btnStudentsChange.TabIndex = 3;
            this.btnStudentsChange.Text = "Изменение";
            this.btnStudentsChange.UseVisualStyleBackColor = false;
            this.btnStudentsChange.Click += new System.EventHandler(this.btnStudentsChange_Click);
            // 
            // btnStudentsDelete
            // 
            this.btnStudentsDelete.BackColor = System.Drawing.Color.Khaki;
            this.btnStudentsDelete.Location = new System.Drawing.Point(618, 622);
            this.btnStudentsDelete.Name = "btnStudentsDelete";
            this.btnStudentsDelete.Size = new System.Drawing.Size(300, 69);
            this.btnStudentsDelete.TabIndex = 2;
            this.btnStudentsDelete.Text = "Удалить запись";
            this.btnStudentsDelete.UseVisualStyleBackColor = false;
            this.btnStudentsDelete.Click += new System.EventHandler(this.btnStudentsDelete_Click);
            // 
            // btnStudentsAdd
            // 
            this.btnStudentsAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStudentsAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudentsAdd.Location = new System.Drawing.Point(6, 622);
            this.btnStudentsAdd.Name = "btnStudentsAdd";
            this.btnStudentsAdd.Size = new System.Drawing.Size(300, 69);
            this.btnStudentsAdd.TabIndex = 1;
            this.btnStudentsAdd.Text = "Добавление";
            this.btnStudentsAdd.UseMnemonic = false;
            this.btnStudentsAdd.UseVisualStyleBackColor = false;
            this.btnStudentsAdd.Click += new System.EventHandler(this.btnStudentsAddChange_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(6, 6);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 82;
            this.dgvStudents.RowTemplate.Height = 33;
            this.dgvStudents.Size = new System.Drawing.Size(1188, 610);
            this.dgvStudents.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBooksChange);
            this.tabPage2.Controls.Add(this.btnBooksDelete);
            this.tabPage2.Controls.Add(this.btnBooksAdd);
            this.tabPage2.Controls.Add(this.dgvBooks);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1200, 700);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Книги";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBooksChange
            // 
            this.btnBooksChange.BackColor = System.Drawing.Color.Pink;
            this.btnBooksChange.Location = new System.Drawing.Point(312, 618);
            this.btnBooksChange.Name = "btnBooksChange";
            this.btnBooksChange.Size = new System.Drawing.Size(300, 73);
            this.btnBooksChange.TabIndex = 6;
            this.btnBooksChange.Text = "Изменение";
            this.btnBooksChange.UseVisualStyleBackColor = false;
            this.btnBooksChange.Click += new System.EventHandler(this.btnBooksChange_Click);
            // 
            // btnBooksDelete
            // 
            this.btnBooksDelete.BackColor = System.Drawing.Color.Khaki;
            this.btnBooksDelete.Location = new System.Drawing.Point(618, 618);
            this.btnBooksDelete.Name = "btnBooksDelete";
            this.btnBooksDelete.Size = new System.Drawing.Size(300, 73);
            this.btnBooksDelete.TabIndex = 5;
            this.btnBooksDelete.Text = "Удалить запись";
            this.btnBooksDelete.UseVisualStyleBackColor = false;
            this.btnBooksDelete.Click += new System.EventHandler(this.btnBooksDelete_Click);
            // 
            // btnBooksAdd
            // 
            this.btnBooksAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBooksAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBooksAdd.Location = new System.Drawing.Point(6, 618);
            this.btnBooksAdd.Name = "btnBooksAdd";
            this.btnBooksAdd.Size = new System.Drawing.Size(300, 73);
            this.btnBooksAdd.TabIndex = 4;
            this.btnBooksAdd.Text = "Добавление";
            this.btnBooksAdd.UseVisualStyleBackColor = false;
            this.btnBooksAdd.Click += new System.EventHandler(this.btnBooksAdd_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(6, 6);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 82;
            this.dgvBooks.RowTemplate.Height = 33;
            this.dgvBooks.Size = new System.Drawing.Size(1188, 606);
            this.dgvBooks.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnIssuesChange);
            this.tabPage3.Controls.Add(this.btnIssuesDelete);
            this.tabPage3.Controls.Add(this.btnIssuesAdd);
            this.tabPage3.Controls.Add(this.dgvIssues);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1200, 700);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Регистры";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnIssuesChange
            // 
            this.btnIssuesChange.BackColor = System.Drawing.Color.Pink;
            this.btnIssuesChange.Location = new System.Drawing.Point(312, 615);
            this.btnIssuesChange.Name = "btnIssuesChange";
            this.btnIssuesChange.Size = new System.Drawing.Size(300, 76);
            this.btnIssuesChange.TabIndex = 7;
            this.btnIssuesChange.Text = "Изменение";
            this.btnIssuesChange.UseVisualStyleBackColor = false;
            this.btnIssuesChange.Click += new System.EventHandler(this.btnIssuesChange_Click);
            // 
            // btnIssuesDelete
            // 
            this.btnIssuesDelete.BackColor = System.Drawing.Color.Khaki;
            this.btnIssuesDelete.Location = new System.Drawing.Point(618, 615);
            this.btnIssuesDelete.Name = "btnIssuesDelete";
            this.btnIssuesDelete.Size = new System.Drawing.Size(300, 76);
            this.btnIssuesDelete.TabIndex = 5;
            this.btnIssuesDelete.Text = "Удалить запись";
            this.btnIssuesDelete.UseVisualStyleBackColor = false;
            this.btnIssuesDelete.Click += new System.EventHandler(this.btnIssuesDelete_Click);
            // 
            // btnIssuesAdd
            // 
            this.btnIssuesAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnIssuesAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIssuesAdd.Location = new System.Drawing.Point(6, 615);
            this.btnIssuesAdd.Name = "btnIssuesAdd";
            this.btnIssuesAdd.Size = new System.Drawing.Size(300, 76);
            this.btnIssuesAdd.TabIndex = 4;
            this.btnIssuesAdd.Text = "Добавление";
            this.btnIssuesAdd.UseVisualStyleBackColor = false;
            this.btnIssuesAdd.Click += new System.EventHandler(this.btnIssuesAdd_Click);
            // 
            // dgvIssues
            // 
            this.dgvIssues.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssues.Location = new System.Drawing.Point(6, 6);
            this.dgvIssues.Name = "dgvIssues";
            this.dgvIssues.RowHeadersWidth = 82;
            this.dgvIssues.RowTemplate.Height = 33;
            this.dgvIssues.Size = new System.Drawing.Size(1188, 603);
            this.dgvIssues.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.day);
            this.tabPage4.Controls.Add(this.endPeriod);
            this.tabPage4.Controls.Add(this.startPeriod);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1200, 700);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Диаграмма/отчёты";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Заданный день";
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(55, 245);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(336, 31);
            this.day.TabIndex = 7;
            // 
            // endPeriod
            // 
            this.endPeriod.Location = new System.Drawing.Point(55, 138);
            this.endPeriod.Name = "endPeriod";
            this.endPeriod.Size = new System.Drawing.Size(336, 31);
            this.endPeriod.TabIndex = 6;
            // 
            // startPeriod
            // 
            this.startPeriod.Location = new System.Drawing.Point(55, 49);
            this.startPeriod.Name = "startPeriod";
            this.startPeriod.Size = new System.Drawing.Size(336, 31);
            this.startPeriod.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Конец периода";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Начало периода";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.Location = new System.Drawing.Point(55, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 91);
            this.button2.TabIndex = 2;
            this.button2.Text = "Диаграмма за период";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(448, 34);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(715, 640);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(55, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сформировать отчёт на одну дату";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(55, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(301, 89);
            this.button3.TabIndex = 9;
            this.button3.Text = "Сформировать отчёт за период";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1274, 779);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnStudentsAdd;
        private System.Windows.Forms.Button btnStudentsDelete;
        private System.Windows.Forms.Button btnBooksDelete;
        private System.Windows.Forms.Button btnBooksAdd;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnIssuesDelete;
        private System.Windows.Forms.Button btnIssuesAdd;
        private System.Windows.Forms.DataGridView dgvIssues;
        private System.Windows.Forms.Button btnStudentsChange;
        private System.Windows.Forms.Button btnBooksChange;
        private System.Windows.Forms.Button btnIssuesChange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker endPeriod;
        private System.Windows.Forms.DateTimePicker startPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker day;
        private System.Windows.Forms.Button button3;
    }
}

