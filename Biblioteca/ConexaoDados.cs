using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class ConexaoDados
    {
        private SqlConnection c1 = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private string campos;
        private byte[] foto;

        public string Campos { get => campos; set => campos = value; }
        public byte[] Foto { get => foto; set => foto = value; }

        public void conectar()
        {
            string sql = "Server =.\\SQLEXPRESS; Database = Biblioteca; UID = sa; PWD = 2810;";
            c1.ConnectionString = sql;
            c1.Open();
        }

        public void desconectar()
        {
            c1.Close();
        }

        public void executar(string sql)
        {
            conectar();
            cmd.Connection = c1;
            cmd.CommandText = sql;

            if (Foto != null)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@BINARIO", SqlDbType.Image);
                cmd.Parameters["@BINARIO"].Value = Foto;
            }

            cmd.ExecuteNonQuery();
            desconectar();
        }

        public DataSet listarDados(string sql)
        {
            conectar();
            SqlDataAdapter da = new SqlDataAdapter(sql, c1);

            DataSet ds = new DataSet();
            da.Fill(ds);
            desconectar();
            return ds;
        }

        public void consultarPorID(string sql)
        {
            conectar();
            cmd.Connection = c1;
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            Campos = "";

            if (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount - 1; i++)
                {
                    Campos += dr[i].ToString() + ";";
                }
                if (!(dr["Foto"] is System.DBNull))
                {
                    Foto = (byte[])dr["Foto"];
                }
                else
                {
                    Foto = null;
                }
            }
            desconectar();
        }
    }
}
