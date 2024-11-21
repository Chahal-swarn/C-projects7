using Microsoft.AspNetCore.Mvc;
using YourNmaespace.Models;

public classInsureeController : Controller
{
    private readonly ApplicationDbContext_context;
     
     public InsureeController(ApplicationDbContext context)
     {
        _contexxt = context;

     }

     public IActionResult Create()
     
    {
        return View();
    }
    [Httppost]
    [ValidateAntiForgerytoken]
    public IActionResult Create(Insuree Insuree)
    {
        if (ModelState.IsValid)
        {
            decimal quote = 50;
            if (insuree.Age<= 18)
            quote+= 100;
            else if (insuree.Age >=19 && insuree.Age <= 25)
            quote += 50;
            else
            quote += 25;

            if (insuree.CarYear < 2000)
            quote += 25;
            else if (insuree.CarYear > 2015)
            quote += 25;

            if (insuree.CarMake.ToLower() == "porsche")
            {
                quote += 25;
            }
        }
        quote += 10* insuree,SpeedingTickets;
        if (insuree.HasDUI)
        quote *= 1.25m;
        if (insuree.CoverageType == "Full")
        quote *= 1.50m;

        insuree.Quote = quote;
        _context.Add(insuree);
        _context.SaveChanges();
        
        return RedirectToAction("Index");

    }
    return View(insuree);
}