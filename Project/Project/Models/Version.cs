﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models;

public class Version
{
    [Key]
    public long IdSoftware { get; set; }

    [Required] [MaxLength(100)]
    public string VersionNumber { get; set; } = string.Empty;

    [Required]
    public DateTime Date { get; set; }

    [Required] [MaxLength(100)]
    public string Comments { get; set; } = string.Empty;

    [ForeignKey(nameof(IdSoftware))] 
    public Software Software { get; set; } = null!;
}