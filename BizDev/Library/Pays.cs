using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizDev.Library
{
    public class Pays
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Abrv { get; set; }

        public string Fullname => Nom.ToUpper();

        public List<Pays> GetAllPays()
        {
            List<Pays> pays = new List<Pays>()
            {
                new Pays { Abrv="fr", Nom="France" },
                new Pays { Abrv="lu", Nom="Luxembourg"},
                new Pays { Abrv="be", Nom="Belgique"},

            };

            return pays.ToList();
        }
    }
}
