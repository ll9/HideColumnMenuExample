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
    public partial class Form1 : Form
    {
        public BindingList<Person> People { get; set; } = new BindingList<Person>();
        public Form1()
        {
            InitializeComponent();

            People.Add(new Person(1, "Hans", "Prien"));
            People.Add(new Person(2, "Jens", "Bernau"));
            People.Add(new Person(3, "Susane", "Amerang"));

            peopleDataGridView.DataSource = People;
        }

        private void DemoButton_Click(object sender, EventArgs e)
        {
            People.Add(new Person(3, "Susane", "Amerang"));
            new Form2().ShowDialog();
        }
    }
}
