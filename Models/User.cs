using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace coolproject.Models{
    public class User{ //handles user validation
        [Key]//???????????????????
        public int UserId{get; set;}

        [Required(ErrorMessage = "Firstname is required")]//Validates First Name
        public string FirstName {get;set;}


        [Required(ErrorMessage = "Lastname is required")]//Validates Last Name
        public string LastName {get;set;}


        [Required(ErrorMessage = "Email is required")]//Validates Email
        [EmailAddress]
        public string Email{get; set;}

        
        [Required(ErrorMessage = "Password is required")]//Validates password
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password {get; set;}

        
        [Required(ErrorMessage="Confirm password is required.")]//Makes sure passwords match
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage="The password doesn't match.")]
        public string ConfirmPassword {get; set; }

    }
}