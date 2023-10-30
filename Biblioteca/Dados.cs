using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Dados
    {
        private int idLivros;
        private string titulo;
        private string autor;
        private string genero;
        private int anoPublicacao;
        private string disponibilidade;
        private byte[] foto;

        private ConexaoDados objetoConexao = new ConexaoDados();

        public int IdLivros { get => idLivros; set => idLivros = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Genero { get => genero; set => genero = value; }
        public int AnoPublicacao { get => anoPublicacao; set => anoPublicacao = value; }
        public string Disponibilidade { get => disponibilidade; set => disponibilidade = value; }
        public byte[] Foto { get => foto; set => foto = value; }

        public void incluirDados()
        {

            string sql = "";

            if (Foto != null)
            {
                sql += $"INSERT INTO Livros (Titulo, Autor, Genero, AnoPublicacao, Disponibilidade, Foto)" +
                $"VALUES ('{Titulo}', '{Autor}', '{Genero}', '{AnoPublicacao}', '{Disponibilidade}',@BINARIO)";
                objetoConexao.Foto = foto;
            }
            else
            {
                sql += $"INSERT INTO Livros (Titulo, Autor, Genero, AnoPublicacao, Disponibilidade)" +
                    $"VALUES ('{Titulo}', '{Autor}', '{Genero}', '{AnoPublicacao}', '{Disponibilidade}')";
            }
            objetoConexao.executar(sql);
        }

        public void alterarDados()
        {
            string sql = "";

            if (Foto != null)
            {
                sql += $"UPDATE Livros SET Autor = '{Autor}', Genero = '{Genero}', AnoPublicacao = '{AnoPublicacao}', Disponibilidade = '{Disponibilidade}', Foto = @BINARIO " +
                         $"WHERE idLivro = " + IdLivros.ToString();
                objetoConexao.Foto = foto;
            }
            else
            {
                sql += $"UPDATE Livros SET Autor = '{Autor}', Genero = '{Genero}', AnoPublicacao = '{AnoPublicacao}', Disponibilidade = '{Disponibilidade}' " +
                         $"WHERE idLivro = " + IdLivros.ToString();
            }
            objetoConexao.executar(sql);
        }


        public DataSet pesquisarDados()
        {
            string sql = "SELECT * FROM Livros";
            return objetoConexao.listarDados(sql);
        }

        public void pesquisarPorID()
        {
            string sql = "SELECT * FROM Livros WHERE idLivro = " + idLivros.ToString();
            objetoConexao.consultarPorID(sql);

            string[] vetorCampos = objetoConexao.Campos.Split(';');
            autor = vetorCampos[2];
            genero = vetorCampos[3];
        
            if (int.TryParse(vetorCampos[4], out int ano))
            {
                anoPublicacao = ano;
            }
            else
            {
                anoPublicacao = 0; 
            }
            disponibilidade = vetorCampos[5];

            foto = objetoConexao.Foto;
        }

        public void excluirDados()
        {
            string sql = $"DELETE FROM Livros WHERE idLivro = " + IdLivros.ToString();
            objetoConexao.executar(sql);
        }


        public DataSet buscarGenero()
        {
            string sql = "SELECT * FROM Livros WHERE Genero LIKE'" + Genero + "%'";
            return objetoConexao.listarDados(sql);
        }

        public DataSet buscarAnoPublicacao()
        {
            string sql = "SELECT * FROM Livros WHERE AnoPublicacao LIKE'" + AnoPublicacao + "%'";
            return objetoConexao.listarDados(sql);
        }

        public DataSet buscarTitulo()
        {
            string sql = "SELECT * FROM Livros WHERE Titulo LIKE'" + Titulo + "%'";
            return objetoConexao.listarDados(sql);
        }
        public DataSet buscarAutor()
        {
            string sql = "SELECT * FROM Livros WHERE Autor LIKE'" + Autor + "%'";
            return objetoConexao.listarDados(sql);
        }
    }
}
