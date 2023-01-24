using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class InvoiceTotal : Form
    {
        public InvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateTotal()
        {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = Convert.ToDecimal(txtDiscountPercent.Text);

            decimal discountAmount = subtotal * (discountPercent / 100);

            decimal total = subtotal - discountAmount;


            txtDiscountAmount.Text = Math.Round(discountAmount, 2).ToString();
            txtTotal.Text = Math.Round(total, 2).ToString();
        }
    }
}
