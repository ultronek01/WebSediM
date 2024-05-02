using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebSediM.Data;

namespace WebSediM.Services
{
    public class UcitelService
    {
        private readonly ApplicationDbContext _context;

        public UcitelService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GetKrestniJmenoAndPrijmeni(int id)
        {
            var osoba = _context.Ucitele.FirstOrDefault(o => o.Id == id);
            if (osoba != null)
            {
                string krestniJmeno = osoba.KrestniJmeno;
                string prijmeni = osoba.Prijmeni;

                // Použití hodnot
                Console.WriteLine("Křestní jméno: " + krestniJmeno);
                Console.WriteLine("Příjmení: " + prijmeni);
            }
            else
            {
                Console.WriteLine("Osoba nenalezena.");
            }
        }
    }
}
