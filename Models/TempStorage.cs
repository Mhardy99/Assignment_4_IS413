using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_IS413.Models
{
    //This is where I pass the information from restaurant response and make it a list
    public class TempStorage
    {
        private static List<RestaurantResponse> listrestaurants = new List<RestaurantResponse>();
        public static IEnumerable<RestaurantResponse> Listrestaurants => listrestaurants;

        public static void AddRestaurant(RestaurantResponse listallrestaurants)
        {
            listrestaurants.Add(listallrestaurants);
        }
    }
}
