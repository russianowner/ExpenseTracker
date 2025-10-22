using ExpenseTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseTracker.Services
{
    public class ExpenseService
    {
        private readonly FileService _fileService;
        private List<Expense> _expenses;

        public ExpenseService(FileService fileService)
        {
            _fileService = fileService;
            _expenses = _fileService.LoadExpenses();
        }
        public List<Expense> GetAll() => _expenses;
        public void Add(Expense expense)
        {
            _expenses.Add(expense);
            _fileService.SaveExpenses(_expenses);
        }
        public void Delete(Guid id)
        {
            _expenses.RemoveAll(e => e.Id == id);
            _fileService.SaveExpenses(_expenses);
        }
        public List<Expense> FilterByCategory(string category)
        {
            return _expenses
                .Where(e => e.Category == category)
                .ToList();
        }
    }
}
