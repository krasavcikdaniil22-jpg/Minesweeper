using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class FormMenu : Form
    {
        private void StartGame(int rows, int columns, int minesCount)
        {
            FormMain game = new FormMain(rows, columns, minesCount);
            game.Show();
            this.Hide();
        }
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            StartGame(9, 9, 10);
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            StartGame(12, 12, 25);
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            StartGame(16, 16, 40);
        }

        private void btnExtreme_Click(object sender, EventArgs e)
        {
            StartGame(20, 20, 80);
        }
    }
}
