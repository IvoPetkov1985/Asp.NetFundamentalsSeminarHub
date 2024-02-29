﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarHub.Data.Models
{
    public class Seminar
    {
        [Key]
        public int Id { get; set; }

        [Required]        
        [MaxLength(DataConstants.Seminar.TopicMaxLength)]
        public string Topic { get; set; } = string.Empty;

        [Required]        
        [MaxLength(DataConstants.Seminar.LecturerMaxLength)]
        public string Lecturer { get; set; } = string.Empty;

        [Required]        
        [MaxLength(DataConstants.Seminar.DetailsMaxLength)]
        public string Details { get; set; } = string.Empty;

        [Required]
        public string OrganizerId { get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(OrganizerId))]
        public IdentityUser Organizer { get; set; } = null!;

        [Required]
        public DateTime DateAndTime { get; set; }

        [Range(DataConstants.Seminar.DurationMin, DataConstants.Seminar.DurationMax)]
        public int Duration { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        public ICollection<SeminarParticipant> SeminarsParticipants { get; set; } = new List<SeminarParticipant>();
    }
}
