using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Voo
    {
        #region Propriedades
        public int Id { get; set; }
        public Aeronave Aeronave { get; set; }
        public Aeroporto Destino { get; set; }
        public Aeroporto Origem { get; set; }
        public DateTime HoraEmbarque { get; set; }
        public DateTime PrevDesembarque { get; set; }
        public Passageiro Passageiro { get; set; }
        #endregion
    }
}
