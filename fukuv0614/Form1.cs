namespace fukuv0614
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        int ans = random.Next(51);
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            MessageBox.Show($"{count}‰ñ–Ú‚Ì’§í");
            int yosou;
            yosou = int.Parse(textBox1.Text);

            if (yosou == ans)
            {
                MessageBox.Show("Bingo!!");
                label1.Text = $"{ans}";
                label1.BackColor = Color.Red;
                ans = random.Next(51);
            }
            else if (yosou > ans)
            {
                MessageBox.Show("less");
            }
            else
            {
                MessageBox.Show("Greater");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}