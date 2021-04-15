using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string userName { get; set; }
        [Display(Name = "Review Date")]
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
        [Display(Name = "Review")]
        public string Message { get; set; }
    }
}
