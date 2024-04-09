using Lopush.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lopush.Forms;


namespace Lopush.UserControls
{
    public partial class UserControl1 : UserControl
    {
        private Product _product;
        public UserControl1(Product product)
        {
            InitializeComponent();
            Fill(product);
        }

        private void Fill(Product product)
        {
            _product = product;
            iDLabel3.Text = product.ID.ToString();
            titleLabel3.Text = product.Title.ToString();
            minCostForAgentLabel3.Text = product.MinCostForAgent.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(product.Image);

            }
            catch 
            {
                pictureBox1.Image = Properties.Resources.Лопушок;
            }

        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_product);
            form2.ShowDialog();
        }
    }
}
