using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int timeLeft = 30;
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label7.Text = timeLeft.ToString();
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            //  this.Cursor = CreateCur((Bitmap)imageList1.Images[0], new Size(100, 100));
            panel1.Visible = true;
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button9.Visible = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            --timeLeft;
            label7.Text = timeLeft.ToString();

            if (timeLeft == 0)
            {
                timer1.Stop();
                MessageBox.Show("Время вышло!");
            }
        }

        public static Cursor CreateCur(Bitmap bm, Size size)
        {
            bm = new Bitmap(bm, size);
            return new Cursor(bm.GetHicon());
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            timeLeft = 30;
            MessageBox.Show("Вы проиграли! Попробуйте еще раз");
            panel1.Visible = false;
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            int time = 30 - timeLeft;

            timer1.Stop();
            MessageBox.Show("Ты молодец!\n" + "Твоё время составило: " + time.ToString() + " секунд");
            panel1.Visible = false;
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            timeLeft = 30;
        }
    }
}
