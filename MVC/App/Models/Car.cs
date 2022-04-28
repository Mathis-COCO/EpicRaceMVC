using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Car
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public DateTime Year { get; set; }
        public int Power { get;set; }
        public string? Image { get;set; }
        public string? Category { get;set; }

    }
}