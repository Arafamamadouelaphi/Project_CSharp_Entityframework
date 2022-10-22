﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BowlingEF.Entities
{
    /// <summary>
    /// Classe de gestion des frames
    /// </summary>
    public class FrameEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public int Lancer1 { get; set; }
        [Required]
        public int Lancer2 { get; set; }
        public int Lancer3 { get; set; }
        [Required]
        public bool IsStrike { get; set; }
        [Required]
        public bool IsSpare { get; set; }

        [ForeignKey("PartieId")]
        [Required]
        public long PartieId { get; set; }
        public PartieEntity Partie { get; set; }
    }
}