using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Labb3_NET22.DataModels
{
    public static class Database
    {
        public static List<Question> allQuestions = new List<Question>();

        public static async Task ReadFiles()
        {
            //"C:\Users\felix\source\repos\Labb3-NET22\Labb3-NET22\bin\Debug\net6.0-windows\Questions\Qusetion.JSON"
            string localAppData = @".\Questions";
            string textfilePath = System.IO.Path.Combine(localAppData, "Qusetion.JSON");

            if (File.Exists(textfilePath))
            {
                string jsonData = await File.ReadAllTextAsync(textfilePath);
                allQuestions = JsonConvert.DeserializeObject<List<Question>>(jsonData);
            }
           
        }
        public static async Task WriteFiles()
        {

            string localAppData = @".\questions";
            string textfilePath = System.IO.Path.Combine(localAppData, "Qusetion.json");

            var jsonFile = JsonConvert.SerializeObject(allQuestions);
            await File.WriteAllTextAsync(textfilePath, jsonFile);
        }
        

        


        //addquestions
        //async readfiles
        //async writefiles
        //async getfolder
    }
}
