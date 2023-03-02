using System;
using System.Windows.Forms;

// CODED BY KATHLEEN FORGIARINI DA SILVA
// 2023-03-02
// MIDTERM EXAM - SECTION 3

// I started the project doing the design as requested, then I created a function to set default values and properties to the textboxes, because I know I will use it more than once.
// After that, I created a class file in the solution folder, with the same class as the console project.
// For each button click function, I created an object, to instantiate the class. I used the public property to save the value entered by the user, and I used the public
// methods to calculate the conversion. With this calculate, I converted to string to put in the textbox results.

namespace MidTermSection3
{
    public partial class frm_ConvertLength : Form
    {
        public frm_ConvertLength()
        {
            InitializeComponent();
        }

        public void defaultValuesProperties()
        {
            txtBox1.Text = "0";
            txtBox2.Text = "0";
            txtBox3.Text = "0";
            txtBox4.Text = "0";
            txtBox5.Text = "0";
            txtBox6.Text = "0";
            txtBox1.ReadOnly = false;
            txtBox2.ReadOnly = true;
            txtBox3.ReadOnly = true;
            txtBox4.ReadOnly = false;
            txtBox5.ReadOnly = true;
            txtBox6.ReadOnly = true;
        }

        private void frm_ConvertLength_Load(object sender, EventArgs e)
        {
            defaultValuesProperties();
        }

        private void btnMYd_Click(object sender, EventArgs e)
        {
            ConvertLength cl1 = new ConvertLength();
            try
            {
                cl1.Length = Convert.ToDouble(txtBox1.Text);
                txtBox2.Text = cl1.mToCm().ToString();
                txtBox3.Text = cl1.mToYd().ToString();
                txtBox1.ReadOnly = true;
                txtBox4.ReadOnly = false;
                txtBox4.Focus();
            }
            catch
            {
                MessageBox.Show("Input string was not in a correct format");
                txtBox1.Focus();
            }
        }

        private void btnKmMile_Click(object sender, EventArgs e)
        {
            ConvertLength cl2 = new ConvertLength();
            try
            {
                cl2.Length = Convert.ToDouble(txtBox4.Text);
                txtBox5.Text = cl2.kmToM().ToString();
                txtBox6.Text = cl2.kmToMile().ToString();
                txtBox4.ReadOnly = true;
                txtBox1.ReadOnly = false;
                txtBox1.Focus();
            }
            catch
            {
                MessageBox.Show("Input string was not in a correct format");
                txtBox4.Focus();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            defaultValuesProperties();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the app.?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
            else
            {
                defaultValuesProperties();
            }
        }
    }
}
