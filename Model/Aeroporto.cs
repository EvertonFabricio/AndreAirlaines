using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Aeroporto
    {
        #region Propriedades
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        #endregion
    }
}
