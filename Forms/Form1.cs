using Lopush.DataModel;
using Lopush.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopush.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            products = Model1.Product.ToList();
        }
        private Model1 Model1 = new Model1();
        private List<Product> products = new List<Product>();
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            FillPanel();
        }

        private void FillPanel()
        {
            flowLayoutPanel2.Controls.Clear();
            foreach (Product prod in products)
            {
                UserControl1 userControl1 = new UserControl1(prod);
                flowLayoutPanel2.Controls.Add(userControl1);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "ID")
            {
               products = products.OrderBy(x => x.ID).ToList();
            }
            if (comboBox1.SelectedItem.ToString() == "Title")
            {
                products = products.OrderBy(x => x.Title).ToList();
            }
            if (comboBox1.SelectedItem.ToString() == "MinCostForAgent")
            {
                products = products.OrderBy(x => x.MinCostForAgent).ToList();
            }

            FillPanel();

        }
    }
}
