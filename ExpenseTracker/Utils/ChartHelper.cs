using System.Windows.Forms.DataVisualization.Charting;
using ExpenseTracker.Models;

namespace ExpenseTracker.Utils
{
    public static class ChartHelper
    {
        public static void BuildCategoryChart(Chart chart, List<Expense> expenses)
        {
            chart.Series.Clear();
            var series = new Series("Expenses")
            {
                ChartType = SeriesChartType.Pie
            };
            var grouped = expenses
                .GroupBy(e => e.Category)
                .Select(g => new { Category = g.Key, Total = g.Sum(x => x.Amount) });
            foreach (var item in grouped)
            {
                series.Points.AddXY(item.Category, item.Total);
            }
            chart.Series.Add(series);
        }
    }
}
