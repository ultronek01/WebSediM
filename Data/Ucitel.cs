using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebSediM.Data
{
    public class Ucitel
    {
        [Key]
        public int Id { get; set; }

        public string? KrestniJmeno { get; set; }

        public string? Prijmeni { get; set; }
    }
}
