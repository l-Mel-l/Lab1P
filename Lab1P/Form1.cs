namespace Lab1P {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Абоненты");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поддержка пользователей");
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CRM");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Управление оборудованием");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Активы");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Биллинг");
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string buttonText = "Собрание менеджеров";

            Form2 form2 = new Form2(buttonText);
            form2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string buttonText = "Отчёт по инвентаризации";

            Form2 form2 = new Form2(buttonText);
            form2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string buttonText = "Собрание акционеров";

            Form2 form2 = new Form2(buttonText);
            form2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string buttonText = "Отчёт по адмиралтейскому району";

            Form2 form2 = new Form2(buttonText);
            form2.Show();
        }
    }
}
