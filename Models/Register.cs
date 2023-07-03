using System;

namespace FirstWebAPI.Models;

public class Register
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}