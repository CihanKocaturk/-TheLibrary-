using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __TheLibrary.DAL
{
    public class Baglanti
    {
        public static SqlConnection conn = new SqlConnection("Server=.;Database=The_Library;Integrated Security=true");
    }
}
