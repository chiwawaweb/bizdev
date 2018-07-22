using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizDev.DTO
{
    public class ClientPoint
    {
        public int Id { get; set; }
        public double MontantAchat { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public virtual Client clients { get; set; }

    }
}
