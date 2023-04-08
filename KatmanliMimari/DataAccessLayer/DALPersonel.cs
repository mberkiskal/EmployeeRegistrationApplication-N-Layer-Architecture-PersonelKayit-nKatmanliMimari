using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand cmd = new SqlCommand("select * from Table_Bilgi",Baglanti.bgl);
            if(cmd.Connection.State!= ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel per = new EntityPersonel();
                per.PersonelId1 = int.Parse(dr["PersonelId"].ToString());
                per.PersonelAd1= dr["PersonelAd"].ToString();
                per.PersonelSoyad1 = dr["PersonelSoyad"].ToString();
                per.PersonelGorev1 = dr["PersonelGorev"].ToString();
                per.PersonelSehir1 = dr["PersonelSehir"].ToString();
                per.PersonelMaas1 = short.Parse(dr["PersonelMaas"].ToString());
                degerler.Add(per);
            }
            dr.Close();
            return degerler;
        }


        public static int PersonelEkle(EntityPersonel personel)
        {
            SqlCommand cmd2 = new SqlCommand("insert into Table_Bilgi (PersonelAd, PersonelSoyad, PersonelGorev, PersonelSehir, PersonelMaas)" +
                                                                "values (@p1, @p2, @p3, @p4,@p5)",Baglanti.bgl);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }

            cmd2.Parameters.AddWithValue("@p1", personel.PersonelAd1);
            cmd2.Parameters.AddWithValue("@p2", personel.PersonelSoyad1);
            cmd2.Parameters.AddWithValue("@p3", personel.PersonelGorev1);
            cmd2.Parameters.AddWithValue("@p4", personel.PersonelSehir1);
            cmd2.Parameters.AddWithValue("@p5", personel.PersonelMaas1);

            return cmd2.ExecuteNonQuery();  

        }

        public static bool PersonelSil(int p)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from Table_Bilgi where PersonelId=@p1", Baglanti.bgl);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@p1", p);
            return cmd3.ExecuteNonQuery()>0; 
        }

        public static bool PersonelGuncelle(EntityPersonel ent)
        {
            SqlCommand cmd4 = new SqlCommand("Update Table_Bilgi set PersonelAd=@p1, PersonelSoyad=@p2, PersonelMaas=@p3, PersonelSehir=@p4, PersonelGorev=@p5 where PersonelId=@p6", Baglanti.bgl);
            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            cmd4.Parameters.AddWithValue("@p1", ent.PersonelAd1);
            cmd4.Parameters.AddWithValue("@p2", ent.PersonelSoyad1);
            cmd4.Parameters.AddWithValue("@p3", ent.PersonelMaas1);
            cmd4.Parameters.AddWithValue("@p4", ent.PersonelSehir1);
            cmd4.Parameters.AddWithValue("@p5", ent.PersonelGorev1);
            cmd4.Parameters.AddWithValue("@p6", ent.PersonelId1);
            return cmd4.ExecuteNonQuery()>0;
        } 
    }
}
