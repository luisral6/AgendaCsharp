using System;
using System.ComponentModel.DataAnnotations;

namespace AgendaMVC.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.PhoneNumber)]
        public string Numero { get; set; }
        public string Tipo { get; set; }
    }
}