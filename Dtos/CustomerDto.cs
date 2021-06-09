using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MovieRental.Models;

namespace MovieRental.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Required(ErrorMessage ="Membership Type field is required")]
        public int  MembershipTypeId { get; set; }

        public static explicit operator CustomerDto(List<Customer> v)
        {
            throw new NotImplementedException();
        }

        [BirthDateValidation]
        public System.DateTime? BirthDate { get; set; }
    }
}