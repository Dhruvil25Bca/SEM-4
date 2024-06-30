using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vowel = 0, spaces = 0,digits=0,spsymbol=0,consonant=0;
            int i;
            for (i = 0; i < textBox1.Text.Length; i++)
            { 
                char ch=char.ToLower(textBox1.Text[i]);
                if (char.IsDigit(ch))
                {
                    digits++;
                }
                else if (ch == ' ')
                {
                    spaces++;
                }
                else if (!char.IsLetterOrDigit(ch))
                {
                    spsymbol++;
                }
                else if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowel++;
                }
                else
                {
                    consonant++;
                }
               
            }
            String str = "There are \n" + vowel + "-vowels\n" + digits + "-digits\n" + spsymbol + "-Special Symboles\n" + spaces + "-spaces\n found in this text";
            MessageBox.Show(str);
        }
    }
}
