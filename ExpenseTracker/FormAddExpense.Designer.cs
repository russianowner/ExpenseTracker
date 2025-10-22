namespace ExpenseTracker
{
    partial class FormAddExpense
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblCategory = new Label();
            cbCategory = new ComboBox();
            lblAmount = new Label();
            numAmount = new NumericUpDown();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // --- lblCategory ---
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(23, 36);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(76, 19);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Категория:";
            // --- cbCategory ---
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(108, 36);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(180, 25);
            cbCategory.TabIndex = 1;
            // --- lblAmount ---
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(32, 84);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(55, 19);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Сумма:";
            // --- numAmount ---
            numAmount.DecimalPlaces = 2;
            numAmount.Maximum = 1000000;
            numAmount.Location = new Point(108, 82);
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(180, 25);
            numAmount.TabIndex = 3;
            // --- lblDate ---
            lblDate.AutoSize = true;
            lblDate.Location = new Point(32, 134);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(42, 19);
            lblDate.TabIndex = 4;
            lblDate.Text = "Дата:";
            // --- dtpDate ---
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(108, 127);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(180, 25);
            dtpDate.TabIndex = 5;
            // --- lblDescription ---
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(23, 185);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(75, 19);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Описание:";
            // --- txtDescription ---
            txtDescription.Location = new Point(108, 182);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(230, 25);
            txtDescription.TabIndex = 7;
            // --- btnSave ---
            btnSave.Location = new Point(41, 233);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 45);
            btnSave.TabIndex = 8;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click; 
            // btnCancel 
            btnCancel.Location = new Point(208, 233);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 45);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click; 
            // FormAddExpense 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 300);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(numAmount);
            Controls.Add(lblAmount);
            Controls.Add(cbCategory);
            Controls.Add(lblCategory);
            Font = new Font("Segoe UI", 10F);
            Name = "FormAddExpense";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавить расход";
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label lblCategory;
        private Label lblAmount;
        private Label lblDate;
        private Label lblDescription;
        public ComboBox cbCategory;
        public NumericUpDown numAmount;
        public DateTimePicker dtpDate;
        public TextBox txtDescription;
        public Button btnSave;
        public Button btnCancel;
    }
}
