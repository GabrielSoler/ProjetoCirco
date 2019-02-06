using Database;
using System.Collections.Generic;
using System;


namespace Business
{
    public class Artista : Base
    {

        ///////////////////////DADOS PESSOAIS/////////////////////////
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, AutoIncrementar = true)]
        public int Id { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Nome { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Funcao { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public DateTime DataNascimento { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string CPF { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public char Sexo { get; set; }

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
        public double ComprimentoBraço { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double LarguraBraço { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Punho { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double AlturaManga { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double AlturaMangaCurta { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double AlturaDesejadaDaSaia { get; set; }

        [OpcoesBase(UsarNoBancoDeDados = true)]
        public byte[] FotoArtista { get; set; }
     

    }
}
