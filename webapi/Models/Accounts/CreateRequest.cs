﻿using System.ComponentModel.DataAnnotations;
using webapi.Entities;
using webapi.Entities.Enums;

namespace webapi.Models.Accounts
{
    public class CreateRequest
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }


        [Required]
        [EnumDataType(typeof(Role))]
        public string Role { get; set; }
        public string? Phone { get; set; }


    }
}
