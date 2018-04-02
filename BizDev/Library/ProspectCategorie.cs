using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizDev.Library
{
    public class ProspectCategorie
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Abrv { get; set; }

        public string Fullname => Nom;

    }
}
