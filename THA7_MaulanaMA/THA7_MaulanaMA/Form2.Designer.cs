namespace THA7_MaulanaMA
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnl2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.JudulFilm = new System.Windows.Forms.Label();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.button4);
            this.pnl2.Location = new System.Drawing.Point(456, 36);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(314, 295);
            this.pnl2.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(55, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Layar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "12.00-14.00";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "15.00-17.00";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "19.00-21.00";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "aft.jpg");
            this.imageList1.Images.SetKeyName(1, "fre.jpg");
            this.imageList1.Images.SetKeyName(2, "jk.jpg");
            this.imageList1.Images.SetKeyName(3, "min.jpg");
            this.imageList1.Images.SetKeyName(4, "sm.jpg");
            this.imageList1.Images.SetKeyName(5, "sw.jpeg");
            this.imageList1.Images.SetKeyName(6, "tgm.png");
            this.imageList1.Images.SetKeyName(7, "unc.jpg");
            // 
            // pnl1
            // 
            this.pnl1.Location = new System.Drawing.Point(43, 36);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(199, 248);
            this.pnl1.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(34, 406);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // JudulFilm
            // 
            this.JudulFilm.AutoSize = true;
            this.JudulFilm.BackColor = System.Drawing.Color.Transparent;
            this.JudulFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulFilm.Location = new System.Drawing.Point(35, 289);
            this.JudulFilm.Name = "JudulFilm";
            this.JudulFilm.Size = new System.Drawing.Size(199, 46);
            this.JudulFilm.TabIndex = 6;
            this.JudulFilm.Text = "JudulFilm";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::THA7_MaulanaMA.Properties.Resources.vintage_old_paper_8mm_film_background_loop_video;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JudulFilm);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label JudulFilm;
    }
}