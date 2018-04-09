using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizDev.DTO;

namespace BizDev.DAL
{
    public class ProspectLogProvider
    {
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
