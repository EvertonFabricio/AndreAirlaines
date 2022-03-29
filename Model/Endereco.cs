using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Endereco
    {
      
        #region Propriedades
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public string Cep { get; set; }
        #endregion


        public Endereco(string logradouro, int numero, string complemento, string bairro,string cidade, string uF, string pais, string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
            Pais = pais;
            Cep = cep;
        }

        public Endereco(string logradouro, int numero, string bairro, string cidade, string uF, string pais, string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = Cidade;
            UF = uF;
            Pais = pais;
            Cep = cep;
        }





        public override string ToString()
        {
            return $"{Logradouro},{Numero},{Complemento},{Bairro},{UF},{Pais},{Cep}";
        }

    }
}
