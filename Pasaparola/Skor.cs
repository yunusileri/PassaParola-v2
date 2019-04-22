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
    public partial class Skor : Form
    {
        DataGridView datagrid;

        public Skor()
        {
            InitializeComponent();
            FormDizayn();
            CreateWidget();
            DataGrid();
        }


        private void FormDizayn()
        {
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.ControlBox = false;
            this.BackgroundImage = Properties.Resources.skorArkaPlan;

            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = false;

            this.Size = new Size(827, 549);


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
                Location = new Point(721, 445),
                Size = new Size(73, 61),
            };

            Button btnHome = new Button
            {
                Name = "btnHome",
                BackgroundImage = Properties.Resources.home,
                BackgroundImageLayout = ImageLayout.Stretch,
                AutoSize = true,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(0, 445),
                Size = new Size(73, 61),
            };
            Button btnYeniOyun = new Button
            {
                Name = "btnYeniOyun",
                BackgroundImage = Properties.Resources.refresh,
                BackgroundImageLayout = ImageLayout.Stretch,
                AutoSize = true,
                FlatStyle = FlatStyle.Popup,
                Location = new Point(74, 445),
                Size = new Size(73, 61),
            };
            this.Controls.Add(btnExitGame);
            this.Controls.Add(btnHome);
            this.Controls.Add(btnYeniOyun);
            btnExitGame.Click += (object sender, EventArgs e) => { Application.Exit(); };
            btnHome.Click += (object sender, EventArgs e) => { this.Close(); };
            btnYeniOyun.Click += (object sender, EventArgs e) =>
            {
                Oyun oyun = new Oyun();
                oyun.Show();
                this.Close();
            };
        }
        private void DataGrid()
        {
            datagrid = new DataGridView
            {
                Location = new Point(164, 138),
                Size = new Size(443, 256),
                BorderStyle = BorderStyle.FixedSingle,
                BackgroundColor = Color.Black,
                CellBorderStyle = DataGridViewCellBorderStyle.Single,
                RowHeadersWidth = 41,
                ColumnHeadersHeight = 18,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                AllowUserToOrderColumns = true
            };
            this.Controls.Add(datagrid);


        }
        private void EnYuksekSkor()
        {
            Skor skr = new Skor();

            // EnYüksek.Text = "En Yüksek Skor :" + skr.EnyüksekSkor();
            Label yuksekSkor = new Label
            {
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            };
        }
        private void Skor_Load(object sender, EventArgs e)
        {
            datagrid.DataSource = SkorClass.SkorGoruntule().Tables["Tablo2"];
        }
    }
}
