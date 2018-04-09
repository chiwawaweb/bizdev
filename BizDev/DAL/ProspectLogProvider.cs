using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizDev.DTO;

namespace BizDev.DAL
{
    public class ProspectLogProvider
    {
        public int? Create(Prospect prospect, ProspectLog prospectLog)
        {
            using (Context context = new Context())
            {
                try
                {
                    context.ProspectsLogs.Add(prospectLog);
                    context.Prospects.Attach(prospect);
                    context.Entry(prospect).State = EntityState.Modified;
                    context.SaveChanges();
                    int? id = prospectLog.Id;
                    return id;
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<ProspectLog> GetByProspectId(int _id)
        {
            using (Context context = new Context())
            {
                try
                {
                    var suivis = from b in context.ProspectsLogs
                                      where b.ProspectId == _id
                                      orderby b.Date ascending
                                      select b;

                    return suivis.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
