using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using NobetListesi.Service;

namespace FRMNobetListesi
{
    public partial class FrmNobet : Form
    {
        SNobet _iNobet = new SNobet();
        int i, _ay;
        DataTable _dtNobetListesi;
        DataTable _dtKisiler;
        FrmListeyeEkleme frmListeyeEkleme;

        public FrmNobet()
        {
            InitializeComponent();
        }

        private void FrmNobet_Load(object sender, EventArgs e)

        {
            comboBoxilkTarih.Items.Insert(0, "Seçiniz");
            comboBoxilkTarih.Items.Insert(1, "Ocak");
            comboBoxilkTarih.Items.Insert(2, "Şubat");
            comboBoxilkTarih.Items.Insert(3, "Mart");
            comboBoxilkTarih.Items.Insert(4, "Nisan");
            comboBoxilkTarih.Items.Insert(5, "Mayıs");
            comboBoxilkTarih.Items.Insert(6, "Haziran");
            comboBoxilkTarih.Items.Insert(7, "Temmuz");
            comboBoxilkTarih.Items.Insert(8, "Ağustos");
            comboBoxilkTarih.Items.Insert(9, "Eylül");
            comboBoxilkTarih.Items.Insert(10, "Ekim");
            comboBoxilkTarih.Items.Insert(11, "Kasım");
            comboBoxilkTarih.Items.Insert(12, "Aralık");
            comboBoxilkTarih.SelectedIndex = 0;
        }

        private void BtnEkle_Click(object sender, EventArgs e)

        {
            frmListeyeEkleme = new FrmListeyeEkleme(1);
            frmListeyeEkleme.Show();
        }

        private void btnGoster_Click(object sender, EventArgs e)

        {



        }

        public void dataGridNobet_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            _dtNobetListesi = _iNobet.NobetListGrid();

            dataGridNobet.DataSource = _dtNobetListesi;
        }

        private void nobetTabloBindingSource_CurrentChanged(object sender, EventArgs e)

        {



        }

        private void comboBoxilkTarih_TextChanged(object sender, EventArgs e)
        {
            _ay = comboBoxilkTarih.SelectedIndex;
        }



        private void btnNobetListOlustur_Click(object sender, EventArgs e)
        {
            DataTable dtTest = new DataTable();
            string ayFormat = string.Empty;

            //dtTest.Columns.Add("TARIH");

            if (_ay <= 9)
            {
                ayFormat = string.Format("0{0}", _ay);
            }

            _dtKisiler = _iNobet.Kisiler(ayFormat);
            DataColumn cl = new DataColumn();
            cl.DataType = System.Type.GetType("System.String");
            cl.ColumnName = "TARIH";
            dtTest.Columns.Add(cl);
            DataColumn trh = new DataColumn();
            trh.DataType = System.Type.GetType("System.String");
            trh.ColumnName = "KISILER";
            dtTest.Columns.Add(trh);

            if (comboBoxilkTarih.SelectedIndex == 0)
            {
                MessageBox.Show("Hangi ayın nöbet listesini oluşturmak istiyorsanız o ayı seçmelisiniz.");
                return;
            }

            for (i = 1; i < 4; i++)
            {
                //dataGridNobet.Rows[0].
            }

            int days = DateTime.DaysInMonth(2023, _ay);

            for (int day = 1; day <= days; day++)
            {
                DataRow dr = dtTest.NewRow();
                dr["TARIH"] = new DateTime(2023, _ay, day);
                DateTime tarih = DateTime.Parse(dr["TARIH"].ToString());
                int gun = (int)tarih.DayOfWeek;

                if (gun == 6 || gun == 0)
                {
                    //haftasonu   
                }

                else
                {
                    dtTest.Rows.Add(dr);
                    dataGridNobet.DataSource = _dtKisiler;

                    //dataGridNobet.DataSource = dtTest;
                }
            }

            string kisiler = string.Empty;

            for (int i = 0; i < dtTest.Rows.Count; i++)
            {
                if (i < _dtKisiler.Rows.Count)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        kisiler = _dtKisiler.Rows[j + 1]["AD_SOYAD"].ToString();
                    }
                }

                dtTest.Rows[i]["KISILER"] = kisiler.ToString();
            }

            dataGridNobet.DataSource = dtTest;

        }
    }
}