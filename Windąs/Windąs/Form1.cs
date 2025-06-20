namespace Windąs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		Logika gra = new Logika();
        private void gamePlay(int x,int y)
        {
			gra.Ustawienie(x,y);
            ustawGuziki();
			if (gra.CzyWygrana() == 3)
			{
				zapis_partii.Text += "O wygrał";
				stop();
				MessageBox.Show("O wygrał");

			}
			else if (gra.CzyWygrana() == 12)
			{
				zapis_partii.Text += "X wygrał";
				stop();
				MessageBox.Show("X wygrał");
			}
			else if (gra.CzyWygrana() == -1)
			{
				zapis_partii.Text += "remis";
				stop();
				MessageBox.Show("remis");
			}
		}
        private void ustawGuziki()
        {
            b1.Text = wstawZnak(0, 0);
			b2.Text = wstawZnak(0, 1);
			b3.Text = wstawZnak(0, 2);
			b4.Text = wstawZnak(1, 0);
			b5.Text = wstawZnak(1, 1);
			b6.Text = wstawZnak(1, 2);
			b7.Text = wstawZnak(2, 0);
			b8.Text = wstawZnak(2, 1);
			b9.Text = wstawZnak(2, 2);
			zapis_partii.Text = gra.GetHistory();
		}
        private string wstawZnak(int x,int y) {
            if (gra.plansza[x,y] == 0)
			{
				return "";
			}
            return gra.plansza[x,y] == 4 ? "X" : "O";

		}
        private void stop()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = false;
                }
            }
        }
		private void gameReset()
		{
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
					c.Enabled = true;
                }
            }
            gra.reset();
		}
		private void button1_Click(object sender, EventArgs e)
        {
            gamePlay(0,0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
			gamePlay(0, 1);
		}

        private void button3_Click(object sender, EventArgs e)
        {
			gamePlay(0, 2);
		}

        private void button4_Click(object sender, EventArgs e)
        {
			gamePlay(1, 0);
		}

        private void button5_Click(object sender, EventArgs e)
        {
			gamePlay(1, 1);
		}

        private void button6_Click(object sender, EventArgs e)
        {
			gamePlay(1, 2);
		}

        private void button7_Click(object sender, EventArgs e)
        {
			gamePlay(2, 0);
		}

        private void button8_Click(object sender, EventArgs e)
        {
			gamePlay(2, 1);
		}

        private void button9_Click(object sender, EventArgs e)
        {
			gamePlay(2, 2);
		}

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameReset();
            zapis_partii.Text = gra.GetHistory();
			ustawGuziki();
		}
    }
}
