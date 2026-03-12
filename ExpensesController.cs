using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerAPI;

[Authorize]
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
    public async Task<IActionResult> GetAll()
    {
        var expenses = await _db.Expenses.ToListAsync();

        if (!expenses.Any())
            return Ok(new { message = "No expenses found", data = expenses });

        return Ok(new { message = "Expenses retrieved successfully", data = expenses });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var expense = await _db.Expenses.FindAsync(id);

        if (expense == null)
            return NotFound(new { message = $"Expense with ID {id} not found" });

        return Ok(new { message = "Expense retrieved successfully", data = expense });
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Expense expense)
    {
        if (!ModelState.IsValid)
            return BadRequest(new
            {
                message = "Validation failed",
                errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
            });

        _db.Expenses.Add(expense);
        await _db.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = expense.Id },
            new { message = "Expense created successfully", data = expense });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var expense = await _db.Expenses.FindAsync(id);

        if (expense == null)
            return NotFound(new { message = $"Expense with ID {id} not found" });

        _db.Expenses.Remove(expense);
        await _db.SaveChangesAsync();

        return Ok(new { message = $"Expense with ID {id} deleted successfully" });
    }
}