using System.ComponentModel.DataAnnotations;

namespace BirthdayCardGenerator.Models
{
    public class BirthdayMessage
    {
        [Required(ErrorMessage="Please enter a name for sender.")]
        public string? From { get; set; }
        [Required(ErrorMessage="Please enter a name for recipient.")]
        public string? To { get; set; }
        [Required(ErrorMessage="Please enter you happy birthday message.")]
        public string? Message { get; set; }

    }
}
