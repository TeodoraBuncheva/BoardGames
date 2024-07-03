using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesData.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public DateTime BookDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Game Game { get; set; }
        public User User { get; set; }
    }
}
