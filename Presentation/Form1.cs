using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Presentation
{
    public partial class Form1 : Form
    {
        #region Bien toan cuc
        XL_SINHVIEN BangSinhVien;
        XL_LOP BangLop;
        BindingManagerBase DSSV;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BangSinhVien = new XL_SINHVIEN();
            BangLop = new XL_LOP();

            LoadCBLop();
            LoadGVSinhVien();

            txtMaSV.DataBindings.Add("text", BangSinhVien, "MaSV", true);
            txtHoTen.DataBindings.Add("text", BangSinhVien, "HoTen", true);
            dateTimePickerNgaySinh.DataBindings.Add("text", BangSinhVien, "NgaySinh", true);
            radNam.DataBindings.Add("checked", BangSinhVien, "GioiTinh", true);
            cbbLop.DataBindings.Add("SelectedValue", BangSinhVien, "MaLop", true);
            txtDiaChi.DataBindings.Add("text", BangSinhVien, "DiaChi", true);

            DSSV = this.BindingContext[BangSinhVien];
        }

        private void LoadGVSinhVien()
        {
            gvSinhVien.AutoGenerateColumns = false;
            gvSinhVien.DataSource = BangSinhVien;
        }

        private void LoadCBLop()
        {
            cbbLop.DataSource = BangLop;
            cbbLop.DisplayMember = "TenLop";
            cbbLop.ValueMember = "MaLop";
        }
    }
}
