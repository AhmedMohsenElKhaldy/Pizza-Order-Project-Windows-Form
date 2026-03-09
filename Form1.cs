using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProjectBt
{
    
    public partial class Form1 : Form
    {
        
        
         float CalculateGetSelectedSizePrice()
        {
            if (rbLarge.Checked)
            
                return Convert.ToSingle(rbLarge.Tag);
            
            else if (rbMedium.Checked)

                return Convert.ToSingle(rbMedium.Tag);

            else
                return Convert.ToSingle(rbLarge.Tag);


        }
        float CalculateGetToppingsPrice()
        {
            float Price = 0;

            if (chkBoxTom1.Checked)
                 Price += Convert.ToSingle(chkBoxTom1.Tag);

             if (chkBoxMash2.Checked)
                Price += Convert.ToSingle(chkBoxMash2.Tag);

             if (chkBoxGrePaper3.Checked)
                Price += Convert.ToSingle(chkBoxGrePaper3.Tag);

             if (chkBoxOni4.Checked)
                Price += Convert.ToSingle(chkBoxOni4.Tag);

             if (chkBoxOives5.Checked)
                Price += Convert.ToSingle(chkBoxOives5.Tag);

             if (chkBoxExtraChe6.Checked)
                Price += Convert.ToSingle(chkBoxExtraChe6.Tag);


            return Price;
        }

        float CalculateCrustType()
        {
            float crustType = 0;
            
            if (rbtnThic.Checked)
            {
                crustType = Convert.ToSingle(rbtnThic.Tag);
                return crustType;
            }
            else
              return crustType += Convert.ToSingle(rbtnThin.Tag);
            
        }

            
        float CalculateTotalPrice()
        {
            return  CalculateGetSelectedSizePrice() + CalculateGetToppingsPrice()
                + CalculateCrustType();

        }

        void UpdateTotalPrice()
        {
            label7TotalPrice.Text = "$" + Convert.ToString(CalculateTotalPrice());
        }
        string UpdateToppings() 
        {
            UpdateTotalPrice();

            string Toppings = ",";

            if (chkBoxTom1.Checked)
                Toppings = "Tommates, ";

            if (chkBoxMash2.Checked)
                Toppings += "Mashrrom, ";
            
            if (chkBoxGrePaper3.Checked)
                Toppings += "Green Paper, ";
            
            if (chkBoxOni4.Checked)
                Toppings += "Onion, ";
            
            if (chkBoxOives5.Checked)
                Toppings += "Olivies, ";
            
            if (chkBoxExtraChe6.Checked)
                Toppings += "Extra Chess, ";

            if (Toppings.StartsWith(","))
            Toppings = Toppings.Substring(0, Toppings.Length - 1).Trim();

            if (Toppings == "")
                Toppings = "No Toppings";
            
            return Toppings;
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbLarge.Checked)
            {
                label3Size.Text = "Large";
                return;
            }
            if (rbMedium.Checked)
            {
                label3Size.Text = "Medium";
                return;
            }
            if (rbSmall.Checked)

            { 
              label3Size.Text = "Small";
                return;
            }
        }
        string UpdateCrustType()
        {
            UpdateTotalPrice();

            if (rbtnThic.Checked)
            {
                return label3CrustType.Text = "Thic";
            }
            else
            {
              return label3CrustType.Text = "Thin";

            }
        }
        void WhereYouEat()
        {
            if (rbtnInSide.Checked)
                label3wheretoeat.Text = "In Side";
            else
                label3wheretoeat.Text = "Take Out";
        }
        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void chkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lab3Toppings.Text = UpdateToppings();

        }

        private void label4Toppings_Click(object sender, EventArgs e)
        {

        }

        private void chkBox3_CheckedChanged(object sender, EventArgs e)
        {
            lab3Toppings.Text = UpdateToppings(); 

        }

        private void chkBox5_CheckedChanged(object sender, EventArgs e)
        {
            lab3Toppings.Text = UpdateToppings();
        }

        private void chkBox6_CheckedChanged(object sender, EventArgs e)
        {
            lab3Toppings.Text = UpdateToppings();
        }

        private void label3Size_Click(object sender, EventArgs e)
        {
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1Size_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_3(object sender, EventArgs e)
        {
            WhereYouEat();

        }

        private void label3wheretoeat_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            WhereYouEat();

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            UpdateSize();
            WhereYouEat();
            UpdateCrustType();
            UpdateToppings(); 
        
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void GroubSizeBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        { lab3Toppings.Text = UpdateToppings();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void chkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lab3Toppings.Text = UpdateToppings();

        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Is Placed Successfuly", "Confirm", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

                GroubSizeBox1.Enabled = false;
                grbToppingsBox2.Enabled = false;
                groupBoxCrustType3.Enabled = false;
                grbwhereYoueatBox4.Enabled = false;



            }
            else
            {
                MessageBox.Show("Update The Order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label7TotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset Screen", "Reset" , MessageBoxButtons.OKCancel, 
              MessageBoxIcon.Exclamation) == DialogResult.OK)

            {
                // reset Size Groub
                GroubSizeBox1.Enabled = true;
                rbLarge.Checked = true;

                // reset Toppings
                grbToppingsBox2.Enabled = true;
                chkBoxTom1.Checked = true;
                chkBoxMash2.Checked = true;
                // reset Crust Type

                groupBoxCrustType3.Enabled = true;
                rbtnThic.Enabled = true;

                // reset Where You Eat

                grbwhereYoueatBox4.Enabled = true;
                rbtnInSide.Enabled = true;


            }
                
                }
    }
}
