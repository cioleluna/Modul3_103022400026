namespace Modul3_103022400026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Celcius");
            comboBox1.Items.Add("Kelvin");
            comboBox1.Items.Add("Reamur");
            comboBox1.Items.Add("Farenheit");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu");
                return;
            }
            if (!double.TryParse(textBox1.Text, out double nilai))
            {
                MessageBox.Show("Masukkan angka yang valid");
                return;
            }
            string dari = comboBox1.SelectedItem.ToString().Trim();
            string ke = comboBox2.SelectedItem.ToString().Trim();
            double celcius = KeCelcius(nilai, dari);
            double hasil = DariCelcius(celcius, ke);
            textBox2.Text = hasil.ToString("F2");
        }

        private double KeCelcius(double nilai, string satuan)
        {
            switch (satuan)
            {
                case "Celcius":
                    return nilai;

                case "Farenhait":
                    return (nilai - 32) * 5 / 9;

                case "Reamur":
                    return nilai * 5 / 4;

                case "Kelvin":
                    return nilai - 273.15;

                default: return nilai;
            }
        }

        private double DariCelcius(double nilai, string satuan)
        {
            switch (satuan)
            {
                case "Celcius":
                    return nilai;

                case "Farenhait":
                    return (nilai * 9 / 5) + 32;

                case "Reamur":
                    return nilai * 4 / 5;

                case "Kelvin":
                    return nilai + 273.15;

                default: return nilai;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Celcius");
            comboBox2.Items.Add("Kelvin");
            comboBox2.Items.Add("Reamur");
            comboBox2.Items.Add("Farenheit");
        }
    }
}