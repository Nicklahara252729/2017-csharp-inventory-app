using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoriApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             lockscreen.IsOpen = false;
        }

        private void lblkelolaharga_Click(object sender, EventArgs e)
        {

        }
        
        private void btnkelolaharga_MouseEnter(object sender, EventArgs e)
        {
            bothargabarang.Visible = true;
        }

        private void btnkelolaharga_MouseLeave(object sender, EventArgs e)
        {
            bothargabarang.Visible = false;
        }

        private void btndatabarang_MouseEnter(object sender, EventArgs e)
        {
            botbarang.Visible = true;
        }

        private void btndatabarang_MouseLeave(object sender, EventArgs e)
        {
            botbarang.Visible = false;
        }

        private void btndatasupplier_MouseEnter(object sender, EventArgs e)
        {
            botsup.Visible = true;
        }

        private void btndatasupplier_MouseLeave(object sender, EventArgs e)
        {
            botsup.Visible = false;
        }

        private void btndatapasok_MouseEnter(object sender, EventArgs e)
        {
            botpasok.Visible = true;
        }

        private void btndatapasok_MouseLeave(object sender, EventArgs e)
        {
            botpasok.Visible = false;
        }
        private void btnkelolaharga_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            pnldatabarang.Visible = false;
            pnldatapasok.Visible = false;
            pnldatasupplier.Visible = false;
            pnlhargabarang.Visible = true;
        }

        private void btndatabarang_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            pnldatabarang.Visible = true;
            pnldatapasok.Visible = false;
            pnldatasupplier.Visible = false;
            pnlhargabarang.Visible = false;
        }

        private void btndatasupplier_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            pnldatabarang.Visible = false;
            pnldatapasok.Visible = false;
            pnldatasupplier.Visible = true;
            pnlhargabarang.Visible = false;
        }
        private void btndatapasok_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = false;
            pnldatabarang.Visible = false;
            pnldatapasok.Visible = true;
            pnldatasupplier.Visible = false;
            pnlhargabarang.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ShowDataHarga();
            ShowBarang();
           
        }

        #region Menu Harga Barang
        public string id_harga, nominal, kurs, deskripsi;
        public void InsertDataHarga()
        {
            string query = string.Format("insert into tblharga values('" + id_harga + "','" + nominal + "','" + kurs + "','" + deskripsi + "')");
            var database = koneksi.GetOracleConnection();
            var command = database.CreateCommand();
            command.CommandText = query;
            database.Open();
            command.ExecuteNonQuery();
            database.Close();
            database.Dispose();
            command.Dispose();
        }

        public void Clear()
        {
            txtidharga.Clear();
            txtnominal.Clear();
            txtkurs.Clear();
            txtdeskripsi.Clear();
        }

        //menapilkan data harga barang pada data gridview
        public void ShowDataHarga()
        {
            try
            {
                using (OracleConnection conn = new OracleConnection("User ID=dbinventori" + ";Password=123" + ";Data Source='XE" + "'"))
                using (OracleCommand cmd = new OracleCommand("select * from tblharga", conn))
                {
                    conn.Open();
                    using(OracleDataReader reader = cmd.ExecuteReader()){
                        DataTable datatable = new DataTable();
                        datatable.Load(reader);
                        dgvkelola.DataSource = datatable;
                        dgvkelola.Columns[0].HeaderText = "ID HARGA";
                        dgvkelola.Columns[1].HeaderText = "NOMINAL";
                        dgvkelola.Columns[2].HeaderText = "KURS";
                        dgvkelola.Columns[3].HeaderText = "DESKRIPSI";
                        dgvkelola.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvkelola.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvkelola.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvkelola.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

     
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 HARGA = new Form1{
                    id_harga = txtidharga.Text,
                nominal = txtnominal.Text,
                kurs = txtkurs.Text,
                deskripsi = txtdeskripsi.Text
            };
                HARGA.InsertDataHarga();
                MessageBox.Show("Data Berhasil Disimpan");
                ShowDataHarga();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            Reporting rpt = new Reporting();
            rpt.ReportHargaBarang();
        }

        #region Menu Barang
        public string kode_barang, nama_barang, satuan, stok_barang, id_hargabr;
        public void InsertBarang()
        {
            string query = string.Format("insert into tblbarang values('" + kode_barang + "','" + nama_barang + "','" + id_harga + "')");
            var database = koneksi.GetOracleConnection();
            var command = database.CreateCommand();
            command.CommandText = query;
            database.Open();
            command.ExecuteNonQuery();
            database.Close();
            database.Dispose();
            command.Dispose();
        }

        public void ShowBarang(){
            try
            {
                using (OracleConnection conn = new OracleConnection("User ID=dbinventori" + ";Password=123" + ";Data Source='XE" + "'"))
                using (OracleCommand cmd = new OracleCommand("select * from tblbarang", conn))
                {
                    conn.Open();
                    using(OracleDataReader reader = cmd.ExecuteReader()){
                        DataTable datatable = new DataTable();
                        datatable.Load(reader);
                        dgvdatabarang.DataSource = datatable;
                        dgvdatabarang.Columns[0].HeaderText = "ID HARGA";
                        dgvdatabarang.Columns[1].HeaderText = "NOMINAL";
                        dgvdatabarang.Columns[2].HeaderText = "KURS";
                        dgvdatabarang.Columns[3].HeaderText = "DESKRIPSI";
                        dgvdatabarang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvdatabarang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvdatabarang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvdatabarang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btndbarangexport_Click(object sender, EventArgs e)
        {
            Reporting rpt = new Reporting();
            rpt.ReportDataBarang();
        }

        private void btndsupexport_Click(object sender, EventArgs e)
        {
            Reporting rpt = new Reporting();
            rpt.ReportDatasSupplier();
        }

        private void btndpasokexport_Click(object sender, EventArgs e)
        {
            Reporting rpt = new Reporting();
            rpt.ReportDatasSupplier();
        }

        private void bothargabarang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeSlideSide(eSlideSide side)
        {
            lockscreen.SlideSide = side;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnlock_Click(object sender, EventArgs e)
        {

            lockscreen.IsOpen = true;
         
            ChangeSlideSide(eSlideSide.Left);
        }

        private void openscreen_Click(object sender, EventArgs e)
        {
            lockscreen.IsOpen = false;
            
            ChangeSlideSide(eSlideSide.Left);
        }
    }
}
