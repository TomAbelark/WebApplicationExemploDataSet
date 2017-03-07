using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationExemploDataSet.Funcoes
{
    public class Conexao
    {

        string conn = "Data Source=TOM-PC;Initial Catalog=VETORH;User ID=sa;Password=sabbath123";

        /// <summary>
        /// Metodo para retornar DataSet conforme parametro passado na funcao
        /// </summary>
        /// <param name="sql"> Comando sql para carregar DataSet </param>
        /// <returns></returns>
        public DataSet AbrirColaboradores(String sql)
        {
            SqlConnection cnx = new SqlConnection(conn);
            cnx.Open();

            SqlDataAdapter adp = new SqlDataAdapter(sql, cnx);
            DataSet dts = new DataSet();
            adp.Fill(dts);

            return dts;


        }
    }
}