using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyApp
{

    internal class KetNoi
    {
        SqlConnection conn;
        string str = "Data Source=localhost;Initial Catalog=HealthyApp;Integrated Security=True";
        public KetNoi()
        {
            conn = new SqlConnection(str);
        }

        public DataTable LayDuLieu(string truy_van)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(truy_van, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public bool Thucthi(string truy_van)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(truy_van, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            return a > 0;
        }
        public void renameDTV(DataGridView a)
        {
            a.Visible = true;
            //a.Columns["Tenthucdon"].HeaderCell.Value = "Tên thực đơn";
            a.Columns["Tennguyenlieu"].HeaderCell.Value = "Món ăn";
            a.Columns["Soluong"].HeaderCell.Value = "Số lượng";
            a.Columns["Ghichu"].HeaderCell.Value = "Ghi chú";
            a.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            a.Columns["Ghichu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
