using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cricket.Models
{
    public class Cricketer
    {
        [Key]
        public long CricketerId { get; set; }
        public string CricketerName { get; set; }
        public long TotalODI { get; set; }
        public long TotalScore { get; set; }
        public long Fifties { get; set; }
        public long Hundreds { get; set; }

    }
}
