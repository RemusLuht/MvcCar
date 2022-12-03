using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCar.Models
{
    public class Car
    {
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Color { get; set; }
        [Range(1,300)]
        [Required]
        public int Speed { get; set; }
        [StringLength(10, MinimumLength = 5)]
        [Required]
        public string Transmission { get; set; }
    }
}
