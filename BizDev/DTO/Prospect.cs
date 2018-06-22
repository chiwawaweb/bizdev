using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BizDev.DTO
{
    public class Prospect
    {
        public int Id { get; set; }
        public string Categorie { get; set; }
        public bool ClientPro { get; set; }
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
        public string DatePremierContact { get; set; }
        public string DateConversion { get; set; }
        public string DateAbandon { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<ProspectLog> prospectLog { get; set; }

    }
}
