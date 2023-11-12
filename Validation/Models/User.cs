using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Validation.Models
{
    public class User
    {
        private string userName;
        private string newPassword;
        private string confirmNewPassword;
        private DateTime dateOfBirth;
        private string email;
        private int postalCode;
        private string phoneNumber;
        private string profile;
        private string photo;
        private string additionalComments;
        private string city;

        [Key, Required]
        public string UserName { get => userName; set => userName = value; }
        [Required]
        public string NewPassword { get => newPassword; set => newPassword = value; }
        public string ConfirmNewPassword { get => confirmNewPassword; set => confirmNewPassword = value; }
        [Required]
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        [Required, EmailAddress]
        public string Email { get => email; set => email = value; }
        [Required]
        public int PostalCode { get => postalCode; set => postalCode = value; }
        [Required, Phone]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        [Required]
        public string Profile { get => profile; set => profile = value; }
        public string Photo { get => photo; set => photo = value; }
        public string AdditionalComments { get => additionalComments; set => additionalComments = value; }
        public string City { get => city; set => city = value; }
    }
}