namespace Activity3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.RosyBrown;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
            berryrbt.Checked = false;
            girlrbt.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C: \Users\User\Desktop\icecream\bundleimages\minion.png");

            m1.Checked = true;
            m2.Checked = true;
            m3.Checked = true;

            b1.Checked = false;
            b2.Checked = false;
            b3.Checked = false;
            b4.Checked = false;

            g1.Checked = false;
            g2.Checked = false;
            g3.Checked = false;

            pricetb.Text = "P315.00";
            discounttb.Text = "(10% of the Price) P35";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Lavender;
            minionrbt.Checked = false;
            girlrbt.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C: \Users\User\Desktop\icecream\Activity3\bundleimages\berry.png");

            m1.Checked = false;
            m2.Checked = false;
            m3.Checked = false;

            b1.Checked = true;
            b2.Checked = true;
            b3.Checked = true;
            b4.Checked = true;

            g1.Checked = false;
            g2.Checked = false;
            g3.Checked = false;

            pricetb.Text = "P395.00";
            discounttb.Text = "(15% of the Price) P70";
        }

        private void girl_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.MistyRose;
            berryrbt.Checked = false;
            minionrbt.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C: \Users\User\Desktop\icecream\Activity3\bundleimages\girl.png");

            m1.Checked = false;
            m2.Checked = false;
            m3.Checked = false;

            b1.Checked = false;
            b2.Checked = false;
            b3.Checked = false;
            b4.Checked = false;

            g1.Checked = true;
            g2.Checked = true;
            g3.Checked = true;

            pricetb.Text = "P297.00";
            discounttb.Text = "(10% of the Price) P33";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            berryrbt.Checked = false;
            minionrbt.Checked = false;
            girlrbt.Checked = false;
            DisplayPictureBox.Image = Image.FromFile("C: \Users\User\Desktop\icecream\Activity3\bundleimages\white.png");

            b1.Checked = false;
            b2.Checked = false;
            b3.Checked = false;
            b4.Checked = false;

            g1.Checked = false;
            g2.Checked = false;
            g3.Checked = false;

            m1.Checked = true;
            m2.Checked = true;
            m3.Checked = true;

            pricetb.Clear();
            discounttb.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DisplayPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
