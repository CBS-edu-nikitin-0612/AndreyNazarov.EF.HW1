using System;
using System.Linq;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(ContextContainer container = new ContextContainer())
            {
                this.dataGridViewMain.DataSource = container.BuildingSet.ToList();
            }
        }
    }
}
