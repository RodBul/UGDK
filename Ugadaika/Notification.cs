using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ugadaika
{
    public partial class Notification : Form
    {

        Screen secondScreen;
        public Notification(string text)
        {
            if (Screen.AllScreens.Length > 1)
                secondScreen = Screen.AllScreens[1];
            else
                secondScreen = Screen.AllScreens[0];

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;//цвет фона  
            this.TransparencyKey = this.BackColor;//он же будет заменен на прозрачный цвет
            textOnImage(text);
        }

        private void textOnImage(string text)
        {
            Graphics G = Graphics.FromImage(pictureBox1.Image);
            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            Rectangle Rect = new Rectangle((int)(0.32 * pictureBox1.ClientSize.Width), (int)(0.18 * pictureBox1.ClientSize.Height), (int)(0.42 * pictureBox1.ClientSize.Width), (int)(0.52 * pictureBox1.ClientSize.Height));

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            G.DrawString(text, new Font("Arial", fontSize(text)), Brushes.Black, Rect, sf);

            sf.Dispose();
            moveNotification();
        }


        int fontSize(string text)
        {
            //60 шрифта влезает 2 строки
            //в одной строке 60 6-11 символов

            //45 шрифта влезает 3 строки
            //в одной строке 45 8-15 символов

            //32 шрифта влезает 4 строки
            //в одной строке 32 12-22
            int numberOfSumbols = text.Length;
            if (numberOfSumbols < 20)
                return 60;
            else if (numberOfSumbols < 36)
                return 45;
            else
                return 32;
        }
        void moveNotification()
        {
            timer1.Enabled = true;
        }
        void moveNotificationPlus(object sender, EventArgs e)
        {

            this.Location = new Point(this.Location.X, this.Location.Y - 20);
            if (this.Location.Y < secondScreen.Bounds.Height - 300)
            {
                timer1.Stop();
                timer2.Enabled = true;
            }
        }
        void moveNotificationWait(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Enabled = true;
        }
        void moveNotificationMinus(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, this.Location.Y + 20);
            if (this.Location.Y > secondScreen.Bounds.Height)
            {
                timer2.Stop();
                this.Dispose();
                this.Close();
            }
        }


    }
}
