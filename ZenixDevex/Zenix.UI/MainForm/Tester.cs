using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using Zenix.BLL.General;
using Zenix.Model.Entities;
using Zenix.Common.Enums;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraSplashScreen;
using Zenix.Model.Entities.Base.Interfaces;
using Zenix.WinUI.Functions;
using Zenix.Model.DTO;

namespace Zenix.WinUI.MainForm
{
    public partial class Tester : DevExpress.XtraEditors.XtraForm
    {
        public Tester()
        {
            InitializeComponent();
            SplashScreenManager.CloseForm();
            myGridview1 .GridControl.DataSource = new BindingList<Seed>();
            rolYetkileriTable1.Listele();
            mySimpleButton1.PerformClick();
        }

        private void mySimpleButton1_Click(object sender, EventArgs e)
        {

            var tablo = myGridview1;
            var source = tablo.DataController.ListSource;
            Seed.GetSeed.ForEach(x =>
            {
                source.Add(new Seed
                {
                    Adı=x.Adı,
                    No=x.No,
                    Soyadı=x.Soyadı,
                    Görebilir=x.Görebilir,
                    Silebilir=x.Silebilir,
                    Ekleyebilir=x.Ekleyebilir,
                    Insert=true ,

                });
            });
            tablo.Focus();
            tablo.RefreshDataSource();

            tablo.FocusedRowHandle = tablo.DataRowCount - 1;
        }
    }

    public class Seed:RolYetkileriL 
    {
        static int id = 0;
        public Seed()
        {
            id++;
        }
        public int No { get => id; set => id = value; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }

        public static List<Seed> GetSeed => new List<Seed>()
        {
        new Seed{ Adı="kadir",Soyadı="Aygün1" },
        new Seed{ Adı="Türkan",Soyadı="Aygün2" },
        new Seed{ Adı="Esmen",Soyadı="Aygün3" }
        };
    }
}