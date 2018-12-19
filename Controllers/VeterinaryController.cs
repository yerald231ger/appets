using System.Collections.Generic;
using System.Linq;
using ApPets.Common;
using ApPets.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

public class VeterinaryController : Controller
{
    public IUOWVeterinaries UOWVeterinaries { get; }

    public VeterinaryController(IUOWVeterinaries uOWVeterinaries)
    {
        UOWVeterinaries = uOWVeterinaries;
    }

    public IActionResult Index()
    {
        ViewBag.Paises = SelectPaises(2);
        ViewBag.Estados = SelectEstados(2, 0);
        return View();
    }

    public IActionResult Edit(){
        
        return View();
    }
    
    private List<SelectListItem> SelectPaises(int defaultSelect = 0)
    {
        var paises = UOWVeterinaries.Pais.Read().Cast<Base<int>>().ToList();
        return Select(paises, defaultSelect);
    }

    private List<SelectListItem> Select(List<Base<int>> list, int defaultSelect = 0)
    {
        var listItems = new List<SelectListItem>();
        foreach (var p in list)
            listItems.Add(new SelectListItem
            {
                Text = p.Name,
                Value = p.Id.ToString(),
                Selected = p.Id == defaultSelect
            });
        return listItems;
    }

    private List<SelectListItem> SelectEstados(int idPais = 2, int defaultSelect = 0)
    {
        var estados = UOWVeterinaries.Pais.GetEstados(idPais).Cast<Base<int>>().ToList();
        return Select(estados, defaultSelect);
    }
}