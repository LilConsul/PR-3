using System;
using System.Windows.Forms;

namespace PR_3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void task1_ToolStripMenuItem_Click(object sender, EventArgs e) {
            Task1_panel.Height += 1;
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e) {
            Task2_panel.Height += 1;
        }
    }
}