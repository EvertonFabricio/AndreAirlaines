using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Model;

namespace File
{
    public class File
    {
        public static void ImportarPassageiroEndereco()
        {
            try
            {
                StreamReader lerEndereco = new StreamReader(@"C:\Users\Everton Fabricio\source\repos\AndreAirlaines\Data\dados.csv");
                List<Endereco> listaEndereco = new List<Endereco>();
                List<Passageiro> listaPassageiro = new List<Passageiro>();
                var connetionString = @"Data Source=Everton;Initial Catalog=AndreAirlines;User ID=sa;Password=007410";


                string line;
                do
                {
                    line = lerEndereco.ReadLine();
                    if (line != null)
                    {
                        var values = line.Split(',');
                        listaEndereco.Add(new Endereco(values[0], int.Parse(values[1]), values[2], values[3], values[4], values[5], values[6], values[7]));
                        listaPassageiro.Add(new Passageiro(values[8], values[9], values[10], DateTime.Parse(values[11]), values[12]));
                        SqlConnection connection = new SqlConnection(connetionString);
                        using (connection)
                        {
                            connection.Open();
                            SqlCommand sql_cmnd = new SqlCommand("IncluirEnderecoCompleto", connection);

                            sql_cmnd.CommandType = CommandType.StoredProcedure;

                            sql_cmnd.Parameters.AddWithValue("@Logradouro", SqlDbType.VarChar).Value = values[0];
                            sql_cmnd.Parameters.AddWithValue("@Numero", SqlDbType.Int).Value = values[1];
                            sql_cmnd.Parameters.AddWithValue("@Complemento", SqlDbType.VarChar).Value = values[2];
                            sql_cmnd.Parameters.AddWithValue("@Bairro", SqlDbType.VarChar).Value = values[3];
                            sql_cmnd.Parameters.AddWithValue("@Localidade", SqlDbType.VarChar).Value = values[4];
                            sql_cmnd.Parameters.AddWithValue("@UF", SqlDbType.VarChar).Value = values[5];
                            sql_cmnd.Parameters.AddWithValue("@Pais", SqlDbType.VarChar).Value = values[6];
                            sql_cmnd.Parameters.AddWithValue("@Cep", SqlDbType.VarChar).Value = values[7];
                            sql_cmnd.ExecuteNonQuery();

                            sql_cmnd = new SqlCommand("IncluirPassageiro", connection);

                            sql_cmnd.CommandType = CommandType.StoredProcedure;

                            sql_cmnd.Parameters.AddWithValue("@CPF", SqlDbType.VarChar).Value = values[8];
                            sql_cmnd.Parameters.AddWithValue("@Nome", SqlDbType.VarChar).Value = values[9];
                            sql_cmnd.Parameters.AddWithValue("@Telefone", SqlDbType.VarChar).Value = values[10];
                            sql_cmnd.Parameters.AddWithValue("@DataNasc", SqlDbType.Date).Value = values[11];
                            sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = values[12];
                            sql_cmnd.ExecuteNonQuery();
                            connection.Close();
                        }
                    }

                } while (line != null);
                lerEndereco.Close();
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro na comunicação:>>> " + erro);

            }

        }

