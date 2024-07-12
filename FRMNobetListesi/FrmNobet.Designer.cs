
namespace FRMNobetListesi
{
    partial class FrmNobet
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
            this.btnGoster = new System.Windows.Forms.Button();
            this.dataGridNobet = new System.Windows.Forms.DataGridView();
            this.comboBoxilkTarih = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkleGit = new System.Windows.Forms.Button();
            this.ListEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNobet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(147, 83);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(113, 23);
            this.btnGoster.TabIndex = 2;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // dataGridNobet
            // 
            this.dataGridNobet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNobet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNobet.Location = new System.Drawing.Point(-2, 147);
            this.dataGridNobet.Name = "dataGridNobet";
            this.dataGridNobet.Size = new System.Drawing.Size(697, 247);
            this.dataGridNobet.TabIndex = 4;
            this.dataGridNobet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNobet_CellContentClick);
            // 
            // comboBoxilkTarih
            // 
            this.comboBoxilkTarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxilkTarih.FormattingEnabled = true;
            this.comboBoxilkTarih.Location = new System.Drawing.Point(139, 46);
            this.comboBoxilkTarih.Name = "comboBoxilkTarih";
            this.comboBoxilkTarih.Size = new System.Drawing.Size(121, 21);
            this.comboBoxilkTarih.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Başlangıç Tarihi ( Ay )";
            // 
            // btnEkleGit
            // 
            this.btnEkleGit.Location = new System.Drawing.Point(322, 83);
            this.btnEkleGit.Name = "btnEkleGit";
            this.btnEkleGit.Size = new System.Drawing.Size(113, 23);
            this.btnEkleGit.TabIndex = 3;
            this.btnEkleGit.Text = "Kullanıcı Ekle";
            this.btnEkleGit.UseVisualStyleBackColor = true;
            this.btnEkleGit.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // ListEkle
            // 
            this.ListEkle.Location = new System.Drawing.Point(322, 46);
            this.ListEkle.Name = "ListEkle";
            this.ListEkle.Size = new System.Drawing.Size(113, 23);
            this.ListEkle.TabIndex = 7;
            this.ListEkle.Text = "Listeye Ekle";
            this.ListEkle.UseVisualStyleBackColor = true;
            // 
            // FrmNobet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 398);
            this.Controls.Add(this.ListEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxilkTarih);
            this.Controls.Add(this.dataGridNobet);
            this.Controls.Add(this.btnEkleGit);
            this.Controls.Add(this.btnGoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmNobet";
            this.Text = "Nöbet Listesi";
            this.Load += new System.EventHandler(this.FrmNobet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNobet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.DataGridView dataGridNobet;
        private System.Windows.Forms.ComboBox comboBoxilkTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkleGit;
        private System.Windows.Forms.Button ListEkle;
    }
}

