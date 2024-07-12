using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NobetListesi.Service;

namespace FRMNobetListesi
{
    public partial class FrmListeyeEkleme : Form
    {
        SNobet _iNobet = new SNobet();
        string _AD_SOYAD, _TEL_NO, _MAIL;
        public FrmListeyeEkleme(int d)
        {
            InitializeComponent();
        }

        private void TextAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void TextMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextTelNo_TextChanged(object sender, EventArgs e)

        {

        }

        private void TextTelNo_MouseClick(object sender, MouseEventArgs e)
        {
            TextTelNo.Text = "";
        }

        private void FrmListeyeEkleme_Load(object sender, EventArgs e)

        {



        }

        private void TextTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (TextTelNo.Text.Length < 11)
            {
                MessageBox.Show("Hatalı telefon numarası girdiniz");
            }

            else if (TextMail.Text.Contains("@") == false || TextMail.Text.Contains(".") == false || TextMail.Text.Length < 8)
            {
                MessageBox.Show("Lütfen geçerli bir mail adresi giriniz!");
            }

            else
            {
                _AD_SOYAD = TextAdSoyad.Text;

                _TEL_NO = TextTelNo.Text;

                _MAIL = TextMail.Text;

                _iNobet.NobetList(_AD_SOYAD, _TEL_NO, _MAIL);
            }

            TextAdSoyad.Clear();
            TextTelNo.Clear();
            TextMail.Clear();

            MessageBox.Show("Kullanıcı kaydedilmiştir");
        }
    }
}