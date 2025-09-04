using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox15.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox25.Enabled = false;
            textBox26.Enabled = false;
            textBox27.Enabled = false;
            listView1.Columns.Add("#", 50);
            listView1.Columns.Add("Course Code", 110);
            listView1.Columns.Add("Course Desc.", 200);
            listView1.Columns.Add("Unit Lec", 110);
            listView1.Columns.Add("Unit Lab", 100);
            listView1.Columns.Add("Time", 110);
            listView1.Columns.Add("Day", 110);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newitem = new ListViewItem(textBox1.Text);
            newitem.SubItems.Add(textBox2.Text);
            newitem.SubItems.Add(textBox3.Text);
            newitem.SubItems.Add(textBox4.Text);
            newitem.SubItems.Add(textBox5.Text);
            newitem.SubItems.Add(textBox6.Text);
            newitem.SubItems.Add(textBox7.Text);
            newitem.SubItems.Add(textBox8.Text);
            listView1.Items.Add(newitem);

            double ulec, ulab, total_credit, lab1, tuition, misc, cisco, exam, other, total;
            ulec = Convert.ToDouble(textBox4.Text);
            ulab = Convert.ToDouble(textBox5.Text);
            total_credit = ulec + ulab;

            textBox12.Text = total_credit.ToString("n");
            textBox13.Text = total_credit.ToString("n");

            tuition = 1500 * total_credit;
            lab1 = Convert.ToDouble(textBox14.Text);
            misc = Convert.ToDouble(textBox16.Text);
            cisco = Convert.ToDouble(textBox17.Text);
            exam = Convert.ToDouble(textBox18.Text);
            total = lab1 + misc + cisco + exam + tuition;
            other = lab1 + cisco + exam;

            textBox15.Text = tuition.ToString("n");
            textBox19.Text = total.ToString("n");


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                textBox1.Text = open.FileName;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double ulec, ulab, total_credit, lab1, tuition, misc, cisco, exam, other, total;
            ulec = Convert.ToDouble(textBox4.Text);
            ulab = Convert.ToDouble(textBox5.Text);
            total_credit = ulec + ulab;

            textBox12.Text = total_credit.ToString("n");
            textBox13.Text = total_credit.ToString("n");
            textBox26.Text = total_credit.ToString("n");

            tuition = 1500 * total_credit;
            lab1 = Convert.ToDouble(textBox14.Text);
            misc = Convert.ToDouble(textBox16.Text);
            cisco = Convert.ToDouble(textBox17.Text);
            exam = Convert.ToDouble(textBox18.Text);
            total = lab1 + misc + cisco + exam + tuition;
            other = lab1 + cisco + exam;

            textBox15.Text = tuition.ToString("n");
            textBox19.Text = total.ToString("n");
            textBox20.Text = tuition.ToString("n");
            textBox27.Text = total.ToString("n");
            textBox21.Text = misc.ToString("n");
            textBox22.Text = lab1.ToString("n");
            textBox23.Text = cisco.ToString("n");
            textBox24.Text = exam.ToString("n");
            textBox25.Text = other.ToString("n");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear(); 
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            listView1.Clear();
        }
    }
}
