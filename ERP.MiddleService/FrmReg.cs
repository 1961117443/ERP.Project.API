using ERP.Project.Common.Helper; 
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
    public partial class FrmReg : Form
    {
        public FrmReg()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IDictionary<string, string> data = new Dictionary<string, string>();
            data.Add("Name", txtName.Text);
            data.Add("Password", txtPwd.Text);
            data.Add("ComputeInfo", txtPwd.Text);

            // var v1 = ApiHelper.Get("http://localhost:9990/api/Customer/get?id=1");
            
            var result = ApiHelper.Post("http://localhost:9990/api/Customer/create", JsonHelper.ObjectToString(data));

            MessageBox.Show(result);
             
        }
    }
}
