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
        public bool Partners { get; set; }
        public string Entreprise { get; set; }
        public string NumeroInterne { get; set; }
        public string Civilite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string CP { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }
        public string Email { get; set; }
        public string NumeroCarte { get; set; }
        public int Points { get; set; }
        public DateTime DateEntree { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<ClientPoint> clientsPoints { get; set; }
    }
}
