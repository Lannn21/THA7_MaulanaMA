using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA7_MaulanaMA
{
    public partial class Form2 : Form
    {
        List<Button> buttonn = new List<Button>();
        List<Image> images = new List<Image>();
        int warnamerah = 0;
        string cc = "";
        int c = 0;
        int aa = 0;
        DataTable dete = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            int x = 10;
            int y = 10;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn1 = new Button();
                    btn1.Size = new System.Drawing.Size(20, 20);
                    btn1.Location = new Point(x, y);
                    x += 20;
                    pnl2.Controls.Add(btn1);
                }
                x = 10;
                y += 20;
            } 
        }
        private void seats(int time)
        {
            dete.Rows[time][2] = cc ;
            int tes = 0;
            foreach (Button btn1 in buttonn)
            {
                if (cc[tes] == '0')
                {
                    btn1.BackColor = Color.Silver;
                }
                else
                {
                    btn1.BackColor = Color.Red;
                }
                tes++;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < 8; i++)
            {
                if (dete.Rows[i][0].ToString() == JudulFilm.Text)
                {
                    c = i;
                }
            }
            cc = dete.Rows[c][3].ToString();
            seats(2);
            aa = 2;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < 8; i++)
            {
                if (dete.Rows[i][0].ToString() == JudulFilm.Text)
                {
                    c = i;
                }
            }
            cc = dete.Rows[c][3].ToString();
            seats(3);
            aa = 3;*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < 8; i++)
            {
                if (dete.Rows[i][0].ToString() == JudulFilm.Text)
                {
                    c = i;
                }
            }
            cc = dete.Rows[c][3].ToString();
            seats(4);
            aa = 4;*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
        }
    }
}
