using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motaz_Store
{
    public partial class Sells_FPrice : Form
    {
        Msgs msg;
        public Sells_FPrice()
        {
            InitializeComponent();

            // Messages Handler
            msg = new Msgs(lbl_Error);

            // Load Data From DB
            GetDataFromDB(null);

            // Calculate totals
            Calc_Totals();
        }

        public void Calc_Totals()
        {
            int erad = 0;
            int f = 0;
            int def = 0;

            foreach (DataGridViewRow r in dgv_Data.Rows)
            {
                erad += Convert.ToInt32(r.Cells["المباع"].Value);
                f += Convert.ToInt32(r.Cells["الجملة"].Value);
                def += Convert.ToInt32(r.Cells["الفرق"].Value);
            }

            lbl_Erad.Text = "إجمالي المباع: " + erad;
            lbl_f.Text = "إجمالي الجملة: " + f;
            lbl_Def.Text = "إجمالي الفرق: " + def;
        }

        public void GetDataFromDB(string Where)
        {
            myDB.DGVs("SELECT s.InDay, ISNULL(SUM(s.Total), 0) 'المباع', ISNULL(SUM(s.F_Price), 0) 'الجملة'" +
                ", (ISNULL(SUM(s.Total), 0) - ISNULL(SUM(s.F_Price), 0)) 'الفرق' FROM Sells s " + Where +
                " GROUP BY s.InDay ORDER BY s.InDay", dgv_Data);
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            // Load Data From DB
            GetDataFromDB(null);

            // Calculate totals
            Calc_Totals();
        }

        private void Btn_Filter_Click(object sender, EventArgs e)
        {
            string year = cbox_Year.Text.Substring(2);
            string month = (cbox_Month.SelectedIndex + 1).ToString();
            if (month.Count() > 2) month = "0" + month;

            GetDataFromDB("WHERE S.InDay LIKE('" + year + "." + month + ".%')");

            if (dgv_Data.Rows.Count < 1)
            {
                msg.ShowError("فشل إظهار التقرير، تأكد من المعلومات المدخلة");
                btn_Refresh.PerformClick();
                return;
            }

            Calc_Totals();
        }
    }
}
