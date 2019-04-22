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
    public partial class Anasayfa : Form
    {

        public Anasayfa()
        {
            InitializeComponent();
            HomeDizayn();
        }
        private void HomeDizayn()
        {

            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.AutoSize = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.BackgroundImage = Properties.Resources.Home_ArkaPlan;
            this.ShowIcon = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(878, 486);


        }
        private void BtnCreate()
        {

            Button btnYeniOyun = new Button
            {
                Name = "btnYeniOyun",
                BackgroundImage = Properties.Resources.oyunaBasla,
                BackgroundImageLayout = ImageLayout.Stretch,
                AutoSize = true,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(154, 85),
                Size = new Size(532, 191),
            };

            Button btnSkor = new Button
            {
                Name = "btnSkor",
                BackgroundImage = Properties.Resources.Skor,
                BackgroundImageLayout = ImageLayout.Stretch,
                AutoSize = true,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(154, 282),
                Size = new Size(263, 142),
            };
            Button btnNasilOynanir = new Button
            {
                Name = "btnNasilOynanir",
                BackgroundImage = Properties.Resources.nasılOynanır,
                BackgroundImageLayout = ImageLayout.Stretch,
                AutoSize = true,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(423, 282),
                Size = new Size(263, 142),
            };

            Button btnMinimize = new Button
            {
                Name = "btnMinimize",
                BackgroundImage = Properties.Resources.minimize,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(808, 1),
                Size = new Size(34, 31),
                BackColor = Color.Transparent
            };
            Button btnExit = new Button
            {
                Name = "btnExit",
                BackgroundImage = Properties.Resources.exit,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(848, 1),
                Size = new Size(29, 31),
                BackColor = Color.Transparent
            };

            this.Controls.Add(btnYeniOyun);
            this.Controls.Add(btnSkor);
            this.Controls.Add(btnNasilOynanir);
            this.Controls.Add(btnMinimize);
            this.Controls.Add(btnExit);


            btnYeniOyun.Click += (object sender, EventArgs e) =>
            {
                Oyun game = new Oyun();
                game.Show();
            };

            btnSkor.Click += (object sender, EventArgs e) =>
            {
                Skor skor = new Skor();
                skor.Show();
            };

            btnNasilOynanir.Click += (object sender, EventArgs e) =>
            {
                NasılOynanir nasılOynanir = new NasılOynanir();
                nasılOynanir.Show();
            };
            btnMinimize.Click += (object sender, EventArgs e) =>
            {
                WindowState = FormWindowState.Minimized;
            };
            btnExit.Click += (object sender, EventArgs e) =>
            {
                Application.Exit();
            };
        }
        private void Home_Load(object sender, EventArgs e)
        {
            BtnCreate();


        }
    }
}
