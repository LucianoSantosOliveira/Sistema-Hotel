using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace cc
{
    class Class1
    {
        //banco de dados local
        string conexao = "SERVER=localhost; DATABASE=hotel; UID=root; PWD=; PORT=;";
        public MySqlConnection con = null;


      public void abrircon()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
        public void fechacon()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }







    }




}
