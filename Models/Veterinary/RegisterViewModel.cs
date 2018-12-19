using System.ComponentModel.DataAnnotations;

namespace ApPets.Models.Veterinary
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "RFC")]
        public string RFC { get; set; }

        [Required]
        [Display(Name = "Numero de telefono")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Direccion")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }

        [Required]
        [Display(Name = "Codigo Postal")]
        public string CP { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public int IdEstado { get; set; }

        [Required]
        public int Longitud { get; set; }

        [Required]
        public int Latitud { get; set; }

    }
}