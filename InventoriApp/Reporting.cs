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
    public partial class Reporting : Form
    {
        public Reporting()
        {
            InitializeComponent();
        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
            
        }


        public void ReportHargaBarang()
        {
            var reportHarga = new crharga();
            try
            {
                using(OracleConnection conn= new OracleConnection("User ID=dbinventori"+";Password=123"+";Data Source='XE"+"';"))
                using (OracleCommand cmd = new OracleCommand("select * from tblharga", conn))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds, "Harga");
                    reportHarga.SetDataSource(ds);
                    crvviewdata.ReportSource = null;
                    crvviewdata.ReportSource = reportHarga;
                    crvviewdata.Zoom(1);
                }
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void ReportDataBarang()
        {
            var reportData = new crdata();
            try
            {
                using (OracleConnection conn = new OracleConnection("User ID=dbinventori" + ";Password=123" + ";Data Source='XE" + "';"))
                using (OracleCommand cmd = new OracleCommand("select * from tblbarang", conn))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds, "Barang");
                    reportData.SetDataSource(ds);
                    crvviewdata.ReportSource = null;
                    crvviewdata.ReportSource = reportData;
                    crvviewdata.Zoom(1);
                }
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void ReportDataPasok()
        {
            var reportPasok = new crpasok();
            try
            {
                using (OracleConnection conn = new OracleConnection("User ID=dbinventori" + ";Password=123" + ";Data Source='XE" + "';"))
                using (OracleCommand cmd = new OracleCommand("select * from tblpasok", conn))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds, "Pasok");
                    reportPasok.SetDataSource(ds);
                    crvviewdata.ReportSource = null;
                    crvviewdata.ReportSource = reportPasok;
                    crvviewdata.Zoom(1);
                }
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void ReportDatasSupplier()
        {
            var reportSup = new crsuplier();
            try
            {
                using (OracleConnection conn = new OracleConnection("User ID=dbinventori" + ";Password=123" + ";Data Source='XE" + "';"))
                using (OracleCommand cmd = new OracleCommand("select * from tblsuplier", conn))
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(ds, "Suplier");
                    reportSup.SetDataSource(ds);
                    crvviewdata.ReportSource = null;
                    crvviewdata.ReportSource = reportSup;
                    crvviewdata.Zoom(1);
                }
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void bntclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
