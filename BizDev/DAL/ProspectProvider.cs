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
                                    where (b.Nom.Contains(keywords)
                                    || b.Adresse.Contains(keywords)
                                    || b.CodePostal.Contains(keywords)
                                    || b.Ville.Contains(keywords))
                                    select b;

                    return prospects.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<Prospect> GetAll()
        {
            using (Context context = new Context())
            {
                try
                {
                    var prospects = from b in context.Prospects
                                    orderby (b.Id) ascending
                                    select b;

                    return prospects.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}


