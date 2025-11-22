using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsApplicationTypes
    {
        enum Modes { AddNew = 1, Update}
        Modes Mode = new Modes();

        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public float ApplicationTypeFees { get; set; }

        public clsApplicationTypes()
        {
            ApplicationTypeID = -1;
            ApplicationTypeTitle = string.Empty;
            ApplicationTypeFees = 0;

            Mode = Modes.AddNew;
        }

        public clsApplicationTypes(int ID, string Title, float Fees)
        {
            ApplicationTypeID = ID;
            ApplicationTypeTitle = Title;
            ApplicationTypeFees = Fees;

            Mode = Modes.Update;
        }

        bool _AddNew()
        {
            int ID = DVLD_DataLayer.clsApplicationTypes.AddNewApplicationType(ApplicationTypeTitle, ApplicationTypeFees);

            if (ID != -1)
            {
                ApplicationTypeID = ID;
                return true;
            }

            return false;
        }

        bool _Update()
        {
            return DVLD_DataLayer.clsApplicationTypes.UpdateApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationTypeFees);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Modes.AddNew:
                    {
                        if (_AddNew())
                        {
                            Mode = Modes.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case Modes.Update:
                    {
                        return _Update();
                    }
                default : return false;
            }
        }

        public static DataTable GetAllApplicationTypes()
        {
            return DVLD_DataLayer.clsApplicationTypes.GetAllApplicationTypes();
        }

        public static clsApplicationTypes GetApplicationTypeByID(int ID)
        {
            string Title = string.Empty;
            float Fees = 0;

            if (DVLD_DataLayer.clsApplicationTypes.GetApplicationTypeByID(ID, ref Title, ref Fees))
            {
                return new clsApplicationTypes(ID, Title, Fees);
            }
            else
            {
                return null;
            }
        }
    }
}
