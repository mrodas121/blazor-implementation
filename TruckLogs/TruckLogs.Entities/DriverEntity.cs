using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class DriverEntity
    {
        public enum HiringTypeEnum
        {
            Eventual,
            Permanente
        }
        [Key]
        public int DriverId { get; set; }
        [Required(ErrorMessage = "El campo no puede ir vacío")]
        public string DriverName { get; set; }
        [Required(ErrorMessage = "El campo no puede ir vacío")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "El campo no puede ir vacío")]
        public string Nup { get; set; }
        [Required(ErrorMessage = "El campo no puede ir vacío")]
        public string ISSS { get; set; }
        [Required(ErrorMessage = "El campo no puede ir vacío")]
        public string DUI { get; set; }
        public int DriverStatus { get; set; }
        [Required(ErrorMessage = "Se debe de cargar una imagen")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "El campo no puede ir vacío")]
        public string HiringType { get; set; }
        [Required(ErrorMessage = "El campo no puede ir vacío")]
        public DateTime HiringDate { get; set; }
    }
}
