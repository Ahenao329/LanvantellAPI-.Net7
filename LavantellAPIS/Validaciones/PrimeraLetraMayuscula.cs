﻿using System.ComponentModel.DataAnnotations;

namespace LavantellAPIS.Validaciones
{
    public class PrimeraLetraMayuscula: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, Validati
            text validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            var primeraLetra = value.ToString()[0].ToString();

            if (primeraLetra != primeraLetra.ToUpper())
            {
                return new ValidationResult("La primera letra debe ser mayúscula");
            }

            return ValidationResult.Success;
        }
    }
}
