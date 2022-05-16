using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    [Table("Review")]
    public class Review
    {
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 999.99)]
        public decimal Rating { get; set; }
        public string? ReviewText { get; set; }
    }
}
