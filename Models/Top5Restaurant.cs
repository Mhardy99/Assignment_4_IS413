using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_IS413.Models
{
    public class Top5Restaurant
    {


        public Top5Restaurant(string rank)
        {
            RestaurantRank = rank;
        }
        //this is where i set the null valeus and create an array for the list
        public string RestaurantRank { get; }
        public string RestaurantName{get; set;}
        public string? FavDish { get; set; } = "It’s all tasty!";
        public string RestaurantAddress { get; set; }
        public string RestaurantPhone { get; set; }
        public string? RestaurantLink { get; set; } = "Coming soon.";
        public static Top5Restaurant[] GetTop5Restaurants()
        {


            // these are the things that I will be adding in my array
            Top5Restaurant r1 = new Top5Restaurant("1")
            {
                RestaurantName="Panda Express",
                FavDish="Orange Chicken",
                RestaurantAddress="1240 N University Avenue",
                RestaurantPhone= "8017278304",
                RestaurantLink="www.pandaexpress.com"

            };

            Top5Restaurant r2 = new Top5Restaurant("2")
            {

                RestaurantName = "Wendy's",
                FavDish = "Baconator",
                RestaurantAddress = "122 E 1230 N St",
                RestaurantPhone = "8015390607",
                RestaurantLink = "www.wendys.com"

            };

            Top5Restaurant r3 = new Top5Restaurant("3")
            {

                RestaurantName = "Rancheritos",
                //proves null value is working
                RestaurantAddress = "1210 N University Avenue",
                RestaurantPhone = "8012390941",
                //proves null value is working

            };

            Top5Restaurant r4 = new Top5Restaurant("4")
            {

                RestaurantName = "Betos",
                FavDish = "Breakfast Burrito",
                RestaurantAddress = "Somewhere on University",
                RestaurantPhone = "1200 N State St",
                RestaurantLink = "www.betosburritos.com"

            };

            Top5Restaurant r5 = new Top5Restaurant("5")
            {

                RestaurantName = "Waffle Love",
                FavDish = "Waffle",
                RestaurantAddress = "1831 N State Street",
                RestaurantPhone = "8004249906",
                RestaurantLink = "www.wafflelove.com"

            };
            //returns new array
            return new Top5Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}
