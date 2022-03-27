﻿using System.ComponentModel.DataAnnotations;

namespace vidly.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}