using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace horas_trabajadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            double horastrabajadas = double.Parse(txthorastrabajadas.Text);
            double valorhora = double.Parse(txtvalorhora.Text);
            double total = horastrabajadas * valorhora;
            double desc=valorhora*0.5;
            if (total <= 700000) {
                total = total * 0.10+total;
                lbltotalsalario.Text = "$" + Convert.ToDecimal(total).ToString("N0");
                lbltotalsalario.Visible = true;

                MessageBox.Show("tienes un aumento del 10%");
            }
            else
            {
                if (total <= 1000000)
                {
                    total = (total-desc)-0.3;
                    lbltotalsalario.Text = "$" + Convert.ToDecimal(total).ToString("N0");
                    lbltotalsalario.Visible = true;
                    MessageBox.Show("tienes un descueto del 2%");
                }
            }
            if (total >= 1000001) {

                total = (total - desc)+0.2;
                lbltotalsalario.Text = "$" + Convert.ToDecimal(total).ToString("N0");
                lbltotalsalario.Visible = true;
                MessageBox.Show("tienes un descueto del 5% y un incremento del 2%");
            }
           






        }
    }
}
