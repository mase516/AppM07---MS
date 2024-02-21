namespace Calculadora
{
    public partial class Form1 : Form
    {
        public static string[,] array = new string[,]
        {
            {"=","E$","EY" },
            {"$E","=","$Y"},
            {"YE","Y$","="},
        };
        public Form1()
        {
            InitializeComponent();

            button1.Click += new EventHandler(teclat_CLick);
            button2.Click += new EventHandler(teclat_CLick);
            button3.Click += new EventHandler(teclat_CLick);
            button4.Click += new EventHandler(teclat_CLick);
            button5.Click += new EventHandler(teclat_CLick);
            button6.Click += new EventHandler(teclat_CLick);
            button7.Click += new EventHandler(teclat_CLick);
            button8.Click += new EventHandler(teclat_CLick);
            button9.Click += new EventHandler(teclat_CLick);
            button10.Click += new EventHandler(teclat_CLick);
            comboBox1.Items.Add("€");
            comboBox1.Items.Add("$");
            comboBox1.Items.Add("YEN");
            comboBox2.Items.Add("€");
            comboBox2.Items.Add("$");
            comboBox2.Items.Add("YEN");
        }

        private void teclat_CLick(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            textBox1.Text += number;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            {
                if (comboBox1.SelectedIndex >= 0)
                {
                    string selecteditem1 = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    if (comboBox2.SelectedIndex >= 0)
                    {
                        string selecteditem2 = comboBox2.Items[comboBox2.SelectedIndex].ToString();
                        double resultado = double.Parse(textBox1.Text);
                        switch (array[comboBox1.SelectedIndex, comboBox2.SelectedIndex])
                        {
                            case "=":
                                break;
                            case "E$":
                                resultado *= 1.13;
                                textBox1.Text = resultado.ToString("0.00");
                                break;
                            case "EY":
                                resultado = resultado * 162;
                                textBox1.Text = resultado.ToString("0.00");
                                break;
                            case "$E":
                                resultado *= 0.93;
                                textBox1.Text = resultado.ToString("0.00");
                                break;
                            case "$Y":
                                resultado *= 150;
                                textBox1.Text = resultado.ToString("0.00");
                                break;
                            case "YE":
                                resultado *= 0.0062;
                                textBox1.Text = resultado.ToString("0.00");
                                break;
                            case "Y$":
                                resultado *= 0.0067;
                                textBox1.Text = resultado.ToString("0.00");
                                break;
                        }
                    }
                }
            }
        }
    }
}
