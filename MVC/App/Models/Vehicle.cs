using System.ComponentModel.DataAnnotations;

namespace App.Models;

public class Vehicle
{
    [DataType(DataType.Date)]
    public DateTime Year { get; set; }

    [DataType(DataType.Text)]
    public string Brand { get; set; }

    [DataType(DataType.Text)]
    public string Model { get; set; }

    [DataType(DataType.ImageUrl)]
    public string Image { get; set; }
}