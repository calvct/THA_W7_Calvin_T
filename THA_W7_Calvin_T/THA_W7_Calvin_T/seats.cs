using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_Calvin_T
{
    public partial class seats : Form
    {
        
        movieslist movies;
        Label judul;
        List<string> selectedSeats = new List<string>();
        public static seats seat;
        static Label kursi = new Label();
        Button[,] buttons = new Button[10, 10];
        Button submit = new Button();
        Button reset = new Button();
        Button back = new Button();
        string[] huruf = new string[10] {"A","B","C","D","E","F","G","H","I","J"};
        Random random = new Random();
        int x = 0;
        int y = 0;
        int counter = 0;
        static int jumlahkursi = 0;
        public seats()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (movieslist.memilih[movieslist.select, movieslist.hours] == null)
            {
                movieslist.memilih[movieslist.select, movieslist.hours] = new List<Button>();
                while(counter != movieslist.pilih[movieslist.select, movieslist.hours])
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            x = random.Next(2);
                            buttons[i, j] = new Button();
                            buttons[i, j].Size = new Size(50, 50);
                            buttons[i, j].ForeColor = Color.White;
                            buttons[i, j].Location = new Point(i * 60 + 50, j * 60 + 50);
                            buttons[i, j].Text = huruf[j] + (i + 1).ToString();
                            if (x == 0 && counter < movieslist.pilih[movieslist.select, movieslist.hours])
                            {
                                buttons[i, j].BackColor = Color.Red;
                                counter++;
                            }
                            else
                            {
                                buttons[i, j].BackColor = Color.LimeGreen;
                            }
                            if (buttons[i, j].BackColor == Color.Red)
                            {
                                buttons[i, j].Enabled = false;
                            }
                            buttons[i, j].Click += new EventHandler(Buttons_Click);
                            movieslist.memilih[movieslist.select, movieslist.hours].Add(buttons[i, j]);

                        }
                    }
                }
                foreach (Button seat in movieslist.memilih[movieslist.select, movieslist.hours])
                {
                    this.Controls.Add(seat);
                }
            }
            else
            {
                foreach (Button seat in movieslist.memilih[movieslist.select, movieslist.hours])
                {
                    this.Controls.Add(seat);
                }

            }
            selectedSeats.Clear();
            judul = new Label();
            judul.Text = "Selected Film: " + movieslist.label1[movieslist.select].Text + "\nAt " + movieslist.jam;
            judul.AutoSize = true;
            judul.Location = new Point(770, 40);
            judul.Font = new Font("Montserrat", 14, FontStyle.Bold);
            this.Controls.Add(judul);
            kursi = new Label();
            kursi.Location = new Point(770, 100);
            kursi.MaximumSize = new Size(400, 0);
            kursi.Font = new Font("Montserrat", 12, FontStyle.Regular);
            kursi.AutoSize = true;
            kursi.Text = "Selected seat(s): ";
            this.Controls.Add(kursi);
            reset = new Button();
            reset.Location = new Point(770, 150);
            reset.Size = new Size(150, 60);
            reset.Text = "Reset";
            this.Controls.Add(reset);
            submit = new Button();
            submit.Location = new Point(950, 150);
            submit.Size = new Size(150, 60);
            submit.Text = "Submit";
            this.Controls.Add(submit);
            back = new Button();
            back.Location = new Point(770, 230);
            back.Size = new Size(150, 60);
            back.Text = "Back";
            this.Controls.Add(back);
            submit.Click += new EventHandler(Submit_Click);
            reset.Click += new EventHandler(Reset_Click);
            back.Click += new EventHandler(Back_Click);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            movies = new movieslist();
            movies.TopLevel = false;
            movies.Dock = DockStyle.Fill;
            this.Controls.Add(movies);
            movies.Show();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            foreach(Button button in movieslist.memilih[movieslist.select, movieslist.hours])
            {
                button.BackColor = Color.LimeGreen;
                button.Enabled = true;
            }
            kursi.Text = "Selected seat(s): ";
            movieslist.pilih[movieslist.select, movieslist.hours] = 101;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (jumlahkursi == 0)
            {
                MessageBox.Show("Choose minimal 1 seat");
            }
            else
            {

                foreach(Button button in movieslist.memilih[movieslist.select, movieslist.hours])
                {
                    if(button.BackColor == Color.Red)
                    {
                        button.Enabled = false;
                    }
                }
                if(movieslist.pilih[movieslist.select, movieslist.hours] == 101)
                {
                    movieslist.pilih[movieslist.select, movieslist.hours] = 0;
                    movieslist.pilih[movieslist.select, movieslist.hours] += jumlahkursi;
                }
                else
                {
                    movieslist.pilih[movieslist.select, movieslist.hours] += jumlahkursi;
                }
                
                jumlahkursi = 0;
                selectedSeats.Clear();
                this.Controls.Clear();
                movies = new movieslist();
                movies.TopLevel = false;
                movies.Dock = DockStyle.Fill;
                this.Controls.Add(movies);
                movies.Show();
            }
            
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            x = 0;
            y = 0;
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (sender == buttons[i, j])
                    {
                        x = i;
                        y = j;

                    }
                }

            }
            kursi.Text = "Selected seat(s): ";

            if (buttons[x,y].BackColor == Color.LimeGreen)
            {
                buttons[x,y].BackColor = Color.Red;
                selectedSeats.Add(send.Text);
                jumlahkursi++;
            }
            else if(buttons[x,y].BackColor == Color.Red)
            {
                buttons[x, y].BackColor = Color.LimeGreen;
                jumlahkursi--;
                if (selectedSeats.Contains(send.Text))
                {
                    selectedSeats.Remove(send.Text);
                }

            }
            updatelabel();

        }
        public void updatelabel()
        {
            foreach (string a in selectedSeats)
            {
                kursi.Text += a + " ";
            }
        }
    }
}
