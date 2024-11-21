public class InsureeControlller; InsureeControlller
{
    private readonly ApplicationDbContext_context;
public InsureeController(ApplicationDbContext context)
{
    _context = context;
}
public IActionResult Admin()
{
    var allQuotes = _context.InsureeController.select(i => new{
        i.FirstName
        i.LastName
        i.Email
        i.Quote
    })
    .ToList();
    return View(allQuotes);
}
}