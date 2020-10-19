using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GenerarPDF.App_Code
{
    public class ControladorDB
    {

        private string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["DBGIA"].ConnectionString;


        private SqlConnection conectar()
        {
            SqlConnection con = new SqlConnection(conexion);

            return con;

        }

        public string queys(int tipo, string codigo) {

            string retorno = string.Empty;

            if (tipo == 1) {
                retorno = "select EMPCOD cantidad,DOCFCH detalle,TDOCCOD unitario,DOCSER IVA, DOCNUM Sub_Total from CABDOCUM where DOCNUM='" + codigo + "'";
            }

            return retorno;
        
        }

        public DataTable getDatatable(string sqlText)
        {
            SqlConnection con= null;
            DataTable dt = new DataTable();

            try
            {
                con = conectar();
                SqlCommand cmd = new SqlCommand(sqlText, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                con.Open();
                da.Fill(dt);
               
            }
            catch
            {

            }
            finally {
                con.Close();
            }
            return dt;


        }

    }



   

}