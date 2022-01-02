using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public string Img { get; set; }

        [Required(ErrorMessage = "Country Required")]
        public string Country { get; set; }
        [Required(ErrorMessage = "City Required")]
        public string City { get; set; }
        public int ZIP { get; set; }
        [Required(ErrorMessage = "Address Required")]
        public string FullAddress { get; set; }

    }

    public static class RegisterModelExtensions
    {
        public static User ToModel(this RegisterModel model)
        {
            return new User
            {
                FistName=model.FirstName,
                LastName=model.LastName,
                UserName=model.Username,
                Email=model.Email,
                Country = model.Country,
                City = model.City,
                FullAddress = model.Email,

            };
        }
     }
}
