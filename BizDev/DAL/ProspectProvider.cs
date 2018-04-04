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
                    var clients = from b in context.Prospects select b;
                    
                    clients = from b in context.Prospects
                                orderby (b.Nom) ascending
                                where (b.Nom.Contains(keywords))
                                select b;

                    return clients.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
