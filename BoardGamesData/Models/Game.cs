using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesData.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public string Difficulty { get; set; }
        public int CountGames { get; set; }
        public ICollection<Rating> Ratings { get; }
        public ICollection<Comment> Comments { get; }
        public bool IsBooked { get; set; }
    }
}
