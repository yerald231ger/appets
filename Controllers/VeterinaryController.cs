using ApPets.Services;
using Microsoft.AspNetCore.Mvc;

public class VeterinaryController : Controller
{
    public IUOWVeterinaries UOWVeterinaries { get; }

    public VeterinaryController(IUOWVeterinaries uOWVeterinaries)
    {
        UOWVeterinaries = uOWVeterinaries;
    }


    public IActionResult Index()
    {
        return View();
    }
}