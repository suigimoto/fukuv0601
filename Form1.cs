namespace fukuv0601
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        string chr = "( ・ - ・ )";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = 10;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left = label1.Left + vx;
            label1.Top = label1.Top + vy;
            string t = label1.Text;
            label1.Text = chr;
            chr = t;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "杉本　尚輝";



        }
    }
}