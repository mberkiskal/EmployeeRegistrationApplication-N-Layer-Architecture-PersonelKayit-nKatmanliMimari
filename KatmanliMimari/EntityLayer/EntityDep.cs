using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDep
    {
        private int DepId;
        private string DepAd;
        private string DepAciklama;

        public int DepId1 { get => DepId; set => DepId = value; }
        public string DepAd1 { get => DepAd; set => DepAd = value; }
        public string DepAciklama1 { get => DepAciklama; set => DepAciklama = value; }
    }
}
