using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day16_baloons
{


    public partial class Form1 : Form
    {
        baloon[] b_mas;
        int hits = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //0. jāizvēlās [randoms] skaits balonu
            //cik liels būs masīva izmērs ?


            int b_skaits = this.ClientRectangle.Width / Properties.Resources.red.Width;
            Random r = new Random();
            int sk = r.Next(1, b_skaits - 1);


            b_mas = new baloon[sk];

            int offset = 0;

            for (int i=0; i< b_mas.Length; i++)
            {
                int kr = r.Next(1,4);

                Bitmap image = null;
 
                switch (kr)
                {
                    case 1:
                        image = Properties.Resources.blue;
                        break;
                    case 2:
                        image = Properties.Resources.red;
                        break;
                    case 3:
                        image = Properties.Resources.yellow;
                        break;
                }


                //ko vēl vajag ?
                //vajag visu sarēķināt un instancēt
                // baloon(int aatrums, int izmX, int izmY, int saakX, int saakY, Bitmap bilde, int max)


                b_mas[i] = new baloon(r.Next(1, 10), image.Width, image.Height, offset , 10, image, this.ClientRectangle.Height);
                offset += image.Width + 10;
                this.Controls.Add(b_mas[i]);

            }



            timer1.Start();









        }

        private void eJPRomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nācAtpakaļToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int survivors = 0;
            
            
            //foreach (baloon b in b_mas)
            for (int i=0; i< b_mas.Length; i++)
            {
                if (b_mas[i] == null)
                    continue;

                survivors += b_mas[i].survived;
                if (b_mas[i].shot)
                {
                    hits++;
                    b_mas[i] = null;
                }

            }

            Survivors.Text = "Survivors : " + survivors;
            Hits.Text = "Hits : " + hits;
        }
    }


    class baloon : PictureBox
    {
        public int survived;
        public bool shot;

        //kam klasē jābūt ?
        //ātrums : kā mēs ātrumu rēķināsim ?
        int speed;
        int sizeX;
        int sizeY;
        int startX;
        int startY;
        int maxY;



        //šis katras 50ms atjauninās balona pozīciju
        Timer t;

        //vai vajag bitmapa lauku ?

        public baloon (int aatrums, int izmX, int izmY, int saakX, int saakY, Bitmap bilde, int max)
        {

            //System.Media.SoundPlayer sp = new System.Media.SoundPlayer("fails.mp3");

            //kautkas jādara
            shot = false;
            survived = 0;
            maxY = max;
            speed = aatrums;
            sizeX = izmX;
            sizeY = izmY;
            startX = saakX;
            startY = saakY;
            this.Image = bilde;
            this.Location = new Point(startX, startY);

            //šo neuzstādot bildes ir izkropļotas !
            this.Size = new Size(sizeX, sizeY);
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Click += Baloon_Click;

            t = new Timer();

            t.Interval = 50;
            t.Tick += T_Tick;
            t.Start();
        }

        private void Baloon_Click(object sender, EventArgs e)
        {
            //atskaņot skaņu !!!
            shot = true;
            t.Stop();
            this.Dispose();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            //ko šeit jādara ?
            this.Location = new Point(this.Location.X, this.Location.Y + speed);
            
            Application.DoEvents();//maybe neobligāts, jo taimeri ir trīdi !!!

            //pārbaudīt vai nav ārpus ekrāna !!!

            if (this.Location.Y > maxY)
            {
                //t.Stop();
                //this.Dispose();
                this.Location = new Point(startX, startY);
                survived++;
            }


        }
    }
}
