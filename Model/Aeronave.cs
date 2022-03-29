using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Aeronave
    {
        
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }
        #endregion


        public Aeronave(int id, string nome, int capacidade)
        {
            Id = id;
            Nome = nome;
            Capacidade = capacidade;
        }


        public override string ToString()
        {
            return $"{Id},{Nome},{Capacidade}\n";
        }

    }
}
