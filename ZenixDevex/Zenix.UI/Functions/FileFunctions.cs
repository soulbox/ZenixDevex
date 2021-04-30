using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Zenix.Common.Enums;
using Zenix.Common.Function;
using Zenix.Common.Messages;

namespace Zenix.WinUI.Functions
{
    public static class FileFunctions
    {
        public static void FormSablonKaydet(this string sablonadi, FormSettings settings)
        {
            try
            {
                var setting = new XmlWriterSettings { Indent = true };
                //PathEngine.ConfigPath 
                var writer = XmlWriter.Create(PathEngine.ConfigPath + $@"\{sablonadi}_location.xml", setting);
                writer.WriteStartDocument();
                writer.WriteComment("WinpackSolution Tarafından Oluşturuldu");
                writer.WriteStartElement("Tablo");
                writer.WriteStartElement("Location");
                writer.WriteAttributeString("Left", settings.Left.ToString());
                writer.WriteAttributeString("Top", settings.Top.ToString());
                writer.WriteEndElement();//location kapandı

                writer.WriteStartElement("FormSize");
                if (settings.State == FormWindowState.Minimized)
                {
                    writer.WriteAttributeString("Width", "-1");
                    writer.WriteAttributeString("Height", "-1");

                }
                else
                {
                    writer.WriteAttributeString("Width", settings.Width.ToString());
                    writer.WriteAttributeString("Height", settings.Height.ToString());
                }
                //writer.WriteAttributeString("FormWindowState", settings.State.ToString());
                writer.WriteEndElement();//FormSize kapandı
                writer.WriteEndElement();//Tablo kapandı

                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();

            }
            catch (Exception ex)
            {
                Msg.HataMesajı(ex.ToString());
            }
        }

        public static void FormSablonYukle(this string sablonadi, XtraForm frm)
        {
            FormSettings setting = null;
            try
            {
                if (File.Exists(PathEngine.ConfigPath + $@"\{sablonadi}_location.xml"))
                {


                    var reader = XmlReader.Create(PathEngine.ConfigPath + $@"\{sablonadi}_location.xml");
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Location")
                        {
                            setting = setting ?? new FormSettings();
                            setting.Left = Convert.ToInt32(reader.GetAttribute(0));
                            setting.Top = Convert.ToInt32(reader.GetAttribute(1));

                        }
                        else if (reader.NodeType == XmlNodeType.Element && reader.Name == "FormSize")
                        {
                            setting = setting ?? new FormSettings();

                            setting.Width = Convert.ToInt32(reader.GetAttribute(0));
                            setting.Height = Convert.ToInt32(reader.GetAttribute(1));
                        }

                    }
                    reader.Close();
                    reader.Dispose();
                }
            }
            catch (Exception ex)
            {

                Msg.HataMesajı(ex.ToString());

            }

            if (setting == null) return;
            frm.Location = new System.Drawing.Point(setting.Left, setting.Top);
            if (setting.Width == -1 && setting.Height == -1)
                frm.WindowState = FormWindowState.Minimized;
            else
                frm.Size = new System.Drawing.Size(setting.Width, setting.Height);
        }

        public static void TabloSablonKaydet(this GridView tablo, string sablonadi)
        {
            try
            {
                tablo.ClearColumnsFilter();
                tablo.SaveLayoutToXml(PathEngine.ConfigPath + $@"\{sablonadi}.xml");
            }
            catch (Exception ex)
            {

                Msg.HataMesajı(ex.ToString());

            }
        }
        public static void TabloSablonYukle(this GridView tablo, string sablonadi)
        {
            try
            {
                if (File.Exists(PathEngine.ConfigPath + $@"\{sablonadi}.xml"))
                {
                    tablo.ClearColumnsFilter();
                    tablo.RestoreLayoutFromXml(PathEngine.ConfigPath + $@"\{sablonadi}.xml");
                }

            }
            catch (Exception ex)
            {

                Msg.HataMesajı(ex.ToString());

            }
        }

        public static void TabloDisariAktar(this GridView tablo, DosyaTuru dosyaTuru, string dosyaFormati, string excelSayfaadi = null)
        {
            if (Msg.TabloExpoerMesaj(dosyaFormati) != DialogResult.Yes) return;

            var filepath = $@"{PathEngine.ConfigPath}\{tablo.Name}";
            switch (dosyaTuru)
            {
                case DosyaTuru.ExcelStandart:
                    {
                        filepath += $"{dosyaTuru}.xlsx";
                        tablo.ExportToXlsx(filepath, new XlsxExportOptionsEx
                        {
                            ExportType = DevExpress.Export.ExportType.Default,
                            SheetName = excelSayfaadi,
                            TextExportMode = TextExportMode.Text,

                        });
                    }
                    break;
                case DosyaTuru.ExcelFormatli:
                    {
                        filepath += $"{dosyaTuru}.xlsx";

                        tablo.ExportToXlsx(filepath, new XlsxExportOptionsEx
                        {
                            ExportType = DevExpress.Export.ExportType.WYSIWYG,
                            SheetName = excelSayfaadi,
                            TextExportMode = TextExportMode.Text,

                        });
                    }
                    break;
                case DosyaTuru.ExcelFormatsiz:
                    {
                        filepath += $"{dosyaTuru}.csv";
                        tablo.ExportToCsv(filepath, new CsvExportOptionsEx
                        {
                            ExportType = DevExpress.Export.ExportType.WYSIWYG,
                            TextExportMode = TextExportMode.Text,

                        });
                    }
                    break;
                case DosyaTuru.Word:
                    {
                        filepath += $"{dosyaTuru}.docx";
                        tablo.ExportToDocx(filepath);
                    }
                    break;
                case DosyaTuru.PDF:
                    {
                        filepath += $"{dosyaTuru}.pdf";
                        tablo.ExportToPdf(filepath);
                    }
                    break;
                case DosyaTuru.TXT:
                    {
                        filepath += $"{dosyaTuru}.txt";
                        tablo.ExportToText(filepath, new TextExportOptions { TextExportMode = TextExportMode.Text });
                    }
                    break;
            }

            Process.Start(filepath);
        }

        public class FormSettings
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public FormWindowState State { get; set; }

        }
    }
}
