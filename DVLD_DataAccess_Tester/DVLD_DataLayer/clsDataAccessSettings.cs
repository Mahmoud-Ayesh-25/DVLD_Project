using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsDataAccessSettings
    {
        static string mdf_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DVLD", "DVLD.mdf");

        public static string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={mdf_path};Integrated Security=True;Connect Timeout=30";
    }
}
