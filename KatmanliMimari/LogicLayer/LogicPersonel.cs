using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi ()
        { 
            return DALPersonel.PersonelListesi ();
                    
        }
        public static int PersonelEkle(EntityPersonel personel)
        {
            if(personel.PersonelAd1!=""&& personel.PersonelSoyad1!=""&& personel.PersonelMaas1>=3500 && personel.PersonelAd1.Length >= 3)
            {
                return DALPersonel.PersonelEkle (personel);
            }
            else
            {
                return -1;
            }
        }
        public static bool PersonelSil(int p)
        {
            if (p >= 1)
            {
                return DALPersonel.PersonelSil(p);
            }
            else
            {
                return false;
            }
        }
        
        public static bool PersonelGuncelle(EntityPersonel ent)
        {
            if(ent.PersonelAd1.Length >=3 && ent.PersonelAd1!="" && ent.PersonelMaas1>=4500 ) 
            {
                return DALPersonel.PersonelGuncelle (ent);
            }
            else
            {
                return false;
            }
        }
    }
}
