using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizDev.DAL;
using System.Data.Entity;

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
    }
}
