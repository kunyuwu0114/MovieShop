using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    [Table("Cast")]
    public class Cast
    {
        public int Id { get; set; }
        [MaxLength(128)]
        public int? Name { get; set; }
        public int? Gender { get; set; }
        public int? TmdbUrl { get; set; }
        [MaxLength(2048)]
        public int? ProfilePath { get; set; }

        public ICollection<MovieCast> MoviesOfCast { get; set; }
    }
}
