using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Model.Entities.Base.Interfaces;

namespace Zenix.Model.Entities
{
    public class DokumParametreleri : IBaseEntity
    {
        public string  RaporBaslik { get; set; }
        public EvetHayir BaslikEkle{ get; set; }
        public RaporuKagidaSigdirmaTuru RaporuKagidaSigdir { get; set; }
        public YazdirmaYonu YazdirmaYonu  { get; set; }
        public EvetHayir YatayCizgiGoster { get; set; }
        public EvetHayir DikeyCizgiGoster { get; set; }
        public EvetHayir SutunBaslikGoster { get; set; }
        public string YaziciAdi { get; set; }
        public int  YazdirilicakAdet { get; set; }
        public DokumSekli DokumSekli { get; set; }


    }
}
