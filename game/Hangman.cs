using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace game
{
    public partial class Hangman : Form
    {
        public Hangman()
        {
            InitializeComponent();
        }


        // ========== GLOBAL VARIABLES ==========

        public string label;                             // Topic name label
        public List<string> words = new List<string>();  // List than will recive elements from chosen topic (from Menu.cs)
        string randomWord;                                    // Random element from a list
        List<char> list = new List<char>();              // List than contains underscores ('_')
        List<char> list2 = new List<char>();             // List than contains chars from randomWord
        int numberOfErrors = 0;                 
        int scoreValue = 0;
        bool stopLoop = false;


        public int GetRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void NewGame()
        {
            // ========== Reset variables and lists ==========

            topicLabel.Text = label;
            numberOfErrors = 0;
            list.Clear();
            list2.Clear();
            randomWord = string.Empty;
            wordText.Text = string.Empty;

            int randomNum = GetRandomNumber(0, words.Count());
            randomWord = words[randomNum];
            panel1.BackColor = Color.DeepSkyBlue;

            char[] characters = randomWord.ToCharArray();


            // ========== Fill 1st list with '_' and 2nd with randomWord chars ==========

            foreach (char c in characters)
            {
                list.Add('_');
                list2.Add(c);
            }


            // ========== Remove underscore if multiple words ==========

            for (int i = 0; i < list.Count(); i++)
            {
                if (list2[i].ToString() == " ")
                {
                    list[i] = ' ';
                }
                else if (list2[i].ToString() == "'")
                {
                    list[i] = ' ';
                }
            }

            string result = string.Join(" ", list);
            wordText.Text = result;


            // ========== Enable the buttons ==========

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = true;
                    control.BackColor = Color.Gainsboro;
                }
            }

            head.Visible = false;
            body.Visible = false;
            leftArm.Visible = false;
            rightArm.Visible = false;
            leftLeg.Visible = false;
            rightLeg.Visible = false;

        }


        private void Hangman_Load(object sender, EventArgs e)
        {
            NewGame();
        }


        private void Error()
        {
            numberOfErrors++;
            if(numberOfErrors == 1)
            {
                head.Visible = true;
            }
            else if(numberOfErrors == 2)
            {
                body.Visible = true;
            }
            else if( numberOfErrors == 3)
            {
                leftArm.Visible = true;
            }
            else if(numberOfErrors == 4)
            {
                rightArm.Visible = true;
            }
            else if(numberOfErrors == 5)
            {
                leftLeg.Visible = true;
            }
            else if(numberOfErrors == 6)
            {
                rightLeg.Visible = true;
                GameOver();
            }

        }
        
        public void GameOver()
        {
            SoundPlayer player = new SoundPlayer(@"C:\projekti visual studio\C#\Windows Form Application\game\game\Audio\wrong.wav");
            player.Play();

            //========== Display the word after losing ==========

            for (int i = 0; i < list2.Count(); i++)
            {
                list[i] = list2[i];
                string result = string.Join(" ", list);
                wordText.Text = result;
                panel1.BackColor = Color.Red;
                
            }
            DialogResult dialog = MessageBox.Show("Do you want to play again?", "GAME OVER", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                scoreValue = 0;
                score.Text = scoreValue.ToString();
                NewGame();
            }
            else
            {
                Application.Exit();
            }
        }


        public void StopLoop()
        {
            stopLoop = true;
        }

        public void CheckWin()
        {
            if (!wordText.Text.Contains('_'))
            {
                StopLoop();
                SoundPlayer player = new SoundPlayer(@"C:\projekti visual studio\C#\Windows Form Application\game\game\Audio\correct.wav");
                player.Play();
                panel1.BackColor = Color.Green;
                DialogResult dialog = MessageBox.Show("Go to next level?", "CORRECT", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    scoreValue++;
                    score.Text = scoreValue.ToString();
                    NewGame();
                }
                else
                {
                    Application.Exit();
                }
            }
        }


        private void Button_Click(object sender, EventArgs e)
        {
            stopLoop = false;
            SoundPlayer player = new SoundPlayer(@"C:\projekti visual studio\C#\Windows Form Application\game\game\Audio\buttonClick.wav");
            player.Play();
            Button clickedButton = sender as Button;
            char btn = Convert.ToChar(clickedButton.Name.ToUpper());
            int index = list.IndexOf(btn);
            bool wordFinded = false;


            for (int i = 0; i < list2.Count(); i++)
            {

                // ========== Detection if you found correct letter ==========

                if (stopLoop == false)
                {
                    if (list2[i].ToString().Contains(btn.ToString()))
                    {
                        list[i] = list2[i];
                        string result = string.Join(" ", list);
                        wordText.Text = result;
                        wordFinded = true;
                        clickedButton.Enabled = false;
                        clickedButton.BackColor = Color.Yellow;
                        CheckWin();
                    }
                    else if (wordFinded == false && i == list2.Count() - 1)
                    {
                        clickedButton.Enabled = false;
                        clickedButton.BackColor = Color.Yellow;
                        Error();
                        return;
                    }
                } 
            }
        }

        // ========== Change Topic ==========
        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
