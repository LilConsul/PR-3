using System;
using System.Windows.Forms;

namespace PR_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Task1_panel.Show();
            Task2_panel.Hide();
        }

        private void task1_ToolStripMenuItem_Click(object sender, EventArgs e) {
            Task1_panel.Show();
            Task2_panel.Hide();
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e) {
            Task1_panel.Hide();
            Task2_panel.Show();
        }
    }
}