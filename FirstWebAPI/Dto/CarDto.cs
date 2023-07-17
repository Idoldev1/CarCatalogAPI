using System;
using System.ComponentModel.DataAnnotations;

namespace FirstWebAPI.Dto;

public class CarDto
{
    public int Id { get; set; }


    [MaxLength(30, ErrorMessage = "Name cannot exceed 30 characters")]
    public string Name { get; set; }

    public string Brand { get; set; }

    public string Maker { get; set; }
}