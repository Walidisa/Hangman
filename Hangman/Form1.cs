using System.Security.Cryptography.X509Certificates;

namespace Hangman
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        string[] words = {
            "apple",
            "banana",
            "cat",
            "dog",
            "car",  
            "bus",
            "cherry",
            "house",
            "elephant",
            "giraffe",
            "hippo",
            "iguana",
            "jaguar",
            "leopard"
         };
        int index;
        string word = "";
        string text = "";
        int lose = 0;
        int count = 0;
        Boolean win = false;
        string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hangmanPics");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hangmanPic_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            index = rand.Next(words.Length);
            word = words[index];
            guessButton.Enabled = true;
            inputText.Enabled = true;
            richTextBox1.BackColor = Color.White;
            richTextBox1.Enabled = false;
            hangmanPic.Image = Image.FromFile(Path.Combine(basePath, "empty.png"));
            richTextBox1.Text = "";
            for (int i = 0; i < word.Length; i++)
            {
                richTextBox1.Text += "_ ";
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                startButton.Enabled = false;
            }
            

        }
        private void guessButton_Click(object sender, EventArgs e)
        {
           
            Boolean check = false;
            int charIndex = 0;
            string u = "";
            if (inputText.Text.Length > 0)
            {
               char a = inputText.Text[0];
               for (int i = 0; i<word.Length; i++)
                {
                    if (a == word[i])
                    {
                        charIndex = i;
                        check = true;
                    }
                }
                if (check)
                {
                    text = "";
                    for (int i = 0; i < richTextBox1.Text.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            if (word[i/2] == a)
                            {
                                u += a;
                                text += a + " ";
                                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                            }

                            else
                            {
                                text += richTextBox1.Text[i] + " ";
                                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                                startButton.Enabled = false;
                            }
                        }

                    }
                    //for (int i = 0; i < richTextBox1.Text.Length; i++)
                    //{

                    //else
                    //    {
                    //       win = false;
                    //    }
                    //}
                    //if (count == word.Length)
                    //{
                    //    win = true;
                    //    richTextBox1.Enabled = true;
                    //    richTextBox1.BackColor = Color.Green;
                    //}
                    richTextBox1.Text = text;
                     richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                }
                else
                {
                    MessageBox.Show("You guessed the wrong letter!");
                    lose++;
                    switch (lose)
                    {
                        case 1:
                            hangmanPic.Image = Image.FromFile(Path.Combine(basePath, "head.png"));
                            break;
                        case 2:
                            hangmanPic.Image = Image.FromFile(Path.Combine(basePath, "head+body.png"));
                            break;
                        case 3:
                            hangmanPic.Image = Image.FromFile(Path.Combine(basePath, "head+body+rightarm.png"));
                            break;
                        case 4:
                            hangmanPic.Image = Image.FromFile(Path.Combine(basePath, "head+body+allArms.png"));
                            break;
                        case 5:
                            hangmanPic.Image = Image.FromFile(Path.Combine(basePath, "head+body+allArms+rightLeg.png"));
                            break;
                        case 6:
                            hangmanPic.Image = Image.FromFile(Path.Combine(basePath, "fullsize.png"));
                            richTextBox1.Enabled = true;
                            richTextBox1.BackColor = Color.Red;
                            MessageBox.Show("Oops the Hangman has Died! You couldn't Guess the Correct Word! \nPress Start to start another game");
                            startButton.Enabled = true;
                            guessButton.Enabled = false;
                            inputText.Enabled = false;
                            lose = 0;
                            break;

                    }
                }
                inputText.Text = "";
            }
            else
            {
                MessageBox.Show("Enter a letter.");
            }
            if (!richTextBox1.Text.Contains('_'))
                        {
                win = true;
                richTextBox1.Enabled = true;
                richTextBox1.BackColor = Color.Green;
                MessageBox.Show("Congratulations! You have guessed the correct word and Saved the Hangman! \nPress Start to generate another word and start another game");
                startButton.Enabled = true;
                guessButton.Enabled = false;
                inputText.Enabled = false;
                hangmanPic.Image = Image.FromFile(Path.Combine(basePath, "empty.png"));
                lose = 0;
                count = 0;
                            //win = false;
                        }
            //if (win)
            //{
            //    MessageBox.Show("Congratulations! You have guessed the correct word and Saved the Hangman! \nPress Start to generate another word and start another game");

            //    startButton.Enabled = true;
            //    guessButton.Enabled = false;
            //    inputText.Enabled = false;
            //    hangmanPic.Image = Image.FromFile("C:/Users/walid/Downloads/empty.png");
            //    lose = 0;
            //    count = 0;
            //    win = false;
            //}
        }
    }
}
