using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.Models
{
    public class UserViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name ="User Name")]
        public string UserName { get; set; }
        public String Email { get; set; }
        public string Password { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
