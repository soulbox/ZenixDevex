using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using System.ComponentModel;
using Zenix.Common.Messages;

namespace Zenix.Common.Function
{
    public class ExcelEngine
    {
        public string Path { get; }
        OleDbConnection Con { get; set; }
        public ExcelEngine(string path)
        {
            Path = path;

            //var li = GetList<Model>();

            Con = GetCon();
        }
        OleDbConnection GetCon()
        {
            string strConn = "";
            //if (Environment.Is64BitProcess)
            //    strConn = $"Provider = Microsoft.ACE.OLEDB.12.0; Data Source={Path}; Extended Properties = \"Excel 12.0; HDR = Yes; IMEX = 0\"";
            //else
            strConn = $"Provider = Microsoft.Jet.OLEDB.4.0;  Data Source={Path}; Extended Properties = \"Excel 8.0; HDR = Yes; IMEX = 1\"";
            return new OleDbConnection(strConn);
        }
        class colum
        {
            public string Name { get; set; }
            public int index { get; set; }
        }
        public List<T> GetList<T>() where T : class
        {
            var list = (List<T>)Activator.CreateInstance(typeof(List<T>));
            var columlistDescription = ClassFunction.GetPropDescriptionList<T>();
            try
            {
                using (var stream = File.Open(Path, FileMode.Open, FileAccess.Read))
                {
                    // Auto-detect format, supports:
                    //  - Binary Excel files (2.0-2003 format; *.xls)
                    //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                    var excelconf = new ExcelReaderConfiguration
                    {
                        FallbackEncoding = Encoding.GetEncoding(1254),
                    };

                    using (var reader = ExcelReaderFactory.CreateReader(stream, excelconf))
                    {
                        // Choose one of either 1 or 2:

                        // 1. Use the reader methods
                        var listcol = new List<colum>();

                        do
                        {
                            while (reader.Read())
                            {
                                if (reader.Depth == 0)
                                {
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        if (listcol.Count.Equals(columlistDescription.Count)) break;
                                        var val = reader.GetValue(i);
                                        if (val == null) continue;
                                        var findcol = columlistDescription.FirstOrDefault(x => x.Contains(val.ToString()));
                                        listcol.Add(new colum { index = i, Name = findcol });
                                    }
                                }
                                else
                                {
                                    var newobj = (T)Activator.CreateInstance(typeof(T));
                                    foreach (var li in listcol)
                                        newobj.SetDescriptionPropValue(li.Name, reader.GetValue(li.index));
                                    list.Add(newobj);
                                }
                            }
                        } while (reader.NextResult());

                    }
                }
            }
            catch (Exception ex)
            {
                Msg.HataMesajı(ex.ToString());
                return list;

            }

            return list;
        }

        protected void Close()
        {
            Con.Close();
            Con.Dispose();
        }
        protected void Connect()
        {

            Con.Open();

        }
        public bool isConnected { get => Con?.State == ConnectionState.Open; }

        protected DataTable ReadExcel()
        {
            DataTable dtexcel = new DataTable();

            if (Con == null) return dtexcel;
            if (!isConnected) Con.Open();

            if (Path.Trim().Length > 0)
            {
                DataTable schemaTable = new DataTable();
                schemaTable = Con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                //schemaTable = Con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables , null);

                string sheet = "";
                if (schemaTable.Rows.Count == 0)
                {
                    MessageBox.Show($"Excel Okunacak Tablo adı Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return dtexcel;
                }
                else
                {
                    DataRow schemaRow = schemaTable.Rows[0];
                    sheet = schemaRow["TABLE_NAME"].ToString();
                }

                if (!sheet.EndsWith("_"))
                {
                    string query = "SELECT  * FROM [" + sheet + "]";
                    OleDbDataAdapter daexcel = new OleDbDataAdapter(query, Con);
                    dtexcel.Locale = CultureInfo.CurrentCulture;
                    daexcel.Fill(dtexcel);
                }
                Con.Close();

            }
            else
            {
                MessageBox.Show($"{Path}\nOkunacak EXCEL dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return dtexcel;
        }
    }
}
