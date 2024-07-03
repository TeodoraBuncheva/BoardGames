using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesData.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        public Game Game { get; set; }
        public int Rate { get; set; }
        public User User { get; set; }
    }
}
