﻿using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LavantellAPIS.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
    }
}
