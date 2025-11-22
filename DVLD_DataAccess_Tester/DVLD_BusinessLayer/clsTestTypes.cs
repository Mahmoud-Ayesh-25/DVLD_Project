using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestTypes
    {
        enum Modes { AddNew = 1, Update}
        Modes Mode;
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Fees { get; set; }

        public clsTestTypes()
        {
            ID = -1;
            Title = string.Empty;
            Description = string.Empty;
            Fees = 0;

            Mode = Modes.AddNew;
        }
        clsTestTypes(int ID,  string Title, string Description, float Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;

            Mode = Modes.Update;
        }

        public static DataTable GetAllTestTypes()
        {
            return DVLD_DataLayer.clsTestTypes.GetAllTestTypes();
        }

        public static clsTestTypes Find(int ID)
        {
            string Title = string.Empty;
            string Description = string.Empty;
            float Fees = 0;

            if (DVLD_DataLayer.clsTestTypes.FindTestTypeByID(ID, ref Title, ref Description, ref Fees))
            {
                return new clsTestTypes(ID, Title, Description, Fees);
            }
            else
            {
                return null;
            }
        }

        bool _Add()
        {
            int id = DVLD_DataLayer.clsTestTypes.AddNewTestType(Title, Description, Fees);

            if (id != -1)
            {
                ID = id;
                return true;
            }
            else { return false; }
        }

        bool _Update()
        {
            return DVLD_DataLayer.clsTestTypes.UpdateTestType(ID, Title, Description, Fees);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Modes.AddNew:
                    {
                        if (_Add())
                        {
                            Mode = Modes.Update;
                            return true;
                        }
                        else return false;
                    }
                case Modes.Update:
                    {
                        return _Update();
                    }
                default: return false;
            }
        }

    }
}
