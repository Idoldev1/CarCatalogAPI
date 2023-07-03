using System;
using System.ComponentModel.DataAnnotations;

namespace FirstWebAPI.Dto;

public class CarDto
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
}