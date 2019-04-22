using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 
A  655 67
B  723 76
C  791 95
Ç  853; 134
D  900; 186
E  936; 238
F  963; 300
G  972; 371

H  954; 442
I  936; 504
İ  900; 566
J  853; 617
K  791; 655
L  723; 673
M  655; 685

N  587; 676
O  519; 655
Ö  465; 617
P  415; 566
R  375; 513
S  347; 442
Ş  336; 371
T  347; 300
U  375; 229

Ü  415; 176
V  465; 124
Y  519; 95
Z  587; 76
*/


namespace Pasaparola
{
    class Tasarim
    {
        public List<Bitmap> harfler;
        public Tasarim()
        {
            harfler = Harfler();
        }
        public List<PictureBox> GamePictureBox()
        {
            int[,] pictureboxLocation = new int[28, 2] {
                    {655,67},   {723,76},   {791,95},
                    {853, 134}, {900, 186}, {936, 238},
                    {963, 300}, {972, 371}, {954, 442},
                    {936, 504}, {900, 566}, {853, 617},
                    {791, 655}, {723, 673}, {655, 685},
                    {587, 676}, {519, 655}, {465, 617},
                    {415, 566}, {375, 513}, {347, 442},
                    {336, 371}, {347, 300}, {375, 229},
                    {415, 176}, {465, 124}, {519, 95},
                    {587, 76}
            };
            List<PictureBox> pictureBoxes = new List<PictureBox>();


            for (int i = 0; i < 28; i++)
            {
                PictureBox pictureBox = new PictureBox
                {
                    BackgroundImage = harfler[4 * i],
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Size = new Size(62, 56),
                    Location = new Point(pictureboxLocation[i, 0], pictureboxLocation[i, 1]),
                    BackColor = Color.Transparent


                };
                pictureBoxes.Add(pictureBox);

            }
            return pictureBoxes;

        }
        public List<Bitmap> Harfler()
        {
            List<Bitmap> harfler = new List<Bitmap>
            {
                new Bitmap(Properties.Resources.a),
                new Bitmap(Properties.Resources.a_yesil),
                new Bitmap(Properties.Resources.a_kirmizi),
                new Bitmap(Properties.Resources.a_sari),

                new Bitmap(Properties.Resources.b),
                new Bitmap(Properties.Resources.b_yesil),
                new Bitmap(Properties.Resources.b_kirmizi),
                new Bitmap(Properties.Resources.b_sari),

                new Bitmap(Properties.Resources.c),
                new Bitmap(Properties.Resources.c_yesil),
                new Bitmap(Properties.Resources.c_kirmizi),
                new Bitmap(Properties.Resources.c_sari),

                new Bitmap(Properties.Resources.ç),
                new Bitmap(Properties.Resources.ç_yesil),
                new Bitmap(Properties.Resources.ç_kirmizi),
                new Bitmap(Properties.Resources.ç_sari),

                new Bitmap(Properties.Resources.d),
                new Bitmap(Properties.Resources.d_yesil),
                new Bitmap(Properties.Resources.d_kirmizi),
                new Bitmap(Properties.Resources.d_sari),

                new Bitmap(Properties.Resources.e),
                new Bitmap(Properties.Resources.e_yesil),
                new Bitmap(Properties.Resources.e_kirmizi),
                new Bitmap(Properties.Resources.e_sari),

                new Bitmap(Properties.Resources.f),
                new Bitmap(Properties.Resources.f_yesil),
                new Bitmap(Properties.Resources.f_kirmizi),
                new Bitmap(Properties.Resources.f_sari),

                new Bitmap(Properties.Resources.g),
                new Bitmap(Properties.Resources.g_yesil),
                new Bitmap(Properties.Resources.g_kirmizi),
                new Bitmap(Properties.Resources.g_sari),

                new Bitmap(Properties.Resources.h),
                new Bitmap(Properties.Resources.h_yesil),
                new Bitmap(Properties.Resources.h_kirmizi),
                new Bitmap(Properties.Resources.h_sari),

                new Bitmap(Properties.Resources.ı),
                new Bitmap(Properties.Resources.ı_yesil),
                new Bitmap(Properties.Resources.ı_kirmizi),
                new Bitmap(Properties.Resources.ı_sari),

                new Bitmap(Properties.Resources.i),
                new Bitmap(Properties.Resources.i_yesil),
                new Bitmap(Properties.Resources.i_kirmizi),
                new Bitmap(Properties.Resources.i_sari),

                new Bitmap(Properties.Resources.j),
                new Bitmap(Properties.Resources.j_yesil),
                new Bitmap(Properties.Resources.j_kirmizi),
                new Bitmap(Properties.Resources.j_sari),

                new Bitmap(Properties.Resources.k),
                new Bitmap(Properties.Resources.k_yesil),
                new Bitmap(Properties.Resources.k_kirmizi),
                new Bitmap(Properties.Resources.k_sari),

                new Bitmap(Properties.Resources.l),
                new Bitmap(Properties.Resources.l_yesil),
                new Bitmap(Properties.Resources.l_kirmizi),
                new Bitmap(Properties.Resources.l_sari),

                new Bitmap(Properties.Resources.m),
                new Bitmap(Properties.Resources.m_yesil),
                new Bitmap(Properties.Resources.m_kirmizi),
                new Bitmap(Properties.Resources.m_sari),

                new Bitmap(Properties.Resources.n),
                new Bitmap(Properties.Resources.n_yesil),
                new Bitmap(Properties.Resources.n_kirmizi),
                new Bitmap(Properties.Resources.n_sari),

                new Bitmap(Properties.Resources.o),
                new Bitmap(Properties.Resources.o_yesil),
                new Bitmap(Properties.Resources.o_kirmizi),
                new Bitmap(Properties.Resources.o_sari),

                new Bitmap(Properties.Resources.ö),
                new Bitmap(Properties.Resources.ö_yesil),
                new Bitmap(Properties.Resources.ö_kirmizi),
                new Bitmap(Properties.Resources.ö_sari),

                new Bitmap(Properties.Resources.p),
                new Bitmap(Properties.Resources.p_yesil),
                new Bitmap(Properties.Resources.p_kirmizi),
                new Bitmap(Properties.Resources.p_sari),

                new Bitmap(Properties.Resources.r),
                new Bitmap(Properties.Resources.r_yesil),
                new Bitmap(Properties.Resources.r_kirmizi),
                new Bitmap(Properties.Resources.r_sari),

                new Bitmap(Properties.Resources.s),
                new Bitmap(Properties.Resources.s_yesil),
                new Bitmap(Properties.Resources.s_kirmizi),
                new Bitmap(Properties.Resources.s_sari),

                new Bitmap(Properties.Resources.ş),
                new Bitmap(Properties.Resources.ş_yesil),
                new Bitmap(Properties.Resources.ş_kirmizi),
                new Bitmap(Properties.Resources.ş_sari),

                new Bitmap(Properties.Resources.t),
                new Bitmap(Properties.Resources.t_yesil),
                new Bitmap(Properties.Resources.t_kirmizi),
                new Bitmap(Properties.Resources.t_sari),

                new Bitmap(Properties.Resources.u),
                new Bitmap(Properties.Resources.u_yesil),
                new Bitmap(Properties.Resources.u_kirmizi),
                new Bitmap(Properties.Resources.u_sari),

                new Bitmap(Properties.Resources.ü),
                new Bitmap(Properties.Resources.ü_yesil),
                new Bitmap(Properties.Resources.ü_kirmizi),
                new Bitmap(Properties.Resources.ü_sari),

                new Bitmap(Properties.Resources.v),
                new Bitmap(Properties.Resources.v_yesil),
                new Bitmap(Properties.Resources.v_kirmizi),
                new Bitmap(Properties.Resources.v_sari),

                new Bitmap(Properties.Resources.y),
                new Bitmap(Properties.Resources.y_yesil),
                new Bitmap(Properties.Resources.y_kirmizi),
                new Bitmap(Properties.Resources.y_sari),

                new Bitmap(Properties.Resources.z),
                new Bitmap(Properties.Resources.z_yesil),
                new Bitmap(Properties.Resources.z_kirmizi),
                new Bitmap(Properties.Resources.z_sari),

            };
            return harfler;
        }

    }
}