using Zenix.Common.Messages;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Zenix.Common.Function
{
    public static class MailEngine
    {
        const string mymail = "zenixsolutioninfo@gmail.com";
        const string mypass = "63792958";
        const string myhost = "smtp.gmail.com";
        const int myport = 587;

        static string mailbody = @"<html>
<head>
<style>
table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
  width: 100%;
}
th
{
background-color:#4CAF50;
color:whitesmoke
}
td, th {
  border: 1px solid #dddddd;
  text-align: center;
  padding: 8px;
}

tr:nth-child(even) {
  background-color: #dddddd;
}
</style>
</head>
<body>

<h2>Müşteri Takip Programına Giriş İçin Gereken Kullanıcı Adı ve Şifre Bilgileri Aşağıdadır</h2>
<table>
	<tr>
		<th>Bilgiler</th>
		<th>Veriler</th>		
	</tr>
	<tr>
		<td style='text-align: right;'>Yetki Türü :</td>
		<td>{Rol}</td>
	</tr
	<tr>
		<td style='text-align: right;'>Kullanıcı Adı :</td>
		<td>{KullanıcıAdı}</td>
	</tr>
	<tr>
		<td style='text-align: right;'>Şifre :</td>
		<td>{Şifre}</td>
	</tr>
</table>
<h3>Lütfen Programa Giriş Yaptıktan Sonra Bu Bilgileri Değiştiriniz.</h3>
</body>
</html>";

        public static bool SendPaswordMail(this string kullanıcıAdı, string rol, string email, SecureString secureŞifre)
        {
            using (var client = new SmtpClient(myhost, myport)
            {
                EnableSsl = true,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential(mymail, mypass),
            })
            {
                var message = new MailMessage
                {
                    From = new MailAddress(mymail, "Müşteri Takip Programı"),
                    To = { email },
                    Subject = "Müşteri Takip Programı Kullanıcı Bilgileri",
                    IsBodyHtml = true,
                    Body = mailbody
                    .Replace("{Rol}", rol)
                    .Replace("{KullanıcıAdı}", kullanıcıAdı)
                    .Replace("{Şifre}", secureŞifre.ConvertToUnsecureString())

                };
                try
                {
                    client.Send(message);
                    return true;
                }
                catch (Exception ex)
                {
                    Msg.HataliVeriMesajı(ex.ToString());
                    return false;
                }
            }

        }

    }
}
