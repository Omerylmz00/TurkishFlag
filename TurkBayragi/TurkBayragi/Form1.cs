using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TurkBayragi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private PointF[] Noktalar = new PointF[4];


        private void button1_Click(object sender, EventArgs e)
        {

            using (var grfk = Graphics.FromImage(pictureBox1.Image))
            {
                //Bayragin dis yatay cizimleri icin ustte iki parca altta iki parca toplam 4 parca icin cizim yapilacak.
                //1
                Noktalar[0].X = 100;
                Noktalar[0].Y = 80;
                Noktalar[1].X = 120;
                Noktalar[1].Y = 90;
                Noktalar[2].X = 140;
                Noktalar[2].Y = 90;
                Noktalar[3].X = 160;
                Noktalar[3].Y = 80;

                Bezier_Egrisi.Bezier_Ciz(grfk, Pens.Red, 0.01f, Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);

                //2
                //bayrak dis yatay cizim

                Noktalar[0].X = 160;
                Noktalar[0].Y = 80;
                Noktalar[1].X = 200;
                Noktalar[1].Y = 65;
                Noktalar[2].X = 200;
                Noktalar[2].Y = 65;
                Noktalar[3].X = 240;
                Noktalar[3].Y = 70;

                Bezier_Egrisi.Bezier_Ciz(grfk, Pens.Red, 0.01f, Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);


                //3..
                //bayrak dis yatay cizim

                Noktalar[0].X = 100;
                Noktalar[0].Y = 160;
                Noktalar[1].X = 120;
                Noktalar[1].Y = 170;
                Noktalar[2].X = 140;
                Noktalar[2].Y = 170;
                Noktalar[3].X = 160;
                Noktalar[3].Y = 160;

                Bezier_Egrisi.Bezier_Ciz(grfk, Pens.Red, 0.01f, Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);

                //4
                //bayrak dis yatay cizim

                Noktalar[0].X = 160;
                Noktalar[0].Y = 160;
                Noktalar[1].X = 200;
                Noktalar[1].Y = 145;
                Noktalar[2].X = 200;
                Noktalar[2].Y = 145;
                Noktalar[3].X = 240;
                Noktalar[3].Y = 150;

                Bezier_Egrisi.Bezier_Ciz(grfk, Pens.Red, 0.01f, Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);


                //çizim düz çizgiler (bayrağın sağı - solu) için 2 kere...
                //1
                Noktalar[0].X = 100;
                Noktalar[0].Y = 80;
                Noktalar[1].X = 100;
                Noktalar[1].Y = 160;

                grfk.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

                //2          
                // bayrak dis dikey cizim

                Noktalar[0].X = 240;
                Noktalar[0].Y = 70;
                Noktalar[1].X = 240;
                Noktalar[1].Y = 150;

                grfk.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

                //bezier ile hilalleri çizelim (2 kere)

                //1. hilal
                Noktalar[0].X = 160;
                Noktalar[0].Y = 90;
                Noktalar[1].X = 100;
                Noktalar[1].Y = 105;
                Noktalar[2].X = 110;
                Noktalar[2].Y = 150;
                Noktalar[3].X = 160;
                Noktalar[3].Y = 150;

                Bezier_Egrisi.Bezier_Ciz(grfk, Pens.Red, 0.01f, Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);

                ////2. hilal
                // hilal ic cizim
                Noktalar[0].X = 160;
                Noktalar[0].Y = 90;
                Noktalar[1].X = 120;
                Noktalar[1].Y = 105;
                Noktalar[2].X = 130;
                Noktalar[2].Y = 150;
                Noktalar[3].X = 160;
                Noktalar[3].Y = 150;

                Bezier_Egrisi.Bezier_Ciz(grfk, Pens.Red, 0.01f, Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);

                //aşağıdaki örnek çizim düz çizgiler (bayrağın sağı - solu ve yıldız) için 10 kere...
                //1
                Noktalar[0].X = 190;
                Noktalar[0].Y = 100;
                Noktalar[1].X = 185;
                Noktalar[1].Y = 110;

                grfk.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

                //2
                //yildiz cizgi
                Noktalar[0].X = 185;
                Noktalar[0].Y = 110;
                Noktalar[1].X = 175;
                Noktalar[1].Y = 110;

                grfk.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);


                //3
                //yildiz cizgi
                Noktalar[0].X = 175;
                Noktalar[0].Y = 110;
                Noktalar[1].X = 185;
                Noktalar[1].Y = 117;

                grfk.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);



                //4
                //yildiz cizgi
                Noktalar[0].X = 185;
                Noktalar[0].Y = 117;
                Noktalar[1].X = 180;
                Noktalar[1].Y = 127;

                grfk.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);


                //5
                //yildiz cizgi
                Noktalar[0].X = 180;
                Noktalar[0].Y = 127;
                Noktalar[1].X = 190;
                Noktalar[1].Y = 120;

                grfk.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);


                //6
                //yildiz cizgi
                Noktalar[0].X = 190;
                Noktalar[0].Y = 120;
                Noktalar[1].X = 200;
                Noktalar[1].Y = 127;

                grfk.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);


                //7
                //yildiz cizgi
                Noktalar[0].X = 200;
                Noktalar[0].Y = 127;
                Noktalar[1].X = 197;
                Noktalar[1].Y = 118;

                grfk.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);


                //8
                //yildiz cizgi
                Noktalar[0].X = 197;
                Noktalar[0].Y = 118;
                Noktalar[1].X = 205;
                Noktalar[1].Y = 110;

                grfk.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);


                //9
                //yildiz cizgi
                Noktalar[0].X = 205;
                Noktalar[0].Y = 110;
                Noktalar[1].X = 195;
                Noktalar[1].Y = 110;

                grfk.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);


                //10
                //yildiz cizgi
                Noktalar[0].X = 195;
                Noktalar[0].Y = 110;
                Noktalar[1].X = 190;
                Noktalar[1].Y = 100;

                grfk.DrawLine(Pens.Red, Noktalar[0], Noktalar[1]);

                pictureBox1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var grfk = Graphics.FromImage(pictureBox1.Image))
            {
                // picture box temizlenmesi icin gereken kodlar yazilacak
                grfk.Clear(Color.White);
                pictureBox1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // uygulamanin kapatilmasi icin gerekli kodlamalar yazilacak
            System.Windows.Forms.Application.Exit();
        }
    }
}
