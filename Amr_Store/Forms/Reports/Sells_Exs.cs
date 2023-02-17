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
    public partial class Sells_Exs : Form
    {
        Msgs msg;
        public Sells_Exs()
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
            int ex = 0;
            int def = 0;

            foreach(DataGridViewRow r in dgv_Data.Rows)
            {
                erad += Convert.ToInt32(r.Cells["الإيراد"].Value);
                ex += Convert.ToInt32(r.Cells["المصاريف"].Value);
                def += Convert.ToInt32(r.Cells["الفرق"].Value);
            }

            lbl_Erad.Text = "إجمالي الإيراد: " + erad;
            lbl_Ex.Text = "إجمالي المصاريف: " + ex;
            lbl_Def.Text = "إجمالي الفرق: " + def;
        }

        public void GetDataFromDB(string Where)
        {
            myDB.DGVs("SELECT S.InDay اليوم, ISNULL(S.Total, 0) الإيراد, ISNULL(E.Amount, 0) المصاريف" +
                ", (ISNULL(S.Total, 0) - ISNULL(E.Amount, 0)) الفرق FROM (SELECT InDay, SUM(Total) Total" +
                " FROM Sells GROUP BY InDay) AS S LEFT JOIN (SELECT InDay, SUM(Amount) Amount FROM Exs " +
                "GROUP BY InDay) AS E ON S.InDay = E.InDay " + Where + " ORDER BY S.InDay", dgv_Data);
        }

        private void Btn_Filter_Click(object sender, EventArgs e)
        {
            string year = cbox_Year.Text.Substring(2);
            string month = (cbox_Month.SelectedIndex + 1).ToString();
            if (month.Count() > 2) month = "0" + month;

            GetDataFromDB("WHERE S.InDay LIKE('" + year + "." + month + ".%')");

            if(dgv_Data.Rows.Count < 1)
            {
                msg.ShowError("فشل إظهار التقرير، تأكد من المعلومات المدخلة");
                btn_Refresh.PerformClick();
                return;
            }

            Calc_Totals();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            // Load Data From DB
            GetDataFromDB(null);

            // Calculate totals
            Calc_Totals();
        }
    }
}
