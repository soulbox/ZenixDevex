using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Model.Entities.Base;

namespace Zenix.Model.Entities
{
    public class SatınAlmaMalzemeler : BaseEntityHaraket
    {
        public Satınalma Satınalma  { get; set; }
        public long SatınalmaId { get; set; }
        //public Malzeme Malzeme  { get; set; }
        //public long MalzemeId { get; set; }
        public int Miktar { get; set; }
        public DateTime TerminTarihi { get; set; }



    }
}
