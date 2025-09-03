namespace POS_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        pictureBox9:
            itemnameTxtbox.Text = "Strawberry Cheesecake";
            priceTxtbox.Text = "110";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Oreo Oreo";
            priceTxtbox.Text = "100";

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Clear();
            priceTxtbox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Cookie Monster";
            priceTxtbox.Text = "115";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Reese's and Bananas";
            priceTxtbox.Text = "120";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Hella Chocolate";
            priceTxtbox.Text = "100";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Matcha Berry";
            priceTxtbox.Text = "110";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Rasberry Berry";
            priceTxtbox.Text = "120";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Taro Berry";
            priceTxtbox.Text = "110";

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Caramel Caramel";
            priceTxtbox.Text = "105";


        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "S'mores and Bears";
            priceTxtbox.Text = "110";
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Mangonada";
            priceTxtbox.Text = "120";
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Blended Berry";
            priceTxtbox.Text = "125";
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Pina Colada";
            priceTxtbox.Text = "110";
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Strawberry Smashed";
            priceTxtbox.Text = "120";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = "Birthday Cake";
            priceTxtbox.Text = "120";
        }
    }
}
