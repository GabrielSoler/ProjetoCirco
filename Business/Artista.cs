using Database;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Configuration;
using System.Data;

namespace Business
{
    public class Artista : Base
    {
        private string connectionString = ConfigurationManager.AppSettings["SqlConnection"];

        ///////////////////////DADOS PESSOAIS/////////////////////////
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, AutoIncrementar = true)]
        public int Id { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Funcao { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string DataNascimento { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string CPF { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Sexo { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Telefone { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Email { get; set; }

        ///////////////////////MEDIDAS/////////////////////////
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double OmbroAOmbro { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Ombro { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Colarinho { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double EntreCavasFrente { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double CentroCosta { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Busto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double AlturaBusto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double SeparacaoBusto { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Cintura { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Altura { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double AlturaQuadril { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Quadril { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double AlturaCinturaDoJoelho { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double AlturaCinturaAoTornozelo { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double ComprimentoBraco { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double LarguraBraco { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Punho { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double AlturaManga { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double AlturaMangaCurta { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double AlturaDesejadaDaSaia { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string CaminhoFotoArtista { get; set; }

        public new List<Artista> Todos()
        {
            var artistas = new List<Artista>();
            foreach (var ibase in base.Todos())
            {
                artistas.Add((Artista)ibase);
            }
            return artistas;

        }

        public override string ToString()
        {
            return this.Nome;
        }    

        public override void Salvar()
        {
            using (SqlConnection connection = new SqlConnection(
              connectionString))
            {
                List<string> campos = new List<string>();
                List<string> valores = new List<string>();

                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    OpcoesBase pOpcoesBase = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                    if (pOpcoesBase != null && pOpcoesBase.UsarNoBancoDeDados && !pOpcoesBase.AutoIncrementar)
                    {
                        if (this.Key == 0)
                        {
                            if (!pOpcoesBase.ChavePrimaria)
                            {
        
                                campos.Add(pi.Name);

                                if (pi.PropertyType.Name == "Double")
                                {
                                    valores.Add("'" + pi.GetValue(this).ToString().Replace(",", ".") + "'");             
                                }         
                                else
                                {
                                    valores.Add("'" + pi.GetValue(this) + "'");
                                }
                            }
                        }
                        else
                        {
                              if (pi.PropertyType.Name == "Double")
                              {
                                  valores.Add(" " + pi.Name + " = '" + pi.GetValue(this).ToString().Replace(",", ".") + "'");

                              }
                              else
                              {
                                  valores.Add(" " + pi.Name + " = '" + pi.GetValue(this) + "'");
                              }
                       }
                    }
                }

                string queryString = string.Empty;
            

                if (this.Key == 0)
                {
                    queryString = "insert into " + this.GetType().Name + "s (" + string.Join(", ", campos.ToArray()) + ")values(" + string.Join(", ", valores.ToArray()) + ");";
                }
                else
                {
                    queryString = "update " + this.GetType().Name + "s  set " + string.Join(", ", valores.ToArray()) + " where id = " + this.Key + ";";
                }
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
                
            }
        }

     /*   public byte[] BuscarFotoId(int Id)
        {
            using (SqlConnection connection = new SqlConnection(
                 connectionString))
            {

                string queryString = "SELECT FotoArtista FROM artistas WHERE id = " + Id;
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Console.WriteLine(reader.GetName(0));
                    byte[] buffer = new byte[reader.GetBytes(reader.GetOrdinal("FotoArtista"), 0, null, 0, int.MaxValue)];
                    reader.GetBytes(reader.GetOrdinal("FotoArtista"), 0, buffer, 0, int.MaxValue);
                    return buffer;
                }
                return null;
            }

        }*/

        public  List<Artista> BuscaNome(string name)
        {

            List<Artista> list = new List<Artista>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
                string queryString = "SELECT * FROM Artistas WHERE UPPER(NOME) LIKE '%"+ name +"%' ";
               
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {              
                    var obj = (IBase)Activator.CreateInstance(this.GetType());
                    setProperty(ref obj, reader);
                    list.Add((Artista)obj);
                    
                }              
            }
            return list;
        }
    }
}
