using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BizDev.DTO;

namespace BizDev.DAL
{
    public class ProspectCategorieProvider
    {
        public List<String> RetrieveCategories()
        {
            using (Context context = new Context())
            {
                try
                {
                    var result = context.Prospects.Select(v => v.Categorie).Distinct();

                    return result.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
