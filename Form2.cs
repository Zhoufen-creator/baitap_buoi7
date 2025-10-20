using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace WF_DiemCong
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            cmbCongTyData(CompanyService.GetAllCompanies());
            reportViewer1.Enabled = true;
        }
        private void cmbCongTyData(List<CONGTY> list)
        {
            cmbCongTy.DataSource = list;
            cmbCongTy.DisplayMember = "TenCty";
            cmbCongTy.ValueMember = "MaCty";
        }
    }
}
