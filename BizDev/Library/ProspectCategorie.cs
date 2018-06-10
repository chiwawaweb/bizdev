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

        public List<ProspectCategorie> GetAllProspectCategories()
        {
            List<ProspectCategorie> prospectCategorie = new List<ProspectCategorie>()
            {
                new ProspectCategorie { Abrv="ACO", Nom="Activité commerciale" },
                new ProspectCategorie { Abrv="ASP", Nom="Activité spécialisée"},
                new ProspectCategorie { Abrv="ASO", Nom="Activité sportive"},
                new ProspectCategorie { Abrv="ADM", Nom="Administration et service public"},
                new ProspectCategorie { Abrv="AFF", Nom="Affichage et enseigne"},
                new ProspectCategorie { Abrv="AGR", Nom="Agriculture et nature"},
                new ProspectCategorie { Abrv="AID", Nom="Aide et assistance"},
                new ProspectCategorie { Abrv="ALI", Nom="Alimentation"},
                new ProspectCategorie { Abrv="AEX", Nom="Aménagement extérieur"},
                new ProspectCategorie { Abrv="AIN", Nom="Aménagement intérieur"},
                new ProspectCategorie { Abrv="ANA", Nom="Analyses, conseils et études"},
                new ProspectCategorie { Abrv="ANI", Nom="Animaux"},
                new ProspectCategorie { Abrv="ASS", Nom="Assurance"},
                new ProspectCategorie { Abrv="AUD", Nom="Audiovisuel"},
                new ProspectCategorie { Abrv="AUT", Nom="Auto-école"},
                new ProspectCategorie { Abrv="AUM", Nom="Automates" },
                new ProspectCategorie { Abrv="BAN", Nom="Banque et service bancaire"},
                new ProspectCategorie { Abrv="BAR", Nom="Bar, café, club"},
                new ProspectCategorie { Abrv="BOI", Nom="Boisson"},
                new ProspectCategorie { Abrv="CAO", Nom="Caoutchouc et plastique"},
                new ProspectCategorie { Abrv="CHA", Nom="Chauffage sanitaire et plomberie"},
                new ProspectCategorie { Abrv="CHI", Nom="Chimie"},
                new ProspectCategorie { Abrv="CBS", Nom="Combustible"},
                new ProspectCategorie { Abrv="COM", Nom="Comptabilité"},
                new ProspectCategorie { Abrv="IMO", Nom="Conseil et service immobilier"},
                new ProspectCategorie { Abrv="CNT", Nom="Construction et gros oeuvre"},
                new ProspectCategorie { Abrv="CLT", Nom="Culture"},
                new ProspectCategorie { Abrv="DEC", Nom="Décoration"},
                new ProspectCategorie { Abrv="ECL", Nom="Electricité, éclairage"},
                new ProspectCategorie { Abrv="ELE", Nom="Electronique et électricité"},
                new ProspectCategorie { Abrv="EMP", Nom="Emploi et recrutement"},
                new ProspectCategorie { Abrv="EVH", Nom="Entretien de véhicule"},
                new ProspectCategorie { Abrv="ENT", Nom="Entretien et nettoyage"},
                new ProspectCategorie { Abrv="EQU", Nom="Equipement et accessoire"},
                new ProspectCategorie { Abrv="EBE", Nom="Equipement et accessoire de beauté"},
                new ProspectCategorie { Abrv="ESP", Nom="Equipement et accessoire de sport"},
                new ProspectCategorie { Abrv="ECN", Nom="Equipement et fourniture de construction"},
                new ProspectCategorie { Abrv="EVE", Nom="Evénement, foire, fête"},
                new ProspectCategorie { Abrv="FAB", Nom="Fabricant et grossiste"},
                new ProspectCategorie { Abrv="FIN", Nom="Finance"},
                new ProspectCategorie { Abrv="FLE", Nom="Fleur et plante"},
                new ProspectCategorie { Abrv="FOR", Nom="Formation et séminaire"},
                new ProspectCategorie { Abrv="GRA", Nom="Grande distribution"},
                new ProspectCategorie { Abrv="HAB", Nom="Habillement"},
                new ProspectCategorie { Abrv="HOT", Nom="Hôtel, retaurant"},
                new ProspectCategorie { Abrv="INF", Nom="Informatique et télécom"},
                new ProspectCategorie { Abrv="ING", Nom="Ingénérie"},
                new ProspectCategorie { Abrv="SCO", Nom="Institution scolaire"},
                new ProspectCategorie { Abrv="INS", Nom="Institutionnel"},
                new ProspectCategorie { Abrv="ISO", Nom="Isolation et étanchéité"},
                new ProspectCategorie { Abrv="JOU", Nom="Jouet, gadjet et souvenir"},
                new ProspectCategorie { Abrv="JUS", Nom="Justice"},
                new ProspectCategorie { Abrv="LIB", Nom="Librairie et papeterie"},
                new ProspectCategorie { Abrv="LOG", Nom="Logistique"},
                new ProspectCategorie { Abrv="LOC", Nom="Location de matériel TP"},
                new ProspectCategorie { Abrv="LOI", Nom="Loisirs"},
                new ProspectCategorie { Abrv="OPT", Nom="Matériel optique"},
                new ProspectCategorie { Abrv="VET", Nom="Médecine vétérinaire"},
                new ProspectCategorie { Abrv="MED", Nom="Médecine, professions médicales et paramédicales"},
                new ProspectCategorie { Abrv="MEN", Nom="Menuiserie"},
                new ProspectCategorie { Abrv="MET", Nom="Métallurgie"},
                new ProspectCategorie { Abrv="MOD", Nom="Mode et beauté"},
                new ProspectCategorie { Abrv="NET", Nom="Nettoyage, démolition et recyclage"},
                new ProspectCategorie { Abrv="PHA", Nom="Pharmaceutique"},
                new ProspectCategorie { Abrv="PUB", Nom="Publicité, communication"},
                new ProspectCategorie { Abrv="REV", Nom="Revêtement de sol"},
                new ProspectCategorie { Abrv="SEC", Nom="Sécurité et surveillance"},
                new ProspectCategorie { Abrv="SOC", Nom="Service social"},
                new ProspectCategorie { Abrv="SOI", Nom="Soin beauté, bien être"},
                new ProspectCategorie { Abrv="TAB", Nom="Tabac"},
                new ProspectCategorie { Abrv="TEX", Nom="Textile"},
                new ProspectCategorie { Abrv="TRA", Nom="Transport de marchandises"},
                new ProspectCategorie { Abrv="VEH", Nom="Véhicule"},
                new ProspectCategorie { Abrv="VOY", Nom="Voyage et tourisme"},

            };
            return prospectCategorie.ToList();
        }
    }
}
