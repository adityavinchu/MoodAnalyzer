using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Program
    {

        public string AnalyzeMood(string str)
        {
            try
            {
                string[] moods = { "sad", "fear", "anger", "unhappy", "sombre", "melancholy", "homesick" };
                string[] words = str.Split(' ');
                bool sad = false;


                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = 0; j < moods[i].Length; j++)
                    {
                        if (words[i].ToLower().CompareTo(moods[j]) == 0) sad = true;
                    }
                }
                if (sad)
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch
            {
                return "HAPPY";
            }
        }

        public static void Main(string[] args)
        {

        }
    }
}
