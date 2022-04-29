
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime EventDate { get; set; }
        public int MaxPlaces { get;set; }
        public int Latitude { get;set; }
        public int Longitude { get;set; }
    }
}