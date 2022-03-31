﻿namespace BabyMemory.Infrastructure.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;
    using Data.Models;
    using Shared;
    public class HealthProcedureViewModel
    {

        [Required]
        [StringLength(GlobalConstants.HealthProcedureNameMAxLenDb,
            MinimumLength = GlobalConstants.HealthProcedureNameMinLen)]
        public string Name { get; set; }

        [StringLength(GlobalConstants.MemoryDescriptionMaxLen,
            MinimumLength = GlobalConstants.MemoryDescriptionMinLen)]
        [AllowNull]
        public string Description { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public ICollection<Medicine> Medicines { get; set; } = new List<Medicine>();
    }
}
