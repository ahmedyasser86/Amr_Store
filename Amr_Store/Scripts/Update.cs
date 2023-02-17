using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motaz_Store
{
    class Update
    {
        private static int CurrentVersion = 2;

        public static bool CheckForUpdates()
        {
            // Get Version From DB
            int ver = Convert.ToInt32(myDB.GetDataString("SELECT Value FROM Settings WHERE Setting = 'Version'"));
            if(ver < CurrentVersion)
            {
                return StartUpdate();
            }
            return true;
        }

        private static bool StartUpdate()
        {
            try
            {
                // Static Updates are being Changed every Version

                #region 1- Add F_Price Value to Sells Table

                // Get F_Prices From Prices Table Foreach sold product
                DataTable dt_Prices =  myDB.GetDataTable("SELECT distinct s.P_ID P_ID, pp.F_Price FROM Sells s " +
                    "INNER JOIN Products p ON S.P_ID = p.ID INNER JOIN Products_Prices pp " +
                    "ON p.Art = pp.Art");

                // Update Sells Table
                foreach(DataRow r in dt_Prices.Rows)
                {
                    // r[0] = ID, r[1] F_Price
                    myDB.CmdExcute("UPDATE Sells SET F_Price=" + r[1] + " WHERE P_ID=@P_ID", new string[]
                    { "@P_ID",  r[0].ToString() });
                }

                #endregion 1- Add F_Price Value to Sells Table

                // Update Version in db
                myDB.CmdExcute("UPDATE Settings SET Value = " + CurrentVersion + " WHERE Setting='Version'");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
