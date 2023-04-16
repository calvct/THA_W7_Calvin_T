using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace THA_W7_Calvin_T
{
    public partial class movieslist : Form
    {
        public static List<Button>[,] memilih = new List<Button>[100, 100];
        public static movieslist listmovie;
        public static Panel panels1;
        seats seats;
        Panel panels2;
        Panel panels3;
        Panel panels4;
        public static int[,] pilih = new int[100, 100];
        public static int a = 0;
        Button[] btn = new Button[3];
        Button button = new Button();
        PictureBox[] pictureBox1 = new PictureBox[8];
        public static Label[] label1 = new Label[8];
        Label time_label;
        Label judul = new Label();
        Label seat = new Label();
        Button back = new Button();
        public static string jam = "";
        static string movies = File.ReadAllText(@"C:\Users\Calvin CT\source\repos\THA_W7_Calvin_T\THA_W7_Calvin_T\movies\movie.txt");
        string[] movie = movies.Split(',');
        int x = 8;
        int y = 0;
        public static int select = 0;
        public static int hours = 0;
        Random rnd = new Random();

        public movieslist()
        {
            InitializeComponent();
            listmovie = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatepanel();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panels2.Visible = true;
            panels3.Visible = true;
            panels1.Dock = DockStyle.Left;
            judul.TextAlign = ContentAlignment.MiddleLeft;
            judul.Padding = new Padding(300,0,0,0);
            time_label.TextAlign = ContentAlignment.MiddleCenter;
            time_label.Text = "What time do you want to watch the movie?".ToUpper();
            time_label.Font = new Font("Montserrat", 12, FontStyle.Bold);
            time_label.MaximumSize = new Size(200, 0);
            panels2.Controls.Clear();
            panels3.Controls.Clear();
            panels2.Controls.Add(time_label);

            for (int i = 0; i< 8; i++)
            {
                if (sender == pictureBox1[i])
                {
                    select = i;

                }
                
            }
            switch (select)
            {
                case 0:
                    for (int j = 0; j < 3; j++)
                    {
                        btn[j] = new Button();
                        btn[j].Size = new Size(130, 50);
                        btn[j].Location = new Point(60, 120 + (j * 100));
                        if (j == 0)
                        {
                            btn[j].Text = "13.20";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "16.00";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "17.15";
                            btn[j].Tag = btn[j].Text;
                        }
                        panels2.Controls.Add(btn[j]);
                        btn[j].Click += button_Click;
                    }
                    break;
                case 1:

                    for (int j = 0; j < 3; j++)
                    {
                        btn[j] = new Button();
                        btn[j].Size = new Size(130, 50);
                        btn[j].Location = new Point(60, 120 + (j * 100));
                        if (j == 0)
                        {
                            btn[j].Text = "11.00";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "13.00";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "19.15";
                            btn[j].Tag = btn[j].Text;
                        }


                        panels2.Controls.Add(btn[j]);
                        btn[j].Click += button_Click;
                    }
                    break;
                case 2:

                    for (int j = 0; j < 3; j++)
                    {
                        btn[j] = new Button();
                        btn[j].Size = new Size(130, 50);
                        btn[j].Location = new Point(60, 120 + (j * 100));
                        if (j == 0)
                        {
                            btn[j].Text = "12.30";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "14.45";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "17.15";
                            btn[j].Tag = btn[j].Text;
                        }


                        panels2.Controls.Add(btn[j]);
                        btn[j].Click += button_Click;
                    }
                    break;
                case 3:

                    for (int j = 0; j < 3; j++)
                    {
                        btn[j] = new Button();
                        btn[j].Size = new Size(130, 50);
                        btn[j].Location = new Point(60, 120 + (j * 100));
                        if (j == 0)
                        {
                            btn[j].Text = "17.20";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "19.00";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "20.15";
                            btn[j].Tag = btn[j].Text;
                        }


                        panels2.Controls.Add(btn[j]);
                        btn[j].Click += button_Click;
                    }
                    break;
                case 4:

                    for (int j = 0; j < 3; j++)
                    {
                        btn[j] = new Button();
                        btn[j].Size = new Size(130, 50);
                        btn[j].Location = new Point(60, 120 + (j * 100));
                        if (j == 0)
                        {
                            btn[j].Text = "11.00";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "16.00";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "19.20";
                            btn[j].Tag = btn[j].Text;
                        }


                        panels2.Controls.Add(btn[j]);
                        btn[j].Click += button_Click;
                    }
                    break;
                case 5:
                    for (int j = 0; j < 3; j++)
                    {
                        btn[j] = new Button();
                        btn[j].Size = new Size(130, 50);
                        btn[j].Location = new Point(60, 120 + (j * 100));
                        if (j == 0)
                        {
                            btn[j].Text = "17.15";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "18.00";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "20.45";
                            btn[j].Tag = btn[j].Text;
                        }
                        panels2.Controls.Add(btn[j]);
                        btn[j].Click += button_Click;
                    }
                    break;
                case 6:

                    for (int j = 0; j < 3; j++)
                    {
                        btn[j] = new Button();
                        btn[j].Size = new Size(130, 50);
                        btn[j].Location = new Point(60, 120 + (j * 100));
                        if (j == 0)
                        {
                            btn[j].Text = "13.20";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "18.10";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "19.05";
                            btn[j].Tag = btn[j].Text;
                        }
                        panels2.Controls.Add(btn[j]);
                        btn[j].Click += button_Click;
                    }
                    break;
                case 7:

                    for (int j = 0; j < 3; j++)
                    {
                        btn[j] = new Button();
                        btn[j].Size = new Size(130, 50);
                        btn[j].Location = new Point(60, 120 + (j * 100));
                        if (j == 0)
                        {
                            btn[j].Text = "12.10";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "15.25";
                            btn[j].Tag = btn[j].Text;
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "20.15";
                            btn[j].Tag = btn[j].Text;
                        }
                        panels2.Controls.Add(btn[j]);
                        btn[j].Click += button_Click;
                    }
                    
                    break;
                    
            }
            back.Size = new Size(30, 30);
            back.Text = "X";
            back.Location = new Point(0, 0);
            panels2.Controls.Add(back);
            back.Click += Back_Click;

        }


        private void Back_Click(object sender, EventArgs e)
        {
            panels2.Visible = false;
            panels1.Dock = DockStyle.Fill;
            judul.TextAlign = ContentAlignment.MiddleCenter;
            judul.Padding = new Padding(0, 0, 0, 0);
        }

        private void button_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                if (sender == btn[i])
                {
                    hours = i;
                    jam = btn[hours].Text;
                }

            }
            a = rnd.Next(1, 70);
            if (pilih[select,hours] == 0)
            {
                pilih[select, hours] = a;
                seat.Text = "Remaining seat: " + (100 - pilih[select, hours]);
            }
            else if (pilih[select,hours] == 101)
            {
                seat.Text = "Remaining seat: 100";
            }
            else
            {
                seat.Text = "Remaining seat: " + (100 - pilih[select, hours]);
            }
            
            
            seat.AutoSize = true;
            seat.Location = new Point(20, 30);
            seat.Font = new Font("Montserrat",10,FontStyle.Regular);
            panels3.Controls.Add(seat);
            button.Text = "Select Seat";

            button.Location = new Point(0, 100);
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.ForeColor = Color.White;
            button.BackColor = Color.Teal;
            button.Font = new Font("Montserrat", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            button.Size = new Size(264, 70);
            panels3.Controls.Add(button);
            button.Click += Button_Click;
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            panels1.AutoScroll = false;
            panels2.Visible = false;
            panels3.Visible = false;
            panels4.Visible = false;
            panels1.Dock = DockStyle.Fill;
            //panels1.Hide();
            this.Controls.Clear();
            seats = new seats();
            seats.Dock = DockStyle.Fill;
            seats.TopLevel = false;
            this.Controls.Add(seats);
            seats.Show();

        }


        public void updatepanel()
        {
            panels1 = new Panel();
            panels1.Size = new Size(1030, 680);
            panels1.Dock = DockStyle.Fill;
            panels1.Location = new Point(1, 1);
            panels1.BackColor = Color.Teal;
            this.Controls.Add(panels1);
            panels2 = new Panel();
            panels2.Size = new Size(265,495);
            panels2.Location = new Point(1030, 1);
            this.Controls.Add(panels2);
            panels3 = new Panel();
            panels3.Size = new Size(264,185);
            panels3.Location = new Point(1030, 495);
            this.Controls.Add(panels3);
            panels2.Visible = false;
            panels3.Visible = false;
            panels1.AutoScroll = true;
            time_label = new Label();
            time_label.Location = new Point(30, 20);
            time_label.AutoSize = true;
            panels4 = new Panel();
            panels4.Dock = DockStyle.Top;
            panels4.Location = new Point(40, 50);
            panels4.BringToFront();
            panels4.BackColor = Color.Teal;
            this.Controls.Add(panels4);
            judul = new Label();
            judul.Text = "What Film Do You Want To Watch";
            judul.Location = new Point((panels4.Width- judul.Width )/ 2, 0); ;
            judul.Dock = DockStyle.Fill;
            judul.BringToFront();
            judul.TextAlign = ContentAlignment.MiddleCenter;
            judul.AutoSize = false;
            judul.Height = 50;
            judul.MaximumSize = new Size(2000, 0);
            judul.ForeColor = Color.White;
            judul.Font = new Font("Montserrat", 20, FontStyle.Bold);
            judul.TextAlign = ContentAlignment.MiddleCenter;
            panels4.Controls.Add(judul);

            for (int i = 0; i < pictureBox1.Length; i++)
            {
                label1[i] = new Label();
                pictureBox1[i] = new PictureBox();
                pictureBox1[i].Image = Image.FromFile(movie[x]);
                pictureBox1[i].Size = new Size(235, 300);
                pictureBox1[i].Location = new Point(30 + (50 * i * 5), 40);
                if (i == 7)
                {
                    pictureBox1[i].Padding = new Padding(0, 0, 30, 0);
                }
                pictureBox1[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1[i].Tag = i.ToString();
                panels1.Controls.Add(pictureBox1[i]);
                x++;




                label1[i].Text = movie[y].ToUpper();
                label1[i].TextAlign = ContentAlignment.MiddleCenter;
                label1[i].ForeColor = Color.White;
                label1[i].AutoSize = true;
                label1[i].AutoEllipsis = true;
                label1[i].MaximumSize = new Size(210, 0);
                label1[i].Font = new Font("Montserrat", 12, FontStyle.Bold, GraphicsUnit.World);
                if (i < 1)
                {
                    label1[i].Location = new Point(60 + (230 * i), 340);
                }
                else if (i < 2 && i > 0)
                {
                    label1[i].Location = new Point(75 + (230 * i), 340);
                }
                else if (i < 3 && i > 1)
                {
                    label1[i].Location = new Point(65 + (245 * i), 340);
                }
                else if (i > 2 && i < 5)
                {
                    label1[i].Location = new Point(65 + (250 * i), 340);
                }
                else if (i < 7 && i > 4)
                {
                    label1[i].Location = new Point(110 + (250 * i), 340);
                }
                else
                {
                    label1[i].Location = new Point(47 + (250 * i), 340);
                }

                panels1.Controls.Add(label1[i]);
                y++;
                pictureBox1[i].Click += pictureBox1_Click;
            }
            
        }
    }
}

        
