using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH02_0706022310037
{
    public partial class Form2 : Form
    {
        char[] word = new char[5];
        bool[] check = new bool[5];
        public Form2(string[] Input)
        {
            InitializeComponent();
            Form1 hello = new Form1();
            hello.Hide();
            Random rnd = new Random();
            int rand = rnd.Next(0, 5);
            string[] blank = new string[5];
            blank[0] = letter1.Text.ToLower();
            blank[1] = letter2.Text.ToLower();
            blank[2] = letter3.Text.ToLower();
            blank[3] = letter4.Text.ToLower();
            blank[4] = letter5.Text.ToLower();

            Input[0] = Input[rand];
            Hint.Text = Input[0];


            int counter = 0;
            foreach (char c in Input[0])
            {
                word[counter] = c;
                counter++;
            }
        }

        private void Typing(object sender, EventArgs e)
        {

        }
        private void checking()
        {
            int counter = 0;
            for (int i = 0; i < 5; i++)
            {
                if (check[i] == true)
                {
                    counter++;
                }
            }
            if (counter == 5)
            {
                MessageBox.Show("Congrats, You winnnn");
            }
        }
        private void btnQ_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('Q' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "Q";
                }
                count++;
            }
            checking();
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('W' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "W";
                }
                count++;
            }
            checking();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('E' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "E";
                }
                count++;
            }
            checking();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('R' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "R";
                }
                count++;
            }
            checking();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('T' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "T";
                }
                count++;
            }
            checking();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('U' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "U";
                }
                count++;
            }
            checking();
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('Y' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "Y";
                }
                count++;
            }
            checking();
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('T' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "T";
                }
                count++;
            }
            checking();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('O' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "O";
                }
                count++;
            }
            checking();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('P' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "P";
                }
                count++;
            }
            checking();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('A' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "A";
                }
                count++;
            }
            checking();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('S' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "S";
                }
                count++;
            }
            checking();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('D' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "D";
                }
                count++;
            }
            checking();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('F' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "F";
                }
                count++;
            }
            checking();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('G' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "G";
                }
                count++;
            }
            checking();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('H' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "H";
                }
                count++;
            }
            checking();
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('J' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "J";
                }
                count++;
            }
            checking();
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('K' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "K";
                }
                count++;
            }
            checking();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('L' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "L";
                }
                count++;
            }
            checking();
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('Z' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "Z";
                }
                count++;
            }
            checking();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('X' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "X";
                }
                count++;
            }
            checking();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('C' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "C";
                }
                count++;
            }
            checking();
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('V' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "V";
                }
                count++;
            }
            checking();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('B' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "B";
                }
                count++;
            }
            checking();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('N' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "N";
                }
                count++;
            }
            checking();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char h in word)
            {
                if ('M' == word[count])
                {
                    check[count] = true;
                    Controls[$"letter{count + 1}"].Text = "M";
                }
                count++;
            }
            checking();
        }
    }
}
