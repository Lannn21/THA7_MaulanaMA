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
    public partial class Form1 : Form
    {
        
        List<Image> movielist = new List<Image>();
        DataTable dt = new DataTable();
        Random rndm = new Random();
        int film = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private string randomm()
        {
            string random = "";
            for (int i = 0; i < 100; i++)
            {
                int persen = rndm.Next(0, 101);
                if (persen > 30)
                {
                    random = random + rndm.Next(0, 2).ToString();
                }
                else
                {
                    random = random + "0";
                }
            }
            return random;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Pe();
        }
        private void Pe()
        {
            int cnt = 0;
            int cnt2 = 0;
            for (int i = 0; i < 4; i++)
            {
                Button btn = new Button();
                btn.Enabled = true;
                btn.Visible = true;
                btn.Location = new Point(20 + cnt, 175);
                btn.Size = new Size(80, 25);
                btn.Tag = i.ToString();
                film = i;
                btn.Text = "Select";
                cnt = cnt + 130;
                btn.Click += btn_click;
                this.Controls.Add(btn);
            }
            for (int i = 0; i < 4; i++)
            {
                Button btn = new Button();
                btn.Enabled = true;
                btn.Visible = true;
                btn.Location = new Point(20 + cnt2, 330);
                btn.Size = new Size(80, 25);
                btn.Tag = i.ToString();
                film = i;
                btn.Text = "Select";
                cnt2 = cnt2 + 130;
                btn.Click += btn_click;
                this.Controls.Add(btn);
            }
        }
        private void btn_click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            pnl1.Visible = true;
            pnl1.Enabled = true;
            form2.Dock = DockStyle.Fill;
            form2.TopLevel = false;
            this.pnl1.Controls.Add(form2);
            form2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
