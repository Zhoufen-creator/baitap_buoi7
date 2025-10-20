using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entities;
using BUS;

namespace WF_DiemCong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCongTyData(CompanyService.GetAllCompanies());
            dgvNhanVienData(EmployeeService.GetAllEmployees());
            gbTTXN.Enabled = false;
        }
        private void dgvNhanVienData(List<NHANVIEN> list)
        {
            dgvNhanVien.Rows.Clear();
            foreach (var item in list)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = item.ID;
                dgvNhanVien.Rows[index].Cells[1].Value = item.HoTen;
                dgvNhanVien.Rows[index].Cells[2].Value = item.SoLanXN;
                dgvNhanVien.Rows[index].Cells[3].Value = item.AmTinh ? "Âm tính" : "+";
            }
        }
        private void cmbCongTyData(List<CONGTY> list)
        {
            cmbCongTy.DataSource = list;
            cmbCongTy.DisplayMember = "TenCty";
            cmbCongTy.ValueMember = "MaCty";
        }
        private void gbTTXNReset()
        {
            txtHoTen.Text = "";
            txtSLXN.Text = "1";
            radAmTinh.Checked = true;
            cmbCongTy.SelectedIndex = 0;
        }
        private void btTim_Click(object sender, EventArgs e)
        {
            if(txtCCCD.Text.Length != 9 && txtCCCD.Text.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập CCCD hoặc CMND", "Thông báo");
                return;
            }
            if (txtCCCD.Text.Any(char.IsLetter))
            {
                MessageBox.Show("ID chỉ là các kí tự số", "Thông báo");
                return;
            }
            var employee = EmployeeService.FindByID(txtCCCD.Text);
            if (employee == null)
            {
                gbTTXN.Enabled = true;
                txtHoTen.Text = "";
                txtSLXN.Text = "1";
                radAmTinh.Checked = true;
                cmbCongTy.SelectedIndex = 0;
                return;
            }
            else
            {
                gbTTXN.Enabled = true;
                txtHoTen.Text = employee.HoTen;
                txtSLXN.Text = (employee.SoLanXN+1).ToString();
                
               dgvNhanVien.CurrentCell = dgvNhanVien.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(r => r.Cells[0].Value.ToString() == employee.ID)?.Cells[0];
                


            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            var employee = EmployeeService.FindByID(txtCCCD.Text);
            if (employee == null)
            {
                NHANVIEN newEmployee = new NHANVIEN
                {
                    ID = txtCCCD.Text,
                    HoTen = txtHoTen.Text,
                    SoLanXN = int.Parse(txtSLXN.Text),
                    AmTinh = radAmTinh.Checked,
                    MaCty = cmbCongTy.SelectedValue.ToString()
                };
                EmployeeService.AddEmployee(newEmployee);
                MessageBox.Show("Thêm mới thành công", "Thông báo");
                dgvNhanVienData(EmployeeService.GetAllEmployees());
            }
            else
            {
                employee.SoLanXN = int.Parse(txtSLXN.Text);
                employee.AmTinh = radAmTinh.Checked;
                EmployeeService.UpdateEmployee(employee);
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                dgvNhanVienData(EmployeeService.GetAllEmployees());
            }
            gbTTXNReset();
        }

        private void danhSáchNVDươngTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvNhanVienData(EmployeeService.GetAllEmployees().Where(n => n.AmTinh == false).ToList());
        }

        private void danhSáchCtyĐãTestTheoYCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employees = EmployeeService.GetAllEmployees().Where(n => n.SoLanXN > 0).ToList();
            var companies = CompanyService.GetAllCompanies().Where(n => n.SLNV < employees.Count);

            StringBuilder sb = new StringBuilder();
            int stt = 1;
            foreach (var company in companies)
            {
                sb.AppendLine($"{stt}. {company.TenCty}");
                stt++;
            }
            MessageBox.Show("Các Công Ty đã test đủ Y/C:\n" + sb.ToString(), "Thông báo");
        }

        private void xuấtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 exportForm = new Form2();
            exportForm.ShowDialog();
        }
    }
}
