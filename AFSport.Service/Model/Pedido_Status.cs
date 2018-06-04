using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSport.Service.Model
{
    public class Pedido_Status
    {
        public int IdStatus { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return Status.ToUpper();
        }
    }
}
