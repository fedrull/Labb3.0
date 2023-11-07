using Labb3_NET22.DataModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace Labb3_NET22
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Quiz myquiz = new Quiz();

        int currentQusetion = 0;

        int qScore = 0;
        public Window1()
        {
            InitializeComponent();
            NextQustion();

        }

        public void checkAnswer(object sender, RoutedEventArgs e)
        {

            Button selctetedButton = (Button)sender;
            int selcetedAnswers = int.Parse(selctetedButton.Tag.ToString());

            if (selcetedAnswers == Database.allQuestions[currentQusetion].CorrectAnswerIndex)
            {
                qScore++;
                scoreText.Content = $"Score {qScore}/ {Database.allQuestions.Count}";
            }
            else
            {
                MessageBox.Show("Wrong Answer");
            }

            currentQusetion++;
            if (currentQusetion < Database.allQuestions.Count)
            {
                NextQustion();
            }
            else

            {
                ScoreWindow scoreWindow = new ScoreWindow();
                scoreWindow.score = qScore;
                scoreWindow.Show();
            }
        }
        public void RestartGame()
        {

        }
        public void NextQustion()
        {

            txtQuestion.Text = Database.allQuestions[currentQusetion].Statement;

            ans1.Content = Database.allQuestions[currentQusetion].Options[0];
            ans2.Content = Database.allQuestions[currentQusetion].Options[1];
            ans3.Content = Database.allQuestions[currentQusetion].Options[2];
            ans4.Content = Database.allQuestions[currentQusetion].Options[3];


        }
        public void StartGame()
        {

        }
   
    }
}
