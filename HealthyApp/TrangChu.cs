
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HealthyApp
{
    public partial class TrangChu : Form
    {
        KetNoi conn = new KetNoi();
        public TrangChu()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        String truyvan(String time)
        {
            return string.Format("select Tennguyenlieu,Soluong,case when Ghichu is null then '' else Ghichu end as Ghichu from thucdon where Buaan = '{0}' and Thoigian = '{1}'"
                                , time, dateTimeTrangChu.Value); ;
        }


        void tailai()
        {
            String time = "Sang";
            DataTable dt = new DataTable();
            dt = conn.LayDuLieu(truyvan(time));
            dataGridSang.DataSource = dt;
            time = "Trua";
            dt = conn.LayDuLieu(truyvan(time));
            dataGridTrua.DataSource = dt;
            time = "Toi";
            dt = conn.LayDuLieu(truyvan(time));
            dataGridToi.DataSource = dt;
            conn.renameDTV(dataGridSang);
            conn.renameDTV(dataGridTrua);
            conn.renameDTV(dataGridToi);
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            dateTimeTrangChu.Value = DateTime.Now;
        }

        private void dateTimeTrangChu_ValueChanged(object sender, EventArgs e)
        {
            tailai();
        }

        void buttonClick(String time)
        {
            ThucDon thucDon = new ThucDon(time, dateTimeTrangChu.Value);
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            thucDon.MdiParent = this.MdiParent;
            thucDon.Dock = DockStyle.Fill;
            this.MdiParent.ClientSize = thucDon.Size;
            thucDon.Show();
        }
        private void buttonSang_Click(object sender, EventArgs e)
        {
            buttonClick("Sang");
        }

        private void buttonTrua_Click(object sender, EventArgs e)
        {
            buttonClick("Trua");
        }

        private void buttonToi_Click(object sender, EventArgs e)
        {
            buttonClick("Toi");
        }
    }
}