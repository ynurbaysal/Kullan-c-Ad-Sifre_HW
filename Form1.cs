using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıAdıSifre_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //İç içe switch kullanarak kullanıcı adını ve şifresini kontrol ediniz.
            //eğer kullanıcı kullanıcıadını ve şifresini doğru girerse 
            //"Tebrikler, hem kullanıcı adı hemde şifreniz doğru" uyarısı
            //Kullanıcı adı doğru şifre yanlışsa
            //"Kullanıcı adınız doğru ancak şifreniz yanlış!" uyarısı
            //kullanıcı adı yanlışsa "Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!"
            //uyarusını kullanıcıya veriniz.

            //KullaniciAdi = "bilgeadam";
            //Sifre = "1234";
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            switch (txtkullanıcıadı.Text)
            {
                case "bilgeadam":
                    switch (txtsifre.Text)
                    {
                        case "1234":
                            MessageBox.Show("kullanıcı adı ve şifre doğru");
                            break;
                        default:
                            MessageBox.Show("kulanıcı adı doğru ancak şifre yanlış");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("kullanıcı adı yanlış şifreye bakmadım bile");
                    break;
            }
        }
    }
}
