using SeminarHub.Data;
using System.ComponentModel.DataAnnotations;

namespace SeminarHub.Models.Seminars
{
    public class SeminarDeleteViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(DataConstants.Seminar.TopicMinLength)]
        [MaxLength(DataConstants.Seminar.TopicMaxLength)]
        public string Topic { get; set; } = string.Empty;

        [Required]
        public string DateAndTime { get; set; } = string.Empty;
    }
}
