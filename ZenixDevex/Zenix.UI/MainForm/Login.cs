using System;
using System.Windows.Forms;
using Zenix.BLL.General;
using Zenix.Model.Entities;
using Zenix.Common.Messages;
using Zenix.Data.Context;
using System.Xml;
using Zenix.Common.Function;
using System.Linq.Expressions;
using System.IO;
using DevExpress.XtraSplashScreen;
using System.Text.RegularExpressions;
using Zenix.WinUI.Functions;
using Zenix.WinUI.Show;
using Zenix.WinUI.Forms.KullanıcıForms;
using Zenix.Common.Enums;
using Zenix.UI;

namespace Zenix.WinUI.MainForm
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        KullanıcıBll Bll = new KullanıcıBll();

        public Login()
        {
            InitializeComponent();
            lblVers.Text = $"Versiyon :{Program.DeplayVersion()}";
            Text = "Kullanıcı Girişi Database=" + ZenixContext.ConBuilder.DataSource;
            Load += Login_Load;

            SplashScreenManager.CloseForm();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            var read = ConfigRead();
            if (!chckHatırla.Checked) return;
            txtusername.Text = read?.Kod;
            txtPassword.Text = read?.Şifre;
            //if (read != null)
            //    btnGiriş.PerformClick();
        }
        public bool IsMD5(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return false;
            }

            return Regex.IsMatch(input, "^[0-9a-fA-F]{32}$", RegexOptions.Compiled);
        }
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var şifre = IsMD5(txtPassword.Text) ? txtPassword.Text : txtPassword.Text.Md5Şifrele();
            Expression<Func<Kullanici, bool>> filter = x => x.Kod == txtusername.Text && x.Şifre == şifre;
            var find = Bll.Single(filter);
            Cursor.Current = Cursors.Default;
            if (find != null)
            {
                if (!((Kullanici)find).Durum)
                {
                    Msg.HataMesajı("Pasif Durumdaki Kullanıcı İle Giriş Yapılamaz!");
                    return;
                }
                //ZenixContext.FixIndexKod();
               
                ConfigWrite((Kullanici)find);

                AnaForm.Kullanıcı = ((Kullanici)find).GetKullanici(filter);
                Program.SetMainForm(new AnaForm());
                Program.ShowMainForm();
                this.Close();

            }
            else
                Msg.HataMesajı("Kullanıcı adı veya şifre Yanlış");


        }

        void ConfigWrite(Kullanici kullanici)
        {

            try
            {
                var setting = new XmlWriterSettings { Indent = true };
                var writer = XmlWriter.Create(PathEngine.ConfigPath + $@"\{typeof(Kullanici).Name}.xml", setting);
                writer.WriteStartDocument();
                writer.WriteComment("WinpackSolution Tarafından Oluşturuldu");
                writer.WriteStartElement("Login");
                writer.WriteStartElement("Userinfo");
                writer.WriteAttributeString(GetPropertyName(() => kullanici.Kod), kullanici.Kod.ToString());
                writer.WriteAttributeString(GetPropertyName(() => kullanici.Şifre), kullanici.Şifre.ToString());
                writer.WriteAttributeString("isRemember", chckHatırla.Checked.ToString());

                writer.WriteEndElement();//Userinfo kapandı
                writer.WriteEndElement();//Login kapandı
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();

            }
            catch (Exception ex)
            {
                Msg.HataMesajı(ex.ToString());
            }
        }
        Kullanici ConfigRead()
        {
            Kullanici result = null;
            try
            {
                if (File.Exists(PathEngine.ConfigPath + $@"\{typeof(Kullanici).Name}.xml"))
                {


                    var reader = XmlReader.Create(PathEngine.ConfigPath + $@"\{typeof(Kullanici).Name}.xml");
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "Userinfo")
                        {
                            result = result ?? new Kullanici();
                            result.Kod = reader.GetAttribute(0);
                            result.Şifre = reader.GetAttribute(1);
                            chckHatırla.Checked = System.Convert.ToBoolean(reader.GetAttribute(2));
                        }

                    }
                    reader.Close();
                    reader.Dispose();
                }
                return result;

            }
            catch (Exception ex)
            {

                Msg.HataMesajı(ex.ToString());
                return result;

            }

        }




        public string GetPropertyName<T>(Expression<Func<T>> propertyLambda)
        {
            var me = propertyLambda.Body as MemberExpression;

            if (me == null)
            {
                throw new ArgumentException("You must pass a lambda of the form: '() => Class.Property' or '() => object.Property'");
            }

            return me.Member.Name;
        }
        //public static string Name<T, TProp>(this T o, Expression<Func<T, TProp>> propertySelector)
        //{
        //    MemberExpression body = (MemberExpression)propertySelector.Body;
        //    return body.Member.Name;
        //}
        private void btnUnuttum_Click(object sender, EventArgs e)
        {
            ShowEditForms<ŞifremiUnuttumEditForm>.ShowDialogEditForm(IslemTuru.EntityUpdate, txtusername.Text);
        }
    }
}