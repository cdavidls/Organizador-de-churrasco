using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizadorChurrasco
{
    public class Produto
    {
        public string descricao { get; set; }
        public string unidadeMedida { get; set; }
        public int quantidade { get; set; }
        public decimal preco { get; set; }
        public decimal total { get; set; }
        public string status { get; set; }
    }
}
