using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Fastigheter.Models
{ // database table
    [Table("Loggen")]
    public partial class Loggen
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string DateTime { get; set; } = null!;
        [StringLength(50)]
        public string Dörrkod { get; set; } = null!;
        [StringLength(50)]
        public string Händelsekod { get; set; } = null!;
        [StringLength(50)]
        public string Personenstagg { get; set; } = null!;
        [StringLength(50)]
        public string Personensnamn { get; set; } = null!;
        [StringLength(100)]
        public string Textbeskrivning { get; set; } = null!;
    }
}
