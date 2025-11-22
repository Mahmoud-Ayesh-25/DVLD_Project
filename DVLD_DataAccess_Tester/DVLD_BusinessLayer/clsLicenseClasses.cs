using DVLD_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLicenseClasses
    {
        public int LicenseClassID {  get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefaultValidityLength { get; set; }
        public float ClassFees { get; set; }

        public clsLicenseClasses()
        {
            LicenseClassID = -1;
            ClassName = string.Empty;
            ClassDescription = string.Empty;
            MinimumAllowedAge = 0;
            DefaultValidityLength = 0;
            ClassFees = 0;
        }

        clsLicenseClasses(int licenseClassID, string className, string classDescription, int minimumAllowedAge,
            int defaultValidityLength, float classFees)
        {
            LicenseClassID = licenseClassID;
            ClassName = className;
            ClassDescription = classDescription;
            MinimumAllowedAge = minimumAllowedAge;
            DefaultValidityLength = defaultValidityLength;
            ClassFees = classFees;
        }

        public static DataTable GetAllLicenseClasses()
        {
            return DVLD_DataLayer.clsLicenseClasses.GetAllLicenseClasses();
        }

        public static clsLicenseClasses Find(int ID)
        {
            string ClassName = string.Empty;
            string ClassDescription = string.Empty;
            int MinimumAllowedAge = 0;
            int DefaultValidityLength = 0;
            float ClassFees = 0;

            if (DVLD_DataLayer.clsLicenseClasses.GetLicenseClassByID(ID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge,
                ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClasses(ID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else { return null; }
        }

        public static clsLicenseClasses Find(string ClassName)
        {
            int ID = -1;
            string ClassDescription = string.Empty;
            int MinimumAllowedAge = 0;
            int DefaultValidityLength = 0;
            float ClassFees = 0;

            if (DVLD_DataLayer.clsLicenseClasses.GetLicenseClassByName(ClassName, ref ID, ref ClassDescription, ref MinimumAllowedAge,
                ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClasses(ID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else { return null; }
        }
    }
}
