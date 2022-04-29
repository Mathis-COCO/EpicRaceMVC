using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class RegistrationModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Veuillez renseigner votre prénom.")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Veuillez renseigner votre nom.")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Veuillez renseigner votre age.")]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Veuillez renseigner un mot de passe.")]
        public string Password { get; set; }
    }
}