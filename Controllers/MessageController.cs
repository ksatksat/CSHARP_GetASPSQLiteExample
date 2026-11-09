using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleMessageApp.Data;

namespace SimpleMessageApp.Controllers;

public class MessageController : Controller
{
    private readonly AppDbContext _db;

    public MessageController(AppDbContext db) => _db = db;

    // HTTP GET /message
    [HttpGet("/message")]
    public async Task<IActionResult> Get()
    {
        var message = await _db.Messages.AsNoTracking().FirstOrDefaultAsync();
        if (message is null)
            return NotFound(new { text = "No message found in database." });

        return Json(new { text = message.Text });
    }
}
