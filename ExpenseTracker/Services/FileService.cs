using ExpenseTracker.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ExpenseTracker.Services
{
    public class FileService
    {
        private readonly string _filePath = "Data/expenses.json";

        public List<Expense> LoadExpenses()
        {
            if (!File.Exists(_filePath))
                return new List<Expense>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Expense>>(json)
                   ?? new List<Expense>();
        }
        public void SaveExpenses(List<Expense> expenses)
        {
            var dir = Path.GetDirectoryName(_filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            var json = JsonSerializer.Serialize(expenses, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
