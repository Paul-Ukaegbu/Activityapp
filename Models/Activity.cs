using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace coolproject.Models{
    public class newActivity{ //class for creating activity

    [Required(ErrorMessage = "Title is required")]
    public string Title {get;set;}

    [Required(ErrorMessage = "Date is required")]
    public string Date {get;set;}

    [Required(ErrorMessage = "Provide Time")]
    public string Time {get;set;}

    [Required(ErrorMessage = "Select Duration")]
    public string Duration {get;set;}

    [Required(ErrorMessage = "Needs more characters")]
    public string Description {get;set;}
 



    }
}