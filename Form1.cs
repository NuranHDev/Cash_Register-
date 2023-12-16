using Kassa_Aparati.Entity;

namespace Kassa_Aparati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Product p = new Product();
        decimal result = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Lays \n 2.Cola ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] code = { "1221", "2020", "2021", "2022" };
            string[] name = {"Lays","Coca-Cola","Rafaello","Snickers" };
            decimal[] price = {1.50m,2.20m,5.60m,2.50m };
            if (textBox1.Text == code[0])
            {
                object[] product = { p.Name = name[0], p.Price = price[0] };

                foreach (var item in product)
                {
                    listBox1.Items.Add(item);
                }
                result = result + p.Price;
            }
           else if (textBox1.Text == code[1])
            {
                object[] product1 = { p.Name = name[1], p.Price = price[1] };

                foreach (var item in product1)
                {
                    listBox1.Items.Add(item);
                }
                result = result + p.Price;

            }
            else if (textBox1.Text == code[2])
            {
                object[] product2 = { p.Name = name[2], p.Price = price[2] };
                foreach (var item in product2)
                {
                    listBox1.Items.Add(item);

                }
                result=result + p.Price;
            }
            else if (textBox1.Text == code[3])
            {
                object[] product3 = { p.Name = name[3], p.Price = price[3] };
                foreach (var item in product3)
                {
                    listBox1.Items.Add(item);

                }
                result = result + p.Price;
            }
            else
            {
                MessageBox.Show("Bu kod mövcud deyil");
            }
            label5.Text = $"{result.ToString()} azn";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal mebleg = Convert.ToDecimal(textBox2.Text);
            if (mebleg > result)
            {
                label6.ForeColor = Color.Black;
                label6.Text = $"{mebleg.ToString()} azn";
                decimal qaliq = mebleg - result;
                label7.Text = $"{qaliq.ToString()} azn";
            }
            else
            {
                label6.ForeColor=Color.Red;
                label6.Text = "0.00 AZN ";
                MessageBox.Show("Ödənilən məbləğ tutardan kiçikdir");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }
    }
}
