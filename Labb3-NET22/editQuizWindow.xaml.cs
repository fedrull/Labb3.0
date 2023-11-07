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

namespace Labb3_NET22
{
    /// <summary>
    /// Interaction logic for editQuizWindow.xaml
    /// </summary>
    public partial class editQuizWindow : Window
    {
        public editQuizWindow()
        {
            InitializeComponent();
        }

        public object questionTextBox { get; private set; }

        private  async void addButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton[] array = new RadioButton[]
            {
                correctAns1,correctAns2,correctAns3,correctAns4
            };

            int correctAnswer = -1;           
            
            for (int i = 0; i < array.Count(); i++)
            {
                if (array[i].IsChecked??false)
                {
                    correctAnswer = i;

                    break;
                }
            
            }

            if(correctAnswer < 0)
            {
                MessageBox.Show("Please slecet correct answer");

                return;
            }
            
            Question addQuestion = new Question(AddtxtQuestion.Text, new string[] { AddQAns1.Text, AddQAns2.Text, AddQAns3.Text, AddQAns4.Text }, correctAnswer );
            Database.allQuestions.Add(addQuestion);
            await Database.WriteFiles();

        }

    }
}
