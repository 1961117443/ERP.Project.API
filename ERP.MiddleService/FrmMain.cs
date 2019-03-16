using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.MiddleService
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void menu_reg_Click(object sender, EventArgs e)
        {
            using (FrmReg frm = new FrmReg())
            {
                frm.ShowDialog();
            }
        }
    }
}
