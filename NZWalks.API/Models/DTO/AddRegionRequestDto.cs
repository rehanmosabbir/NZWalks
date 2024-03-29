﻿using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.DTO
{
    public class AddRegionRequestDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Code has to be at least 3 characters long")]
        [MaxLength(3, ErrorMessage = "Code has to be at most 3 characters long")]
        public string Code { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Name has to be at most 100 characters long")]
        public string Name { get; set; }
        public string? RegionImageurl { get; set; }
    }
}
