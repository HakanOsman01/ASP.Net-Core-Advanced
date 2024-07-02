using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructer.Constants.DataConstants;
namespace HouseRentingSystem.Infrastructer.Data.Models
{
    [Comment("Agent Table")]
    public class Agent
    {
        [Key]
        [Comment("Agent identifier")]
        public int Id { get; set; }
        [Required]
        [MaxLength(MaxPhoneNumberAgent)]
        [Comment("The phone number of the agent")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string UserId { get; set; } = string.Empty;
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
        public IEnumerable<House> Houses { get; set; } = new List<House>();


    }
}