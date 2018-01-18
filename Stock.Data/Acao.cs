using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Data
{
    public class Acao : BaseEntity
    {
        public string codigo { get; set; }
        public string nomeEmpresa { get; set; }
    }
}
