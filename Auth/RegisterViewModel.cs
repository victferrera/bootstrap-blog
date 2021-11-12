﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Auth
{
    public class Register
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirme a Senha")]
        [Compare("Password",ErrorMessage ="As senhas não conferem")]
        public string ConfirmPassword { get; set; }
    }
}
