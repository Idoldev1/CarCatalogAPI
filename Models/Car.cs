using System;
using System.ComponentModel.DataAnnotations;

namespace FirstWebAPI.Models;

public class Car
{
    public int Id { get; set; }


    [MaxLength(30, ErrorMessage = "Name cannot exceed 30 characters")]
    public string Name { get; set; }

    public string Brand { get; set; }

    public string Maker { get; set; }


    [Display(Name = "No of Seaters")]
    public int Seaters { get; set; }

    public int Quantity { get; set; }


    [Display(Name = "Country Assembled")]
    public string CountryMade { get; set; }


    [Display(Name = "Date Manufactured")]
    public DateTime DateManufactured { get; set; }
}