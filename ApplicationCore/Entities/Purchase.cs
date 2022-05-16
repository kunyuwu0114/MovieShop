using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    [Table("Purchase")]
    public class Purchase
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public Guid PurchaseNumber { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        public decimal TotalPrice { get; set; }
        [MaxLength(7)]
        public DateTime PurchaseDateTime { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
    }
}
