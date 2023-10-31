namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            MessageBox.Show(this, "Hey");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (button1.Visible == false) MessageBox.Show("This one is not visible");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Clicked";
            int viNumber = Convert.ToInt32(textBox1.Text) * 5;
            label1.Text = "Entered number multiplied by 5=" + viNumber.ToString();
        }

        private void button3_TextChanges(object sender, EventArgs e)
        {
            MessageBox.Show("An event has occured");
        }

        /*private void label1_Click(object sender, EventArgs e)
        {

        }*/
    }
}