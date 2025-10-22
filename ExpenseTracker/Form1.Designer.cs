using System.Windows.Forms.DataVisualization.Charting;
#nullable disable

namespace ExpenseTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCategory = new Label();
            cbCategoryFilter = new ComboBox();
            btnRefresh = new Button();
            dgvExpenses = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnChart = new Button();
            chartExpenses = new Chart();
            ChartArea chartArea = new ChartArea("MainArea");
            Legend legend = new Legend("Legend1");
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartExpenses).BeginInit();
            SuspendLayout();
            // --- lblCategory ---
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 29);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(76, 19);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Категория:";
            // --- cbCategoryFilter ---
            cbCategoryFilter.FormattingEnabled = true;
            cbCategoryFilter.Location = new Point(96, 26);
            cbCategoryFilter.Name = "cbCategoryFilter";
            cbCategoryFilter.Size = new Size(122, 25);
            cbCategoryFilter.TabIndex = 1;
            // --- btnRefresh ---
            btnRefresh.Location = new Point(256, 19);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(106, 37);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = true;
            // --- dgvExpenses ---
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToDeleteRows = false;
            dgvExpenses.AllowUserToResizeRows = false;
            dgvExpenses.BorderStyle = BorderStyle.Fixed3D;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpenses.Location = new Point(51, 75);
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.MultiSelect = false;
            dgvExpenses.RowHeadersVisible = false;
            dgvExpenses.Size = new Size(456, 202);
            dgvExpenses.TabIndex = 3;
            // --- btnAdd ---
            btnAdd.Location = new Point(24, 292);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 60);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            // --- btnDelete ---
            btnDelete.Location = new Point(193, 298);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 54);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // --- btnChart ---
            btnChart.Location = new Point(366, 301);
            btnChart.Name = "btnChart";
            btnChart.Size = new Size(123, 56);
            btnChart.TabIndex = 6;
            btnChart.Text = "Обновить диаграмму";
            btnChart.UseVisualStyleBackColor = true;
            // --- chartExpenses ---
            chartExpenses.ChartAreas.Add(chartArea);
            chartExpenses.Legends.Add(legend);
            chartExpenses.Location = new Point(530, 75);
            chartExpenses.Name = "chartExpenses";
            chartExpenses.Size = new Size(320, 280);
            chartExpenses.TabIndex = 7;
            chartExpenses.Text = "chartExpenses";
            // --- Form1 ---
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 400);
            Controls.Add(chartExpenses);
            Controls.Add(btnChart);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvExpenses);
            Controls.Add(btnRefresh);
            Controls.Add(cbCategoryFilter);
            Controls.Add(lblCategory);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense Tracker";
            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnChart.Click += btnChart_Click;
            cbCategoryFilter.SelectedIndexChanged += cbCategoryFilter_SelectedIndexChanged;
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label lblCategory;
        public ComboBox cbCategoryFilter;
        public Button btnRefresh;
        public DataGridView dgvExpenses;
        public Button btnAdd;
        public Button btnDelete;
        public Button btnChart;
        private Chart chartExpenses;
    }
}
