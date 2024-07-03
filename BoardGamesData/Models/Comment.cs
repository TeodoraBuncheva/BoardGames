using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesData.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public Game Game { get; set; }

    }
}
