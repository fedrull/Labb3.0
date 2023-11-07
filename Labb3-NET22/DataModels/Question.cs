using System.Collections.Generic;

namespace Labb3_NET22.DataModels;

public class Question
{
    public string Statement { get; }
    public string[] Options { get; }
    public int CorrectAnswerIndex { get; }

    public Question(string statement, string[] options, int correctAnswerIndex)
    {
        Statement = statement;
        Options = options;
        CorrectAnswerIndex = correctAnswerIndex;

    }



}