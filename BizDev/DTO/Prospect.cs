using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizDev.DTO
{
    public class Prospect
    {
        public int Id { get; set; }
        public ICollection<ProspectCategorie> ProspectsCategories { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Complement { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string Tel { get; set; }
        public string Gsm { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string NbEmployes { get; set; }

        public DateTime PremierContact { get; set; }
        public bool Converti { get; set; }
        public DateTime DateConversion { get; set; }

        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
