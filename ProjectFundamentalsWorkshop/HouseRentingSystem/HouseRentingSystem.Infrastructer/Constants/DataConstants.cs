using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Infrastructer.Constants
{
    public static class DataConstants
    {
        public const int MaxCategoryNameLenght = 50;
        public const int MaxTitleHouseNameLenght = 50;
        public const int MinTitleHouseNameLenght = 10;
        public const int MaxAddressHouseLenght = 150;
        public const int MinAddressHouseLenght = 30;
        public const int MaxDescriptionHouseLenght = 500;
        public const int MinDescriptionHouseLenght = 50;
        public const string HouseRentingPriceMinimum = "0.00";
        public const string HouseRentingPriceMaximum = "2000.00";
        public const int MaxPhoneNumberAgent = 15;
        public const int MinPhoneNumberAgent = 7;




    }
//    The Category class should have the following properties:
//•	Id – a unique integer, Primary Key
//•	Name – a string with max length 50 (required)
//•	Houses – a collection of House

}
