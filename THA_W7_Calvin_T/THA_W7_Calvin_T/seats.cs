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
        List<string> selectedSeats = new List<string>();
        public static seats seat;
        Label kursi = new Label();
        Button[,] buttons = new Button[10, 10];
        Button submit = new Button();
        Button reset = new Button();
        string[] huruf = new string[10] {"A","B","C","D","E","F","G","H","I","J"};
        Random random = new Random();
        int x = 0;
        int y = 0;
        int counter = 0;
        int jumlahkursi;
        public seats()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j =0; j < 10; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(50, 50);
                    buttons[i, j].ForeColor = Color.White;
                    buttons[i, j].Location = new Point(i * 60 + 50, j * 60 + 50);
                    buttons[i, j].BackColor = Color.LimeGreen;
                    buttons[i,j].Text = huruf[j] + (i+1).ToString(); 
                    this.Controls.Add(buttons[i, j]);
                    buttons[i, j].Click += Buttons_Click;
                }
            }
            for(int i = 0; i < 100; i++)
            {
                if (counter <= movieslist.a-1)
                {
                    x = random.Next(0, 10);
                    y = random.Next(0, 10);
                    buttons[x, y].BackColor = Color.Red;
                    counter++;
                    buttons[x, y].Enabled = false;
                }
                else
                {
                    break;
                }
            }
            kursi.Location = new Point(770, 100);
            kursi.MaximumSize = new Size(400, 0);
            kursi.Font = new Font("Montserrat",12,FontStyle.Regular);
            kursi.AutoSize = true;
            kursi.Text = "Selected seat(s): ";
            this.Controls.Add(kursi);
            reset.Location = new Point(770, 150);
            reset.Size = new Size(150, 60);
            reset.Text = "Reset";
            this.Controls.Add(reset);
            submit.Location = new Point(950, 150);
            submit.Size = new Size(150, 60);
            submit.Text = "Submit";
            this.Controls.Add(submit);
            submit.Click += Submit_Click;
            reset.Click += Reset_Click;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j =0; j < 10; j++)
                {
                    buttons[i, j].BackColor = Color.LimeGreen;
                    buttons[i, j].Enabled = true;
                }
            }
            kursi.Text = "Selected seat(s): ";
            jumlahkursi = 0;
            selectedSeats.Clear();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (jumlahkursi == 0)
            {
                MessageBox.Show("Choose minimal 1 seat");
            }
            else
            {

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (buttons[i, j].BackColor == Color.Red)
                        {
                            buttons[i, j].Enabled = false;
                        }
                    }
                }
                kursi.Text = "Selected seat(s): ";
                jumlahkursi = 0;
                selectedSeats.Clear();
                movieslist.pilih[movieslist.select,movieslist.hours] += jumlahkursi;

                //movieslist.listmovie = new movieslist();
                this.Controls.Clear();
                movies = new movieslist();
                movies.TopLevel = false;
                movies.Dock = DockStyle.Fill;
                this.Controls.Add(movies);
                movies.Show();

                //this.ParentForm.Show();
                //this.IsMdiChild = true;
                //main_form = new Form1();
                //main_form.TopLevel = false;
                //main_form.Dock = DockStyle.Fill;
                //this.Controls.Add(main_form);


                //movieslist.panels1.Show();
            }
            
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
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
            var send = sender as Button;

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
            foreach (string a in selectedSeats)
            {
                kursi.Text += a + " ";
            }

        }
    }
}
