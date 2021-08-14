using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjetolocal.Models
{
    public class Producao : BaseModels
    {
        public string Operador { get; set; }
        public string Auxiliar { get; set; }
        public string Inicio { get; set; }
        public string Fim { get; set; }
        public int Quantidade { get; set; }
    }
}