using System.Text;

namespace MorseCodeTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Dictionary<char, String> morse = new Dictionary<char, String>()
            {
                {'A' , ".- "},
                {'B' , "-... "},
                {'C' , "-.-. "},
                {'D' , "-.. "},
                {'E' , ". "},
                {'F' , "..-. "},
                {'G' , "--. "},
                {'H' , ".... "},
                {'I' , ".. "},
                {'J' , ".--- "},
                {'K' , "-.- "},
                {'L' , ".-.. "},
                {'M' , "-- "},
                {'N' , "-. "},
                {'O' , "--- "},
                {'P' , ".--. "},
                {'Q' , "--.- "},
                {'R' , ".-. "},
                {'S' , "... "},
                {'T' , "- "},
                {'U' , "..- "},
                {'V' , "...- "},
                {'W' , ".-- "},
                {'X' , "-..- "},
                {'Y' , "-.-- "},
                {'Z' , "--.. "},
                {'0' , "----- "},
                {'1' , ".---- "},
                {'2' , "..--- "},
                {'3' , "...-- "},
                {'4' , "....- "},
                {'5' , "..... "},
                {'6' , "-.... "},
                {'7' , "--... "},
                {'8' , "---.. "},
                {'9' , "----. "},
                {' ', "  " },
                {',', "--..-- " },
                {'.', ".-.-.- " },
                {'?', "..--.. " },
                {'!', "-.-.-- " }
            };




            string userInput = txtInput.Text;
            userInput = userInput.ToUpper();
            for (int index = 0; index < userInput.Length; index++)
            {
                /*
                if (index > 0)
                {
                    lblOutput.Text = ('/').ToString();
                }
                */


                char t = userInput[index];
                if (morse.ContainsKey(t))
                {
                    lblOutput.Text += morse[t];
                }
            }
            var sb = new StringBuilder();
            for (int index = 0; index < userInput.Length; index++)
            {
                char t = userInput[index];
                //var t = t.ToUpper();
                string morseValue;

                if (morse.TryGetValue(t, out morseValue))
                {
                    sb.Append(morseValue);
                }
            }

            lblOutput.Text = sb.ToString();
        }




        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtInput.Text = " ";
            lblOutput.Text = " ";
        }
    }
}

