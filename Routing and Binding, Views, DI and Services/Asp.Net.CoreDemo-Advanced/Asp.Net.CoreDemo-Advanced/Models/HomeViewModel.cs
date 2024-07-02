using Asp.Net.CoreDemo_Advanced.CustomValidation;

namespace Asp.Net.CoreDemo_Advanced.Models
{
    public class HomeViewModel
    {
        [IsAdult(ErrorMessage ="Must be 18 years old!!!")]
        public DateTime BirtDate { get; set; }
    }
}
