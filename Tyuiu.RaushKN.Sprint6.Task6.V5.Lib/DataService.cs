using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RaushKN.Sprint6.Task6.V5.Lib
{
    public class DataService : ISprint6Task6V5
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] arrow = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < arrow.Length; i++)
                    {
                        if (arrow[i].Contains("l"))
                        {
                            res += arrow[i] + " ";
                        }
                    }
                }
            }

            return res.Trim();
        }
    }
}
