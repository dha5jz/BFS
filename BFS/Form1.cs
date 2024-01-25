using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbBFD.Visible = false;
            lbBFDcotrongso.Visible = false;
            ptBKhongTrongSo.Visible = false;
            ptbCoTrongSO.Visible = false;
            txtDinh.Enabled = false;
            txtDinhKe.Enabled = false;
            txtSoDinh.Enabled = false;
            txtTrongSo.Enabled = false;
            btnADD.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            grbChucNang.Visible = false;
            lstBFSco.Visible = false;
            lstDanhSachBFSkhong.Visible = false;
        }

        private void btnBFDko_Click(object sender, EventArgs e)
        {
            lblThongBao.Visible = false;
            lbBFD.Visible = true;
            lbBFDcotrongso.Visible = false;
            txtDinh.Enabled = true;
            txtDinhKe.Enabled = true;
            txtSoDinh.Enabled = true;
            txtTrongSo.Visible= false;
            lstDanhSachBFSkhong.Visible = true;
            lstBFSco.Visible = false;
            lbTrongso.Visible = false;
            ptBKhongTrongSo.Visible = true;
            ptbCoTrongSO.Visible = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnADD.Enabled = true;
            grbChucNang.Visible = true;
        }

        private void btnBFDco_Click(object sender, EventArgs e)
        {
            lblThongBao.Visible = false;
            lbBFD.Visible = false;
            lbBFDcotrongso.Visible = true;
            txtDinh.Enabled = true;
            txtDinhKe.Enabled = true;
            txtSoDinh.Enabled = true;
            lstDanhSachBFSkhong.Visible = false;
            lstBFSco.Visible = true;
            txtTrongSo.Visible = true;
            txtTrongSo.Enabled = true;
            lbTrongso.Visible = true;
            ptBKhongTrongSo.Visible = false;
            ptbCoTrongSO.Visible = true;
            btnADD.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            grbChucNang.Visible = true;
        }

        private void txtSoDinh_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSoDinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và các phím điều hướng (arrow keys, backspace, delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào TextBox
            }
        }

        private void txtTrongSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và các phím điều hướng (arrow keys, backspace, delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào TextBox
            }
        }

        private void txtDinhKe_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDinhKe_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập chữ cái, số, và dấu phẩy
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetterOrDigit(e.KeyChar) &&
                e.KeyChar != ',')
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào TextBox
            }

            
        }

        private void txtDinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập chữ hoặc số
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào TextBox
            }
        }
    }
}
