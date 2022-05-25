using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eczane_Otomasyonu
{
   
   public class Log
    {
        SQL s = new SQL();
        public void log(string islem ,string yekili) 
        {
            string komut = "insert Log_Table (islem,zaman,yetkili) values (@islem,@zaman,@yetkili)";

            SqlCommand kmt = new SqlCommand(komut);
            kmt.Parameters.AddWithValue("@islem",islem);
            //kmt.Parameters.AddWithValue("@zaman",DateTime.Now);
            kmt.Parameters.AddWithValue("@zaman", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            kmt.Parameters.AddWithValue("@yetkili",girisForm.kuladi.ToString());
            s.komut(kmt);
            
        }
    }
}
