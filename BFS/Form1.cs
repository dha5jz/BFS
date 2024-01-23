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
            grbChucNang.Visible = false;
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
            lbTrongso.Visible = false;
            ptBKhongTrongSo.Visible = true;
            ptbCoTrongSO.Visible = false;
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
            txtTrongSo.Visible = true;
            txtTrongSo.Enabled = true;
            lbTrongso.Visible = true;
            ptBKhongTrongSo.Visible = false;
            ptbCoTrongSO.Visible = true;
            btnADD.Enabled = true;
            grbChucNang.Visible = true;
        }
    }
}
