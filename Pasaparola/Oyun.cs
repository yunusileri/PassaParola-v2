using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
namespace Pasaparola
{
    public partial class Oyun : Form
    {

        // Nesneler
        Tasarim ts = new Tasarim();
        AsilSorular AsSoru = new AsilSorular();
        Util message = new Util();

        // Değişkenler 
        bool OyunaBaslaKontrol = false;
        List<PictureBox> pictureBoxes;  //  Ekrandaki Harfler
        List<Bitmap> PictureBoxImages;
        int saniye = 60, x = 0, pas = 0, dogru = 0, yanlis = 0; //  dogru yanlış soru sayılarını tutacak değişkenler


        //  Widgets
        Button btnOyunaBasla;
        Label lbSoru, lbDogru, lbYanlis, lbPas, lbZaman1;
        TextBox textBoxCevap;
        Timer timer;
        WMPLib.WindowsMediaPlayer mediaPlayer;



        public Oyun()
        {
            InitializeComponent();
            FormDizayn();
            pictureBoxes = ts.GamePictureBox();

            for (int i = 0; i < 28; i++)
                this.Controls.Add(pictureBoxes[i]);

            PictureBoxImages = ts.Harfler();
            CreateStatus();
            CreateWidget();

        }



        private void FormDizayn()
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ControlBox = false;
            this.BackgroundImage = Properties.Resources.GameArkaPlan;
            //this.ShowIcon = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = false;
            this.Text = "";
            this.WindowState = FormWindowState.Maximized;


        }
        private void CreateWidget()
        {
            Button btnExitGame = new Button
            {
                Name = "btnExitGame",
                BackgroundImage = Properties.Resources.GameExit,
                BackgroundImageLayout = ImageLayout.Stretch,
                AutoSize = true,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(1293, 708),
                Size = new Size(73, 61),
            };

            Button btnHome = new Button
            {
                Name = "btnHome",
                BackgroundImage = Properties.Resources.home,
                BackgroundImageLayout = ImageLayout.Stretch,
                AutoSize = true,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(0, 708),
                Size = new Size(73, 61),
            };

            lbSoru = new Label
            {
                Name = "Goruntule",
                Location = new Point(465, 272),
                Size = new Size(450, 74),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                BackColor = Color.Transparent


            };
            timer = new Timer
            {
                Interval = 1000,
                Enabled = false
            };
            textBoxCevap = new TextBox
            {
                Name = "textBoxCevap",
                Location = new Point(569, 462),
                Size = new Size(216, 36),
                AutoSize = false,
                TextAlign = HorizontalAlignment.Left,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Multiline = true,
                Visible = false,



            };

            btnOyunaBasla = new Button
            {
                Name = "btnOyunaBasla",
                BackgroundImage = Properties.Resources.oyunbasla,
                BackgroundImageLayout = ImageLayout.Stretch,
                AutoSize = true,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(600, 504),
                Size = new Size(156, 36),

            };



            this.Controls.Add(btnExitGame);
            this.Controls.Add(btnHome);
            this.Controls.Add(lbSoru);
            this.Controls.Add(textBoxCevap);
            this.Controls.Add(btnOyunaBasla);

            timer.Tick += (object sender, EventArgs e) =>
            {
                saniye--;
                lbZaman1.Text = saniye.ToString();
                if (saniye == 0)
                {
                    timer.Enabled = false;
                    message.BilgiMesaj("Süreniz Bitti");
                    OyunuBitir();
                }

            };
            btnExitGame.Click += (object sender, EventArgs e) => { Application.Exit(); };
            btnHome.Click += (object sender, EventArgs e) => { this.Close(); };

            btnOyunaBasla.Click += OyunaBasla_Click;
        }
        private void CreateStatus()
        {
            Label pbDogru = new Label
            {
                BackColor = Color.Transparent,
                ForeColor = Color.DarkGreen,
                Location = new Point(50, 50),
                Text = "Doğru : ",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),

                AutoSize = true,

                TextAlign = ContentAlignment.MiddleCenter

            };
            Label pbYanlis = new Label
            {
                BackColor = Color.Transparent,
                ForeColor = Color.Red,
                Location = new Point(50, 100),
                Text = "Yanlış : ",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };
            Label pbPas = new Label
            {
                BackColor = Color.Transparent,
                ForeColor = Color.Yellow,
                Location = new Point(50, 150),
                Text = "Pas : ",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };
            lbDogru = new Label
            {
                BackColor = Color.Transparent,
                ForeColor = Color.Green,
                Location = new Point(175, 50),
                Text = dogru.ToString(),
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            lbYanlis = new Label
            {
                BackColor = Color.Transparent,
                ForeColor = Color.Red,
                Location = new Point(175, 100),
                Text = yanlis.ToString(),
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };
            lbPas = new Label
            {
                BackColor = Color.Transparent,
                ForeColor = Color.Yellow,
                Location = new Point(175, 150),
                Text = pas.ToString(),
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };


            Label lbZaman = new Label
            {
                BackColor = Color.Transparent,
                ForeColor = Color.Yellow,
                Location = new Point(1050, 50),
                Text = "Kalan Süre : ",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Size = new Size(175, 50),
                TextAlign = ContentAlignment.MiddleCenter
            };
            lbZaman1 = new Label
            {
                BackColor = Color.Transparent,
                ForeColor = Color.Yellow,
                Location = new Point(1226, 50),
                Text = saniye.ToString(),
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Size = new Size(100, 50),
                TextAlign = ContentAlignment.MiddleCenter
            };


            this.Controls.Add(pbDogru);
            this.Controls.Add(lbDogru);
            this.Controls.Add(pbYanlis);
            this.Controls.Add(lbYanlis);
            this.Controls.Add(pbPas);
            this.Controls.Add(lbPas);
            this.Controls.Add(lbZaman);
            this.Controls.Add(lbZaman1);
        }
        private void EkranaYaz()
        {
            lbSoru.Text = "";
            if (x <= 27)
            {
                lbSoru.Text = AsSoru.Sorular[x];
            }
            else
            {
                x = 0;
            }
        }
        private void Game_Load(object sender, EventArgs e)
        {

            this.AcceptButton = btnOyunaBasla;

            mediaPlayer = new WMPLib.WindowsMediaPlayer();

        }
        private void DogrulukKontrol()
        {
            //Doğru cevap ise
            if (textBoxCevap.Text == AsSoru.Cevaplar[x])
            {
                pictureBoxes[x].BackgroundImage = PictureBoxImages[x * 4 + 1];
                dogru++;
                AsSoru.Sorular[x] = "";
                lbDogru.Text = dogru.ToString();

                mediaPlayer.URL = "dogru.mp3";
                x++;
            }
            //  Pas Durumu
            else if (textBoxCevap.Text == "")
            {
                pictureBoxes[x].BackgroundImage = PictureBoxImages[x * 4 + 3];
                pas++;
                lbPas.Text = pas.ToString();

                mediaPlayer.URL = "pas.mp3";


                x++;
            }
            //  Yanlış Durumu
            else
            {
                pictureBoxes[x].BackgroundImage = PictureBoxImages[x * 4 + 2];
                yanlis++;
                lbYanlis.Text = yanlis.ToString();
                AsSoru.Sorular[x] = "";


                mediaPlayer.URL = "yanlis.mp3";
                // muzikcalar.Ctlcontrols.play();
                x++;
            }
            textBoxCevap.Text = "";
        }
        private void PasKontrol()
        {
            if (x == 28) x = 0;

            while (AsSoru.Sorular[x] == "")
            {

                if (x < 27)
                {
                    x++;
                }
                else
                {
                    OyunuBitir();
                    break;
                }
            }
        }
        private void OyunuBitir()
        {
            SkorClass.PuanYaz(SkorClass.Puanhesapla(dogru, saniye), dogru: dogru, yanlis: yanlis, pas: pas);
            this.Close();
            Skor skr = new Skor();
            skr.Show();

        }
        private void OyunuBaslat()
        {
            message.UyarıMesaj("Hazır Olunca Tamam'a Basin");
            AsSoru.SoruSec();
            EkranaYaz();
            timer.Enabled = true;
            btnOyunaBasla.BackgroundImage = Properties.Resources.cevap;
            textBoxCevap.Visible = true;
            OyunaBaslaKontrol = true;
        }
        private void OyunaBasla_Click(object sender, EventArgs e)
        {
            // Oyun Başladı ise 
            if (OyunaBaslaKontrol == true)
            {

                if (saniye > 0)
                {
                    DogrulukKontrol();
                    PasKontrol();
                    EkranaYaz();
                }
            }
            //  Oyun Başlamadıysa
            else
            {
                OyunuBaslat();
            }

        }
    }
}
