using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Pizza_Order : Form
    {
        public Pizza_Order()
        {
            InitializeComponent();
            ToppingSelect.Size = new Size(170, 60);
        }
        float GetSelectedSizePrice()
        {
            if (RdSmallSize.Checked)
                return Convert.ToSingle(RdSmallSize.Tag);
            else if(RdMediumSize.Checked)
                return Convert.ToSingle(RdMediumSize.Tag);
            else
                return Convert.ToSingle(RdLargeSize.Tag);
        }
        float CalculateToppingsPrice() {
            float ToppingPrice = 0;
        if(chkBoxExtraCheese.Checked)
                ToppingPrice+= Convert.ToSingle(chkBoxExtraCheese.Tag);
            if (chkBoxMushrooms.Checked)
                ToppingPrice += Convert.ToSingle(chkBoxMushrooms.Tag);
            if (chkBoxTomatoes.Checked)
                ToppingPrice += Convert.ToSingle(chkBoxTomatoes.Tag);
            if (chkBoxOnion.Checked)
                ToppingPrice += Convert.ToSingle(chkBoxOnion.Tag);
            if (chkBoxOlives.Checked)
                ToppingPrice += Convert.ToSingle(chkBoxOlives.Tag);
            if (chkBoxGreenPeppers.Checked)
                ToppingPrice += Convert.ToSingle(chkBoxGreenPeppers.Tag);
            return ToppingPrice;
        }
        float GetCrustPrice()
        {
            if (RdThinCrust.Checked)
                return Convert.ToSingle(RdThinCrust.Tag);

            if (RdThickCrust.Checked)
                return Convert.ToSingle(RdThickCrust.Tag);
            return 0;
        }
        float CalculatePrice() {
            return GetSelectedSizePrice()+ CalculateToppingsPrice()+GetCrustPrice();
        }

        void UpdateTotalPrice()
        {
            LblPrice.Text = "$" + CalculatePrice().ToString();
        }
        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (RdThinCrust.Checked)
            {
                label10.Text = "Thin Crust";
                return;
            }

            if (RdThickCrust.Checked)
            {
                label10.Text = "Thick Crust";
                return;
            }


        }
        private void RdBtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdSmallSize.Checked)
            {
                UpdateTotalPrice();
                SizeRadioLabel.Text = RdSmallSize.Text;
            }
        }

        private void RdBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (RdMediumSize.Checked)
            {
                UpdateTotalPrice();
                SizeRadioLabel.Text = RdMediumSize.Text;
            }
        }

        private void RdBtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (RdLargeSize.Checked)
            {
                UpdateTotalPrice();
                SizeRadioLabel.Text = RdLargeSize.Text;
            }
        }

        private void RdBtn1Grp3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void RdBtn2Grp3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void RdBtn1Grp4_CheckedChanged(object sender, EventArgs e)
        {
            if (RdEatIn.Checked) {
                UpdateTotalPrice();
                label11.Text = RdEatIn.Text;
            }
        }

        private void RdBtn2Grp4_CheckedChanged(object sender, EventArgs e)
        {
            if (RdTakeOut.Checked)
            {
                UpdateTotalPrice();
                label11.Text = RdTakeOut.Text;
            }
        }
        void UpdateToppings() {
            UpdateTotalPrice();
            string sToppings = "";
            if (chkBoxExtraCheese.Checked) {
                sToppings += "Extra Cheese";
            }
            if (chkBoxGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }
            if (chkBoxMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }
            if (chkBoxOlives.Checked)
            {
                sToppings += ", Olives";
            }
            if (chkBoxOnion.Checked)
            {
                sToppings += ", Onion";
            }
            if (chkBoxTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }
            if (sToppings.StartsWith(",")) {
                sToppings = sToppings.Substring(1, sToppings.Length - 1);
            }
            if (sToppings == "")
                sToppings = "No Toppings";

            ToppingSelect.Text = sToppings;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpBox1.Enabled = false;
                GrpBox2.Enabled = false;
                GrpBox3.Enabled = false;
                GrpBox4.Enabled = false;

            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?","Reset Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                grpBox1.Enabled = true;
                GrpBox2.Enabled = true;
                GrpBox3.Enabled = true;
                GrpBox4.Enabled = true;

            }
        }

        private void chkBoxExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkBoxGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
    }
}
