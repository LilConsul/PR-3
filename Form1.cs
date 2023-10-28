using System;
using System.Globalization;
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

        private void calc1_Click(object sender, EventArgs e) {
            try {
                var a = Convert.ToInt32(a_box1.Text);
                var b = Convert.ToInt32(b_box1.Text);
                var c = Convert.ToInt32(c_box1.Text);

                var num = new Nums(a, b, c);
                ans1.Text = Math.Round(num.DoTask(), 3).ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calc2_Click(object sender, EventArgs e) {
            try {
                var a = Convert.ToInt32(a_box2.Text);
                var b = Convert.ToInt32(b_box2.Text);

                var arr = new MyArray(a, b);
                ans2.Text = arr.DoTask().ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}