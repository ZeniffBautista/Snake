using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            MainWindow jugar = new MainWindow();
            jugar.Show();
            this.Close();
            this.StartPosition = FormStartPosition.CenterParent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
