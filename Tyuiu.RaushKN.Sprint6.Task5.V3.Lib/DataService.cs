using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RaushKN.Sprint6.Task5.V3.Lib
{
    public class DataService : ISprint6Task5V3
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string trimmedLine = line.Trim();
                    if (!string.IsNullOrEmpty(trimmedLine) &&
                    (trimmedLine.Contains('.') || trimmedLine.Contains(','))) len++;

                }
            }

            double[] numsArray = new double[len];

            int i = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while (( line = reader.ReadLine()) != null)
                {
                    string trimmedLine = line.Trim();
                    if (!string.IsNullOrEmpty(trimmedLine) && (trimmedLine.Contains('.') || trimmedLine.Contains(',')))
                    {
                        numsArray[i] = Convert.ToDouble(line);
                        i++;
                    }

                }
            }

            return numsArray;
        }
    }
}
