using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_BA_88A.Models
{
    internal class RespuestaEnvioResultados
    {
        public bool ok { get; set; }
        public string message { get; set; }
        public object data { get; set; }
    }

}
