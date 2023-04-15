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
    public partial class First : Form
    {
        public static First bases;
        public static movieslist movieslist;
        public First()
        {
            InitializeComponent();
            bases = this;
        }

        private void Base_Load(object sender, EventArgs e)
        {
            movieslist = new movieslist();
            movieslist.TopLevel = false;
            movieslist.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(movieslist);
            movieslist.Show();
        }
    }
}
