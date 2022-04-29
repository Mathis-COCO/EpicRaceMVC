using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class CreateRaceRequest
    {
        [Required(ErrorMessage = "Vous devez renseigner un nom à votre course")]
        [MaxLength(32)]
        public string? RaceName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime RaceDate { get; set; }

        [Required(ErrorMessage = "Veuillez préciser le nombre de places")]
        public int RacePlaces { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }
}