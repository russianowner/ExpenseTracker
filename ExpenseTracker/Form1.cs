using ExpenseTracker.Models;
using ExpenseTracker.Services;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExpenseTracker
{
    public partial class Form1 : Form
    {
        private readonly ExpenseService _expenseService;

        public Form1()
        {
            InitializeComponent();
            _expenseService = new ExpenseService(new FileService());

            cbCategoryFilter.Items.AddRange(new object[] { "Все", "Еда", "Транспорт", "Развлечения", "Прочее" });
            cbCategoryFilter.SelectedIndex = 0;

            LoadExpenses();
        }
        private void LoadExpenses()
        {
            var expenses = _expenseService.GetAll();
            RefreshTable(expenses);
            UpdateChart(expenses);
        }
        private void RefreshTable(List<Expense> list)
        {
            dgvExpenses.DataSource = list
                .Select(e => new
                {
                    e.Id,
                    Дата = e.Date.ToShortDateString(),
                    Категория = e.Category,
                    Сумма = e.Amount,
                    Описание = e.Description
                })
                .ToList();
            dgvExpenses.Columns["Id"].Visible = false;
        }
        private void UpdateChart(List<Expense> list)
        {
            chartExpenses.Series.Clear();
            chartExpenses.ChartAreas.Clear();
            chartExpenses.ChartAreas.Add(new ChartArea("MainArea"));
            var s = new Series("Expenses")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                ["PieLabelStyle"] = "Outside",
                ["PieStartAngle"] = "270"
            };
            var grouped = list.GroupBy(e => e.Category)
                              .Select(g => new { g.Key, Total = g.Sum(x => x.Amount) });
            foreach (var g in grouped)
                s.Points.AddXY(g.Key, g.Total);
            chartExpenses.Series.Add(s);
            chartExpenses.Legends[0].Docking = Docking.Right;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var addForm = new FormAddExpense();
            if (addForm.ShowDialog() == DialogResult.OK && addForm.NewExpense != null)
            {
                _expenseService.Add(addForm.NewExpense);
                LoadExpenses();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выбери запись для удаления", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var id = (Guid)dgvExpenses.SelectedRows[0].Cells["Id"].Value;
            _expenseService.Delete(id);
            LoadExpenses();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var selected = cbCategoryFilter.SelectedItem as string;

            if (string.IsNullOrEmpty(selected) || selected == "Все")
                LoadExpenses();
            else
                RefreshTable(_expenseService.FilterByCategory(selected));
        }
        private void btnChart_Click(object sender, EventArgs e)
        {
            LoadExpenses();
        }
        private void cbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }
    }
}
