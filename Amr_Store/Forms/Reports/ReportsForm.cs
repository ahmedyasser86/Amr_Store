using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Motaz_Store.Visual_Scripts;
using static Motaz_Store.Forms;

namespace Motaz_Store
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void Top_Btns_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            Btn_Click_Color(pnl_Top, new Color[] { Color.FromArgb(191, 113, 44), Color.FromArgb(242, 229, 213) },
                new Color[] { Color.FromArgb(242, 229, 213), Color.FromArgb(89, 25, 2) }, btn);
            Btn_Move_Line(btn, pnl_Line);

            switch (btn.Name)
            {
                case "btn_Sells":
                    FrmToPnl(Pnl_Holder, sells_Exs);
                    break;

                case "btn_Sells_FPrice":
                    FrmToPnl(Pnl_Holder, sells_FPrice);
                    break;

            }
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            btn_Sells.PerformClick();
        }
    }
}
