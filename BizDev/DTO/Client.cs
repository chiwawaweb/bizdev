using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizDev.DTO
{
    public class Client
    {
        public int Id { get; set; }
        public string NumeroInterne { get; set; }
        public string Civilite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CP { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string NumeroCarte { get; set; }
        public int Points { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
