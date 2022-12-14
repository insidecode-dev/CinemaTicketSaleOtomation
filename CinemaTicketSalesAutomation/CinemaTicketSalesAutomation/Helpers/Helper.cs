using CinemaTicketSalesAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:/Users/Admino/source/repos/CinemaTicketSalesAutomation/CinemaTicketSalesAutomation/Pictures/";
            return new List<Movie>()
            {
                 new Movie() {
                    MovieName = "Captain America: The Winter Soldier",
                    Category = Enum.Category.science_fiction,
                    Minute = "2 hours 16 minutes",
                    Price = 70,
                    PicturePath = basePath + "captainAmericaWinterSoldier.jpg"
        },
                new Movie() {
                    MovieName = "Catch Me If YOU Can",
                    Category = Enum.Category.comedy,
                    Minute = "2 hours 21 minutes",
                    Price = 70,
                    PicturePath = basePath + "catchmeIfYouCan.jpg"
        },
                new Movie() {
                    MovieName = "Finch",
                    Category = Enum.Category.science_fiction,
                    Minute = "1 hours 55 minutes",
                    Price = 100,
                    PicturePath = basePath + "finch.jpg"
        },
                
                new Movie() {
                    MovieName = "Iron Man 2",
                    Category = Enum.Category.fantasy,
                    Minute = "2 hours 5 minutes",
                    Price = 110,
                    PicturePath = basePath + "ironMan2.jpg"
        },
                new Movie() {
                    MovieName = "Matrix",
                    Category = Enum.Category.science_fiction,
                    Minute = "2 hours 16 minutes",
                    Price = 100,
                    PicturePath = basePath + "matrix.jpeg"
        },
                new Movie() {
                    MovieName = "Spider-Man: In the Spider-Verse",
                    Category = Enum.Category.adventure,
                    Minute = "1 hours 56 minutes",
                    Price = 200,
                    PicturePath = basePath + "spidermanMilesMorales.jpg"
        },
               
            };
        }
    }
}
