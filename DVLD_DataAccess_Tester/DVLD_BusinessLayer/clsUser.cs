using DVLD_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsUser
    {
        enum Modes { AddNew = 1, Update}
        Modes Mode;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser()
        {
            Mode = Modes.AddNew;
            UserID = -1;
            PersonID = -1;
            Username = "";
            Password = "";
            IsActive = true;
        }

        private clsUser(int ID, int PersonID,  string Username, string Password, bool IsActive)
        {
            this.UserID = ID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = Modes.Update;
        }

        public static DataTable GetAllUsers()
        {
            return DVLD_DataLayer.clsUser.GetAllUsers();
        }

        bool _AddNewUser()
        {
            int UserID = DVLD_DataLayer.clsUser.AddNewUser(PersonID, Username, Password, IsActive);

            this.UserID = UserID;

            return (UserID != -1);
        }

        bool _UpdateUser()
        {
            return DVLD_DataLayer.clsUser.UpdateUser(UserID, PersonID, Username, Password, IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Modes.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = Modes.Update;
                        return true;
                    }
                    else
                        return false;
                case Modes.Update:
                    return _UpdateUser();
                default: return false;
            }
        }

        public static clsUser FindByID(int ID)
        {
            int PersonID = -1;
            string Username = "";
            string Password = "";
            bool IsActive = true;

            if (DVLD_DataLayer.clsUser.GetUserInfoByUserID(ID, ref PersonID, ref Username, ref Password, ref IsActive))
            {
                return new clsUser(ID, PersonID, Username, Password, IsActive);
            }
            else return null;
        }

        public static clsUser FindByPersonID(int PersonID)
        {
            int ID = -1;
            string Username = "";
            string Password = "";
            bool IsActive = true;

            if (DVLD_DataLayer.clsUser.GetUserInfoByPersonID(PersonID, ref ID, ref Username, ref Password, ref IsActive))
            {
                return new clsUser(ID, PersonID, Username, Password, IsActive);
            }
            else return null;
        }

        public static clsUser FindByUsernameAndPassword(string Username, string Password)
        {
            int ID = -1;
            int PersonID = -1;
            bool IsActive = true;

            if (DVLD_DataLayer.clsUser.GetUserInfoByUsernameAndPassword(Username, Password, ref ID, ref PersonID, ref IsActive))
            {
                return new clsUser(ID, PersonID, Username, Password, IsActive);
            }
            else return null;
        }

        public static bool IsExist(int ID)
        {
            return DVLD_DataLayer.clsUser.IsUserExist(ID);
        }

        public static bool IsExist(string Username)
        {
            return DVLD_DataLayer.clsUser.IsUserExist(Username);
        }

        public static bool IsExistByPersonID(int PersonID)
        {
            return DVLD_DataLayer.clsUser.IsUserExistByPersonID(PersonID);
        }

        public static bool DeleteUser(int ID)
        {
            return DVLD_DataLayer.clsUser.DeleteUser(ID);
        }
    }
}