        public static void CadastrarPassageiro()
        {
            Console.WriteLine("CPF:");
            var cpf = Console.ReadLine();
            Console.WriteLine("Nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Telefone:");
            var telefone = Console.ReadLine();
            Console.WriteLine("Data de Nascimento:");
            var dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Email:");
            var email = Console.ReadLine();
            Console.WriteLine("Logradouro:");
            var logradouro = Console.ReadLine();
            Console.WriteLine("Numero:");
            var numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Complemento:");
            var complemento = Console.ReadLine();
            Console.WriteLine("Bairro:");
            var bairro = Console.ReadLine();
            Console.WriteLine("Localidade:");
            var localidade = Console.ReadLine();
            Console.WriteLine("UF:");
            var uf = Console.ReadLine().ToUpper();
            Console.WriteLine("Pais:");
            var pais = Console.ReadLine();
            Console.WriteLine("CEP:");
            var cep = Console.ReadLine();

            try
            {
                var connetionString = @"Data Source=Everton;Initial Catalog=AndreAirlines;User ID=sa;Password=007410";
                SqlConnection connection = new SqlConnection(connetionString);
                using (connection)
                {
                    connection.Open();


                    SqlCommand sql_cmnd = new SqlCommand("IncluirEnderecoCompleto", connection);

                    sql_cmnd.CommandType = CommandType.StoredProcedure;

                    sql_cmnd.Parameters.AddWithValue("@Logradouro", SqlDbType.VarChar).Value = logradouro;
                    sql_cmnd.Parameters.AddWithValue("@Numero", SqlDbType.Int).Value = numero;
                    sql_cmnd.Parameters.AddWithValue("@Complemento", SqlDbType.VarChar).Value = complemento;
                    sql_cmnd.Parameters.AddWithValue("@Bairro", SqlDbType.VarChar).Value = bairro;
                    sql_cmnd.Parameters.AddWithValue("@Localidade", SqlDbType.VarChar).Value = localidade;
                    sql_cmnd.Parameters.AddWithValue("@UF", SqlDbType.VarChar).Value = uf;
                    sql_cmnd.Parameters.AddWithValue("@Pais", SqlDbType.VarChar).Value = pais;
                    sql_cmnd.Parameters.AddWithValue("@Cep", SqlDbType.VarChar).Value = cep;
                    sql_cmnd.ExecuteNonQuery();

                    sql_cmnd = new SqlCommand("IncluirPassageiro", connection);

                    sql_cmnd.CommandType = CommandType.StoredProcedure;

                    sql_cmnd.Parameters.AddWithValue("@CPF", SqlDbType.VarChar).Value = cpf;
                    sql_cmnd.Parameters.AddWithValue("@Nome", SqlDbType.VarChar).Value = nome;
                    sql_cmnd.Parameters.AddWithValue("@Telefone", SqlDbType.VarChar).Value = telefone;
                    sql_cmnd.Parameters.AddWithValue("@DataNasc", SqlDbType.Date).Value = dataNascimento;
                    sql_cmnd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;
                    sql_cmnd.ExecuteNonQuery();
                    connection.Close();

                }
            }
            catch (SqlException erro)
            {
                Console.WriteLine("Erro ao se conectar no banco de dados \n" + erro);
                Console.ReadKey();
            }

        }

        public static void CadastrarAeronave()
        {
            Console.WriteLine("Nome Aeronave:");
            var Nome = Console.ReadLine().ToUpper();
            Console.WriteLine("Capacidade da Aeronave:");
            var Capacidade = int.Parse(Console.ReadLine());

            try
            {
                var connetionString = @"Data Source=Everton;Initial Catalog=AndreAirlines;User ID=sa;Password=007410";
                SqlConnection connection = new SqlConnection(connetionString);
                using (connection)
                {
                    connection.Open();
                    string sql = "INSERT INTO Aeronave (Nome, Capacidade) VALUES (@Nome, @Capacidade)";

                    SqlCommand sql_cmnd = new SqlCommand(sql, connection);

                    sql_cmnd.Parameters.AddWithValue("@Nome", SqlDbType.VarChar).Value = Nome;
                    sql_cmnd.Parameters.AddWithValue("@Capacidade", SqlDbType.Int).Value = Capacidade;
                    
                    sql_cmnd.ExecuteNonQuery();

                    connection.Close();

                }
            }
            catch (SqlException erro)
            {
                Console.WriteLine("Erro ao se conectar no banco de dados \n" + erro);
                Console.ReadKey();
            }




        }

        public static void CadastrarAeroporto()
        {
            Console.WriteLine("Sigla do Aeroporto:");
            var Sigla = Console.ReadLine().ToUpper();
            Console.WriteLine("Nome do Aeroporto:");
            var Nome = Console.ReadLine();

            try
            {
                var connetionString = @"Data Source=Everton;Initial Catalog=AndreAirlines;User ID=sa;Password=007410";
                SqlConnection connection = new SqlConnection(connetionString);
                using (connection)
                {
                    connection.Open();

                    SqlCommand sql_cmnd = new SqlCommand("IncluirAeroporto" , connection);

                    sql_cmnd.CommandType = CommandType.StoredProcedure;
                    sql_cmnd.Parameters.AddWithValue("@Sigla", SqlDbType.VarChar).Value = Sigla;
                    sql_cmnd.Parameters.AddWithValue("@Nome", SqlDbType.Int).Value = Nome;

                    sql_cmnd.ExecuteNonQuery();

                    connection.Close();

                }
            }
            catch (SqlException erro)
            {
                Console.WriteLine("Erro ao se conectar no banco de dados \n" + erro);
                Console.ReadKey();
            }




        }

    }
}
