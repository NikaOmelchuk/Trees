using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        Graphics g;

        Tree[] t = new Tree[500];

        Param[] p = new Param[3];

        ParamOneTree p1 = new ParamOneTree();
        ParamTwoTree p2 = new ParamTwoTree();
        ParamThreeTree p3 = new ParamThreeTree();

        int count = 0;
        Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int o = r.Next(1, 4);

            if (o == 1)
                t[count] = new Tree(r.Next(10, 950), r.Next(10, 750), 50,50, p1);
            else if (o == 2)
                t[count] = new Tree(r.Next(10, 950), r.Next(10, 750), 50, 50, p2);
            else 
                t[count] = new Tree(r.Next(10, 950), r.Next(10, 750), 50, 50, p3);

            g.DrawImage(t[count].p.pic, new Rectangle(t[count].x, t[count].y, t[count].p.h, t[count].p.w));

            if (count < 499)
                count++;
            else
                timer1.Stop();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] != null)
                {
                    g.FillRectangle(new SolidBrush(Color.LightGreen), new Rectangle(t[i].x, t[i].y, t[i].h, t[i].w)); ;
                    t[i].rost();
                    g.DrawImage(t[i].p.pic, new Rectangle(t[i].x, t[i].y, t[i].h, t[i].w));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }
    }
}