namespace FlappingBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveTree(10);
            moveHurdle(5);
        }
        Random r = new Random();

        void gameover()
        {
            if (bird.Bounds.IntersectsWith(h1.Bounds) || bird.Bounds.IntersectsWith(h2.Bounds) || bird.Bounds.IntersectsWith(h3.Bounds) || bird.Bounds.IntersectsWith(h4.Bounds))
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
        }

        void moveHurdle(int speed)
        {
            if (h1.Left > 0) h1.Left += -speed;
            else
            {
                h1.Left = 700;
                h1.Height = r.Next(100, 200);
            }
            if (h2.Left > 0) h2.Left += -speed;
            else
            {
                h2.Left = 700;
                h2.Height = r.Next(300, 400);
            }
            if (h3.Left > 0) h3.Left += -speed;
            else
            {
                h3.Left = 700;
                h3.Height = r.Next(100, 200);
            }
            if (h4.Left > 0) h4.Left += -speed;
            else
            {
                h4.Left = 700;
                h4.Height = r.Next(300, 400);
            }


        }

        void moveTree(int speed)
        {
            if (t1.Left > 0) t1.Left += -speed;
            else t1.Left = 700;

            if (t2.Left > 0) t2.Left += -speed;
            else t2.Left = 700;

            if (t3.Left > 0) t3.Left += -speed;
            else t3.Left = 700;

            gameover();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bird.Top += 1;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                bird.Top += -20;
        }
    }
}