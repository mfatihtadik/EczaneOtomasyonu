using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Eczane_Otomasyonu
{
    public class SQL
    {
        public SqlConnection baglantikur()
        {

            
            SqlConnection baglanacaksql = new SqlConnection("Data Source=localhost;Initial Catalog=ECZANE;Integrated Security=True");
            return baglanacaksql;

        }
        public void komut(SqlCommand kmt)
        {

            SqlConnection sql = baglantikur();

            sql.Open();
            kmt.Connection = sql;
            kmt.ExecuteNonQuery();
            sql.Close();
        }

            /*
                string komutum = "insert into tabloadı (sutunadı1,sutunadı2) Values (@parametre1,@parametre2)";
                SqlCommand sqlcomut = new SqlCommand(komutum);
                sqlcomut.Parameters.AddWithValue("@parametre1", "213"); 
                sqlcomut.Parameters.AddWithValue("@parametre2", "213"); 
                S.komut(sqlcomut);
             */


        }
}
