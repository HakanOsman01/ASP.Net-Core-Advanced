using HouseRentingSystem.Infrastructer.Constants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructer.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructer.Data.Models
{
    [Comment("The category of house")]
    public class Category
    {
        [Key]
        [Comment("Identifier for category")]
        public int Id { get; set; }
        [Required]
        [MaxLength(MaxCategoryNameLenght)]
        public string Name { get; set; } = string.Empty;
        public IEnumerable<House> Houses = new List<House>();

    }
}
