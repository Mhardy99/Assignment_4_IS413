using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_IS413.Models
{
    public class RestaurantResponse
    {
        //shows what info is required to be submitted and ensures phone number is validated
        public string Name { get; set; }
        public string RestName { get; set; }
        public string FavoriteDish { get; set; }
        [Required]
        [Phone]
        public string RestaurantPhoneNumber { get; set; }
    }
}
