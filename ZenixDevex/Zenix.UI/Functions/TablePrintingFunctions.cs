using DevExpress.DXTemplateGallery.Extensions;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenix.Common.Enums;
using Zenix.Model.Entities;
using Zenix.WinUI.MainForm;
using Zenix.WinUI.Show;

namespace Zenix.WinUI.Functions
{
    public class TablePrintingFunctions
    {

        static GridView table;
        static string Raporbasligi;
        static PrintableComponentLink Link;
        static PrintingSystem ps;
        static DokumParametreleri dp;
        public static void Yazdir(GridView tablo, string raporbaslik, string kullanıcı)
        {
            Link = new PrintableComponentLink();
            ps = new PrintingSystem();
            Raporbasligi = raporbaslik;
            table = tablo;
            dp = ShowEditForms<TabloDokumParametreleri>.ShowDialogEditForm<DokumParametreleri>(raporbaslik);

            RaporDokumu();
        }

        private static void RaporDokumu()
        {
            BaslikEkle();
            RaporuKagidaSigdirmaTuru();
            table.OptionsPrint.PrintHorzLines = dp.YatayCizgiGoster == EvetHayir.Evet;
            table.OptionsPrint.PrintVertLines = dp.DikeyCizgiGoster == EvetHayir.Evet;
            table.OptionsPrint.PrintHeader = dp.SutunBaslikGoster == EvetHayir.Evet;
            table.OptionsView.ShowViewCaption = false;

            Link.Component = table.GridControl;
            Link.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            Link.Margins = new Margins(59, 59, 115, 48);
            Link.CreateMarginalHeaderArea += Link_CreateMarginalHeaderArea;
            Link.CreateDocument(ps);

            switch (dp.DokumSekli)
            {
                case DokumSekli.TabloBaskiOnizleme:
                    ShowRibbonForms<RaporOnizleme>.ShowForm(true, ps, dp, Raporbasligi);
                    break;

                case DokumSekli.TabloYazdir:
                    for (int i = 0; i < dp.YazdirilicakAdet; i++)
                        Link.Print(dp.YaziciAdi);
                    break;

            }
            table.OptionsView.ShowViewCaption = true;
        }

        private static void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            if (dp.BaslikEkle == EvetHayir.Hayir) return;
            var boldfont = new Font("Tahoma", 7, FontStyle.Bold);
            var regularfont = new Font("Tahoma", 7, FontStyle.Regular);
            var sayfabrick = new PageInfoBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            { 
            Font=regularfont,
            PageInfo=PageInfo.NumberOfTotal,
            Format="Sayfa: {0} / {1}",
            Alignment=BrickAlignment.Far,
            AutoWidth=true
            };

            ps.Graph.DrawBrick(sayfabrick, new RectangleF(200, 25, 40, 15));
            var Tarihbrick = new PageInfoBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = regularfont,
                PageInfo = PageInfo.DateTime ,
                Format = "Tarih: {0:dd.MM.yyyy} ",
                Alignment = BrickAlignment.Far,
                AutoWidth = true
            };
            ps.Graph.DrawBrick(Tarihbrick, new RectangleF(0, 40, 50, 15));

            var subeBaslikBrick = new TextBrick (BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = boldfont ,
                Text="Şube"
            };
            ps.Graph.DrawBrick(subeBaslikBrick, new RectangleF(0, 25, 40, 15));
            var subeValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = boldfont,
                Text = ": {Şube Adı}"
            };
            ps.Graph.DrawBrick(subeValueBrick, new RectangleF(55, 25, 500, 15));
            var donemBaslikBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = boldfont,
                Text = "Dönem"
            };
            ps.Graph.DrawBrick(donemBaslikBrick, new RectangleF(0, 40, 40, 15));
            var donemValueBrick = new TextBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent, Color.Black)
            {
                Font = boldfont,
                Text = ": {Dönem}"
            };
            ps.Graph.DrawBrick(donemValueBrick, new RectangleF(55, 40, 200, 15));
        }

        private static void RaporuKagidaSigdirmaTuru()
        {
            YazdirmaYonuAyarla();
            switch (dp.RaporuKagidaSigdir)
            {
                case Common.Enums.RaporuKagidaSigdirmaTuru.SutunlariDaraltarakSigdir:
                    table.OptionsPrint.AutoWidth = true;

                    break;
                case Common.Enums.RaporuKagidaSigdirmaTuru.YaziBoyutunuKuculterekSigdir:
                    table.OptionsPrint.AutoWidth = false;
                    ps.Document.AutoFitToPagesWidth = 1;
                    break;
                default:
                    table.OptionsPrint.AutoWidth = false;
                    ps.Document.ScaleFactor = 1.0f;

                    break;
            }
        }

        private static void YazdirmaYonuAyarla()
        {
            switch (dp.YazdirmaYonu)
            {
                case YazdirmaYonu.Dikey:
                    Link.Landscape = false;

                    break;
                case YazdirmaYonu.Yatay:
                    Link.Landscape = true;

                    break;
                case YazdirmaYonu.Otomatik:
                    Link.Landscape = OtomatikYazdırmaYonu();

                    break;
                default:
                    break;
            }
        }

        private static bool OtomatikYazdırmaYonu()
        {
            const int sayfagenisligi = 703;
            var tablogenislikleri = 0;
            for (int i = 0; i < table.Columns.Count; i++)
                if (table.Columns[i].Visible)
                    tablogenislikleri += table.Columns[i].Width;
            return tablogenislikleri > sayfagenisligi;
        }

        private static void BaslikEkle()
        {
            if (dp.BaslikEkle != EvetHayir.Evet) return;
            var headerarea = new PageHeaderArea();
            headerarea.Content.AddRange(new[] { "", dp.RaporBaslik, "" });
            headerarea.Font = new System.Drawing.Font("Arial Narrow", 10f, System.Drawing.FontStyle.Bold);
            headerarea.LineAlignment = BrickAlignment.Far;
            Link.PageHeaderFooter = new PageHeaderFooter(headerarea, null);//,footerarea);  footer varsa bu şekilde kullan

        }
    }
}
