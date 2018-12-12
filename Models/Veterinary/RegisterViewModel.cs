using System.ComponentModel.DataAnnotations;

public class RisterViewModel
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string RFC { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public string Direccion { get; set; }

    [Required]
    public string Ciudad { get; set; }

    [Required]
    public string CP { get; set; }

    [Required]
    public int IdEstado { get; set; }

    [Required]
    public int Longitud { get; set; }

    [Required]
    public int Latitud { get; set; }

}