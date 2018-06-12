using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BizDev.DTO;

namespace BizDev.DAL
{
    public class ProspectProvider
    {
        DateTime dateDebut, dateFin;

        public int CountAll()
        {
            using (Context context = new Context())
            {
                try
                {
                    return context.Prospects.Count();
                }
                catch
                {
                    throw;
                }
            }
        }

        public int Create(Prospect prospect)
        {
            using (Context context = new Context())
            {
                try
                {
                    context.Prospects.Add(prospect);
                    context.SaveChanges();
                    int id = prospect.Id;
                    return id;
                }
                catch
                {
                    throw;
                }
            }
        }

        public void Update(Prospect prospect)
        {
            using (Context context = new Context())
            {
                try
                {
                    context.Prospects.Attach(prospect);
                    context.Entry(prospect).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<Prospect> All()
        {
            using (Context context = new Context())
            {
                try
                {
                    var prospects = from b in context.Prospects

                                    select b;

                    return prospects.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public Prospect GetProspectById(int id)
        {
            using (Context context = new Context())
            {
                try
                {
                    return context.Prospects.Find(id);
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<Prospect> Search(string keywords)
        {
            using (Context context = new Context())
            {
                try
                {
                    var prospects = from b in context.Prospects
                                    orderby (b.Nom) ascending
                                    where (b.Nom.Contains(keywords))
                                    select b;

                    return prospects.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<Prospect> SearchNonContactes()
        {
            using (Context context = new Context())
            {
                try
                {
                    var prospects = from b in context.Prospects
                                    orderby (b.Nom) ascending
                                    where (b.PremierContact==false && b.Abandon==false)
                                    select b;

                    return prospects.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        #region Statistiques

        DateTime noDate = new DateTime(1899, 12, 30);
        IQueryable<Prospect> prospects;

        public int TotalNew(int annee, int mois)
        {

            dateDebut = new DateTime(annee, mois, 1);
            dateFin = new DateTime(annee, mois, DateTime.DaysInMonth(annee, mois));
            using (Context context = new Context())
            {
                try
                {
                    prospects = from b in context.Prospects
                                where b.CreatedAt >= dateDebut
                                && b.CreatedAt <= dateFin
                                select b;

                    return prospects.Count();
                }
                catch
                {
                    throw;
                }
            }
        }

        public int TotalContacts(int annee, int mois)
        {
            dateDebut = new DateTime(annee, mois, 1);
            dateFin = new DateTime(annee, mois, DateTime.DaysInMonth(annee, mois));
            using (Context context = new Context())
            {
                try
                {
                    prospects = from b in context.Prospects
                                where b.DatePremierContact >= dateDebut
                                && b.DatePremierContact <= dateFin
                                select b;

                    return prospects.Count();
                }
                catch
                {
                    throw;
                }
            }
        }

        public int TotalConversions(int annee, int mois)
        {

            dateDebut = new DateTime(annee, mois, 1);
            dateFin = new DateTime(annee, mois, DateTime.DaysInMonth(annee, mois));
            using (Context context = new Context())
            {
                try
                {
                    prospects = from b in context.Prospects
                                where b.DateConversion >= dateDebut
                                && b.DateConversion <= dateFin
                                select b;

                    return prospects.Count();
                }
                catch
                {
                    throw;
                }
            }
        }

        public int TotalAbandons(int annee, int mois)
        {

            dateDebut = new DateTime(annee, mois, 1);
            dateFin = new DateTime(annee, mois, DateTime.DaysInMonth(annee, mois));
            using (Context context = new Context())
            {
                try
                {
                    prospects = from b in context.Prospects
                                where b.DateAbandon >= dateDebut
                                && b.DateAbandon <= dateFin
                                select b;

                    return prospects.Count();
                }
                catch
                {
                    throw;
                }
            }
        }

        #endregion
    }
}


