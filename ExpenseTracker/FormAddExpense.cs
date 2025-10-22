using ExpenseTracker.Models;
using System;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class FormAddExpense : Form
    {
        public Expense? NewExpense { get; private set; }

        public FormAddExpense()
        {
            InitializeComponent();

            cbCategory.Items.AddRange(new object[] { "Еда", "Транспорт", "Развлечения", "Прочее" });
            cbCategory.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Введи сумму больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NewExpense = new Expense
            {
                Category = cbCategory.SelectedItem?.ToString() ?? "Прочее",
                Amount = numAmount.Value,
                Date = dtpDate.Value,
                Description = txtDescription.Text.Trim()
            };
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
