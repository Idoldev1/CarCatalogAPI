using System;
using System.ComponentModel.DataAnnotations;

namespace FirstWebAPI.Models;

public class Car
{   
    [Required]
     public int Id { get; set; }

    [Required]
    [MaxLength(30, ErrorMessage = "Name cannot exceed 30 characters")]
    public string Name { get; set; }

    [Required]
    [MaxLength(30, ErrorMessage = "Brand cannot exceed 30 characters")]
    public string Brand { get; set; }

    [Required]
    [MaxLength(30, ErrorMessage = "Maker cannot exceed 30 characters")]
    public string Maker { get; set; }

    [Required]
    [Range(2, 20)]
    [Display(Name = "No of Seaters")]
    public int Seaters { get; set; }

    [Required]
    [Range(1, 25)]
     public int Quantity { get; set; }

    [Required]
    [MaxLength(30, ErrorMessage = "Must not exceed 30 characters")]
    [Display(Name = "Country Assembled")]
    public string CountryMade { get; set; }


    [Required]
    [Display(Name = "Date Manufactured")]
    public DateTime DateManufactured { get; set; }
}