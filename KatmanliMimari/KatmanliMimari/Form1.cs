using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace KatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> Perlist = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = Perlist; 

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();

            ent.PersonelAd1 = txtad.Text;
            ent.PersonelSoyad1 = txtsoyad.Text;
            ent.PersonelSehir1 = txtsehir.Text;
            ent.PersonelMaas1 = short.Parse(txtmaas.Text);
            ent.PersonelGorev1 = txtgorev.Text;
            LogicPersonel.PersonelEkle(ent);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.PersonelId1=Convert.ToInt32(txtid.Text);
            LogicPersonel.PersonelSil(ent.PersonelId1);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.PersonelId1 = Convert.ToInt32(txtid.Text);
            ent.PersonelAd1 =(txtad.Text);
            ent.PersonelSoyad1 =(txtsoyad.Text);    
            ent.PersonelSehir1=txtsehir.Text;
            ent.PersonelGorev1 =(txtgorev.Text);
            ent.PersonelMaas1=short.Parse(txtmaas.Text);
            LogicPersonel.PersonelGuncelle(ent);
        }
    }
}
