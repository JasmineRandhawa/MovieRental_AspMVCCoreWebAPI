using System.Collections.Generic;
using MovieRental.Models;
namespace MovieRental.ViewModels
{
    public class CustomerFormViewModel
    {
        public Customer Customer { get; set; }

        public IEnumerable<MembershipType> MembershipTypes { get; set; }
    }
}