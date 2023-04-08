namespace KatmanliMimari
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgorev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsehir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel ID:";
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(12, 232);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(218, 41);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(294, 41);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(157, 29);
            this.txtid.TabIndex = 3;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(294, 93);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(157, 29);
            this.txtad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Ad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(294, 146);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(157, 29);
            this.txtsoyad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel Soyad:";
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(638, 36);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(157, 29);
            this.txtmaas.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Personel Maaş:";
            // 
            // txtgorev
            // 
            this.txtgorev.Location = new System.Drawing.Point(638, 94);
            this.txtgorev.Name = "txtgorev";
            this.txtgorev.Size = new System.Drawing.Size(157, 29);
            this.txtgorev.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Personel Görev:";
            // 
            // txtsehir
            // 
            this.txtsehir.Location = new System.Drawing.Point(638, 148);
            this.txtsehir.Name = "txtsehir";
            this.txtsehir.Size = new System.Drawing.Size(157, 29);
            this.txtsehir.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Personel Şehir:";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(276, 230);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(218, 44);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(540, 227);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(218, 44);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(796, 227);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(218, 44);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 643);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtsehir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtgorev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgorev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

