using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructer.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructer.Data.Models
{
    [Comment("House")]
    public class House
    {
        [Key]
        [Comment("Identifier for house")]
        public int Id { get; set; }
        [Required]
        [MaxLength(MaxTitleHouseNameLenght)]
        [Comment("The title of the house")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(MaxAddressHouseLenght)]
        [Comment("The address of current house")]
        public string Address { get; set; } = string.Empty;
        [Required]
        [MaxLength(MaxDescriptionHouseLenght)]
        [Comment("Description of the house of rent")]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Comment("Pictire of the house")]
        public string ImageUrl { get; set; } = string.Empty;
        [Required]
        //[Range(typeof(decimal), HouseRentingPriceMinimum, HouseRentingPriceMaximum, ConvertValueInInvariantCulture = true)]
        [Comment("PricePerMonth for rent house")]
        [Column(TypeName="decimal(18,2)")]
        public decimal PricePerMonth { get; set; }
        [Required]
        [Comment("Category identifier")]
        public int CategoryId { get;set; }
        [Required]
        [Comment("Agent identifier")]
        public int AgentId { get; set; }
        [Comment("Agent identifier")]
        public string? RenterId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;
        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;


    }
}
