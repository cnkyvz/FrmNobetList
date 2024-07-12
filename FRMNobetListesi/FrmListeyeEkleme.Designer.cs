
namespace FRMNobetListesi
{
    partial class FrmListeyeEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextMail = new System.Windows.Forms.TextBox();
            this.TextTelNo = new System.Windows.Forms.TextBox();
            this.TextAdSoyad = new System.Windows.Forms.TextBox();
            this.listeyeEklelable = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefon Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(48, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "İsim Soyisim";
            // 
            // TextMail
            // 
            this.TextMail.Location = new System.Drawing.Point(117, 148);
            this.TextMail.MaxLength = 150;
            this.TextMail.Name = "TextMail";
            this.TextMail.Size = new System.Drawing.Size(120, 20);
            this.TextMail.TabIndex = 24;
            this.TextMail.TextChanged += new System.EventHandler(this.TextMail_TextChanged);
            // 
            // TextTelNo
            // 
            this.TextTelNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextTelNo.Location = new System.Drawing.Point(117, 122);
            this.TextTelNo.MaxLength = 11;
            this.TextTelNo.Name = "TextTelNo";
            this.TextTelNo.Size = new System.Drawing.Size(120, 20);
            this.TextTelNo.TabIndex = 23;
            this.TextTelNo.Text = "05**********";
            this.TextTelNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextTelNo_MouseClick);
            this.TextTelNo.TextChanged += new System.EventHandler(this.TextTelNo_TextChanged);
            this.TextTelNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTelNo_KeyPress);
            // 
            // TextAdSoyad
            // 
            this.TextAdSoyad.Location = new System.Drawing.Point(117, 96);
            this.TextAdSoyad.MaxLength = 50;
            this.TextAdSoyad.Name = "TextAdSoyad";
            this.TextAdSoyad.Size = new System.Drawing.Size(120, 20);
            this.TextAdSoyad.TabIndex = 22;
            this.TextAdSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextAdSoyad_KeyPress);
            // 
            // listeyeEklelable
            // 
            this.listeyeEklelable.AutoSize = true;
            this.listeyeEklelable.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listeyeEklelable.Location = new System.Drawing.Point(71, 40);
            this.listeyeEklelable.Name = "listeyeEklelable";
            this.listeyeEklelable.Size = new System.Drawing.Size(196, 23);
            this.listeyeEklelable.TabIndex = 20;
            this.listeyeEklelable.Text = "Nöbet Listesine Ekle";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(128, 187);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(98, 23);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmListeyeEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 240);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextMail);
            this.Controls.Add(this.TextTelNo);
            this.Controls.Add(this.TextAdSoyad);
            this.Controls.Add(this.listeyeEklelable);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmListeyeEkleme";
            this.Text = "frm";
            this.Load += new System.EventHandler(this.FrmListeyeEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextMail;
        private System.Windows.Forms.TextBox TextTelNo;
        private System.Windows.Forms.TextBox TextAdSoyad;
        private System.Windows.Forms.Label listeyeEklelable;
        private System.Windows.Forms.Button btnKaydet;
    }
}