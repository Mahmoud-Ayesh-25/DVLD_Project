using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class clsCountries
    {
        public int CountryID { get; }
        public string CountryName { get; }

        public clsCountries()
        {
            CountryID = -1;
            CountryName = "";
        }

        private clsCountries(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static DataTable GetAllCountries()
        {
            return DVLD_DataLayer.clsCountries.GetAllCountries();
        }

        static public clsCountries Find(int ID)
        {
            int CountryID = ID;
            string CountryName = "";

            if (DVLD_DataLayer.clsCountries.GetCountryInfoByID(CountryID, ref CountryName))
                return new clsCountries(CountryID, CountryName);
            else
                return null;
        }

        static public clsCountries Find(string Name)
        {
            int CountryID = -1;
            string CountryName = Name;

            if (DVLD_DataLayer.clsCountries.GetCountryInfoByName(CountryName, ref CountryID))
                return new clsCountries(CountryID, CountryName);
            else
                return null;
        }
    }
}
