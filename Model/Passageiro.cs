using System;

namespace Model
{
    public class Passageiro
    {
     
        #region Propriedades

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }

        #endregion

        public Passageiro(string cpf, string nome, string telefone, DateTime dataNasc, string email)
        {
            Cpf = cpf;
            Nome = nome;
            Telefone = telefone;
            DataNasc = dataNasc;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Cpf},{Nome},{Telefone},{DataNasc},{Email}\n";
        }



    }
}
