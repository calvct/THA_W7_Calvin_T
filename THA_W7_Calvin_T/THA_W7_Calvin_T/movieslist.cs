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
        public static movieslist listmovie;
        public static Panel panels1;
        seats seats;
        Panel panels2;
        Panel panels3;
        public static int[,] pilih = new int[100, 100];
        public static int a = 0;
        Button[] btn = new Button[3];
        Button button = new Button();
        PictureBox[] pictureBox1 = new PictureBox[8];
        Label[] label1 = new Label[8];
        Label time_label;
        Label seat = new Label();
        static string movies = File.ReadAllText(@"C:\Users\Calvin CT\source\repos\THA_W7_Calvin_T\THA_W7_Calvin_T\movies\movie.txt");
        string[] movie = movies.Split(',');
        int x = 0;
        int y = 1;
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
            //pictureBox1[select].BorderStyle = BorderStyle.Fixed3D;
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
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "16.00";
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "17.15";
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
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "13.00";
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "19.15";
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
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "14.45";
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "17.15";
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
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "19.00";
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "20.15";
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
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "16.00";
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "19.20";
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
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "18.00";
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "20.45";
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
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "18.10";
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "19.05";
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
                        }
                        else if (j == 1)
                        {
                            btn[j].Text = "15.25";
                        }
                        else if (j == 2)
                        {
                            btn[j].Text = "20.15";
                        }
                        panels2.Controls.Add(btn[j]);
                        btn[j].Click += button_Click;
                    }
                    
                    break;
                    
            }
            

        }
        private void button_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                if (sender == btn[i])
                {
                    hours = i;

                }

            }
            a = rnd.Next(1, 70);
            if (pilih[select,hours] == 0)
            {
                pilih[select, hours] = a;
                seat.Text = "Remaining seat: " + (100- pilih[select, hours]);
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
            panels1.Dock = DockStyle.Fill;
            panels1.Hide();
            this.Controls.Clear();
            seats = new seats();
            seats.TopLevel = false;
            seats.Dock = DockStyle.Fill;
            this.Controls.Add(seats);
            seats.Show();
            //this.Hide();
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
            //panel1.Dock = DockStyle.Fill;
            //panel1.BackColor = Color.Teal;
            panels1.AutoScroll = true;
            time_label = new Label();
            time_label.Location = new Point(30, 20);
            time_label.AutoSize = true;


            for (int i = 0; i < pictureBox1.Length; i++)
            {
                label1[i] = new Label();
                pictureBox1[i] = new PictureBox();
                pictureBox1[i].Image = Image.FromFile(movie[x]);
                pictureBox1[i].Size = new Size(235, 300);
                pictureBox1[i].Location = new Point(30 + (50 * i * 5), 140);
                if (i == 7)
                {
                    pictureBox1[i].Padding = new Padding(0, 0, 30, 0);
                }
                pictureBox1[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1[i].Tag = i.ToString();
                panels1.Controls.Add(pictureBox1[i]);
                x += 2;




                label1[i].Text = movie[y].ToUpper();
                label1[i].TextAlign = ContentAlignment.MiddleCenter;
                label1[i].AutoSize = true;
                label1[i].AutoEllipsis = true;
                label1[i].MaximumSize = new Size(210, 0);
                label1[i].Font = new Font("Montserrat", 12, FontStyle.Bold, GraphicsUnit.World);
                if (i < 1)
                {
                    label1[i].Location = new Point(60 + (230 * i), 440);
                }
                else if (i < 2 && i > 0)
                {
                    label1[i].Location = new Point(75 + (230 * i), 440);
                }
                else if (i < 3 && i > 1)
                {
                    label1[i].Location = new Point(65 + (245 * i), 440);
                }
                else if (i > 2 && i < 5)
                {
                    label1[i].Location = new Point(65 + (250 * i), 440);
                }
                else if (i < 7 && i > 4)
                {
                    label1[i].Location = new Point(110 + (250 * i), 440);
                }
                else
                {
                    label1[i].Location = new Point(47 + (250 * i), 440);
                }

                panels1.Controls.Add(label1[i]);
                y += 2;
                pictureBox1[i].Click += pictureBox1_Click;
            }
            
        }

    }
}

        
