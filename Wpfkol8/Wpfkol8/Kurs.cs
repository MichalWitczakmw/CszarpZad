using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpfkol8.Models
{
    public class Kurs
    {
        [Key]
        public int Id { get; set; } 
        public string NazwaKursu { get; set; }
        public string Prowadzący { get; set; }
        public int LiczbaGodzin { get; set; }
        public bool CzyObowiązkowy { get; set; }
    }
}
