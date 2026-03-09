using Microsoft.AspNetCore.Mvc;

namespace ExpenseTrackerAPI
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly AppDbContext _db;

        public ExpensesController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<List<Expense>> GetAll()
        {
            return Ok(_db.Expenses.ToList());
        }

        [HttpPost]
        public ActionResult<Expense> Create(Expense newExpense)
        {
            _db.Expenses.Add(newExpense);
            _db.SaveChanges();
            return Ok(newExpense);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var expense = _db.Expenses.Find(id);

            if (expense == null)
            {
                return NotFound();
            }

            _db.Expenses.Remove(expense);
            _db.SaveChanges();
            return Ok();
        }
    }
}