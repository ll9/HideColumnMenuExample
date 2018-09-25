using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideColumnExample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ToShowButton_Click(object sender, EventArgs e)
        {
            ShowBox.Items.Add(HideBox.SelectedItem);
            HideBox.Items.Remove(HideBox.SelectedItem);
        }

        private void ToHideButton_Click(object sender, EventArgs e)
        {
            HideBox.Items.Add(ShowBox.SelectedItem);
            ShowBox.Items.Remove(ShowBox.SelectedItem);
        }
    }
}
