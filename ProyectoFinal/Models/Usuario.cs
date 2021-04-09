using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MinLength(10, ErrorMessage = "El nombre de usuario debe tener minimo 10 caracteres")]
        public string Nombre { get; set; }
        [EmailAddress(ErrorMessage = "Debe ingresar un email valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El numero de celular es obligatorio")]
        [MinLength(10, ErrorMessage = "El numero de celular debe tener minimo 10 caracteres")]
        public int Telefono { get; set; }
        [Range(15,200, ErrorMessage = "La edad debe ser un valor positivo Mayor a 15 ")]
        public int Edad { get; set; }
        public string Ciudad { get; set; }
        public bool Interes { get; set; }

    }
}