﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace myproject_NVIT.Models
{
    public class MyDateTimeValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((DateTime)value >= Convert.ToDateTime("01/01/1990") && (DateTime)value <= Convert.ToDateTime("01/01/2008"))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Date must be between 1990 and 2008");
            }
        }

    }
}