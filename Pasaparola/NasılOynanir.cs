using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasaparola
{
    public partial class NasılOynanir : Form
    {
        public NasılOynanir()
        {
            InitializeComponent();
            FormDizayn();
            CreateWidget();
        }
        private void FormDizayn()
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ControlBox = false;
            this.BackgroundImage = Properties.Resources.nasıloynanırArkaPlan;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = "";
            this.Size = new Size(1068, 633);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateWidget()
        {
            Button btnHome = new Button
            {
                Name = "btnHome",
                BackgroundImage = Properties.Resources.home,
                BackgroundImageLayout = ImageLayout.Stretch,
                AutoSize = true,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(12, 12),
                Size = new Size(72, 62),
            };
            btnHome.Click += (object sender, EventArgs e) => { this.Close(); };
            this.Controls.Add(btnHome);

            Label label = new Label
            {
                Text = "Nasıl Oynanır :" +
                "\n1- Kullacı başla butonuna tıklayarak oyunun oynanacağı ekranı açar." +
                "\n2-Oyunu başlaatıktan sonra soruların cevaplarını textbox'a (küçük harf ile) " +
                "\ncevaplarını yazıp enter tuşuna veya cevapla butonun basarak soruyu " +
                "\nyanıtlamalıdır." +
                "\n3- Kullanıcı 100 saniye içinde bütün soruları cevaplamalıdır." +
                "\n4- Kullanıcı istediği kadar pas kullanabilir." +
                "\n5-Bütün sorular cevaplandığında kullanıcı skor tablosunda puanını görebilir." +
                "\n6-Yeşil renkler doğru yanıtları, Kırmızı renkler yanliş cevapları, " +
                "\nSarı renkler pas olan soruları göstermektedir." +
                "\n7-Doğru sayısı ve süre puanınıza doğrudan etkilidir." +
                "\nYanliş sayısının puana bir etkisi yoktur." +
                "\n\n\n Başarılar Dileriz.",
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Location = new Point(112, 165),
                Font = new Font("Segoe UI", 15, FontStyle.Bold),
                AutoSize = true
            };
            this.Controls.Add(label);
            PictureBox pb = new PictureBox
            {

                BackgroundImage = Properties.Resources.Logo,
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = new Size(198, 165),
                Location = new Point(441, 12),
                BackColor = Color.Transparent
            };
            this.Controls.Add(pb);

        }
        private void NasılOynanir_Load(object sender, EventArgs e)
        {

        }
    }
}
