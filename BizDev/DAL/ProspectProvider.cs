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

        #region Statistiques

        DateTime noDate = new DateTime(1899,12, 30);

        public int TContacts(int nbMois)
        {
            DateTime dateTContacts;
            if (nbMois!=0)
            {
                dateTContacts = DateTime.Now.AddMonths(nbMois);
            }
            else
            {
                dateTContacts = new DateTime(1899, 12, 30);
            }
            using (Context context = new Context())
            {
                try
                {
                    IQueryable<Prospect> prospects; /// A remonter
                    if (nbMois!=0)
                    {
                        prospects = from b in context.Prospects //// a remonter !!!!
                                    where b.DatePremierContact >= dateTContacts
                                    select b;
                    }
                    else
                    {
                        prospects = from b in context.Prospects
                                    where b.DatePremierContact != noDate 
                                    select b;
                    }

                    return prospects.Count();
                }
                catch
                {
                    throw;
                }
            }
        }

        public int TConversions(int nbMois)
        {
            DateTime dateTConversions;
            if (nbMois != 0)
            {
                dateTConversions = DateTime.Now.AddMonths(nbMois);
            }
            else
            {
                dateTConversions = DateTime.Now.AddMonths(-2000);
            }
            using (Context context = new Context())
            {
                try
                {
                    var prospects = from b in context.Prospects
                                    where b.DateConversion >= dateTConversions
                                    select b;

                    return prospects.Count();
                }
                catch
                {
                    throw;
                }
            }
        }

        public int TAbandons(int nbMois)
        {
            DateTime dateTAbandons;
            if (nbMois != 0)
            {
                dateTAbandons = DateTime.Now.AddMonths(nbMois);
            }
            else
            {
                dateTAbandons = DateTime.Now.AddMonths(-2000);
            }
            using (Context context = new Context())
            {
                try
                {
                    var prospects = from b in context.Prospects
                                    where b.DateAbandon >= dateTAbandons
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
