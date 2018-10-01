using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class XL_BANG : DataTable
    {
        #region Bien cuc bo
        public string chuoiKetNoi = @"Data Source=SANG-LAPTOP\SQLEXPRESS;Initial Catalog=QLSINHVIEN4;Integrated Security=True";
        private SqlConnection ketNoi;
        private SqlDataAdapter boDocGhi;
        private string chuoiSQL;
        private string tenBang;
        #endregion
        #region Thuoc tinh
        public string ChuoiSQL { get => chuoiSQL; set => chuoiSQL = value; }
        public string TenBang { get => tenBang; set => tenBang = value; }
        public int SoDong { get => this.DefaultView.Count; }
        #endregion
        #region Phuong thuc khoi tao
        public XL_BANG() : base()
        {
        }

        public XL_BANG(string tenBang)
        {
            this.tenBang = tenBang;
            DocBang();
        }

        public XL_BANG(string tenBang, string chuoiSQL)
        {
            this.tenBang = tenBang;
            this.chuoiSQL = chuoiSQL;
            DocBang();
        }
        #endregion
        #region Cac phuong thuc xu ly
        public void DocBang()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
