using Tyuiu.RaushKN.Sprint6.Task5.V3.Lib;

namespace Tyuiu.RaushKN.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\rausc\source\repos\Tyuiu.RaushKN.Sprint6\Tyuiu.RaushKN.Sprint6.Task5.V3\bin\Debug\net8.0-windows\InPutDataFileTask5V3.txt";
        
        private void SetupPlot()
        {
            formsPlotChartResult_RKN.Plot.Title("Диаграмма");
            formsPlotChartResult_RKN.Plot.XLabel("Ось X");
            formsPlotChartResult_RKN.Plot.YLabel("Ось Y");
        }
        private void bettonDone_Click(object sender, EventArgs e)
        {
            try
            {
                double[] numbers = ds.LoadFromDataFile(path);
                dataGridViewResult_RKN.Rows.Clear();
                formsPlotChartResult_RKN.Plot.Clear(); 

                if (dataGridViewResult_RKN.Columns.Count == 0)
                    dataGridViewResult_RKN.Columns.Add("value", "");

                for (int i = 0; i < numbers.Length; i++)
                {
                    dataGridViewResult_RKN.Rows.Add(numbers[i].ToString(""));
                }

                double[] positions = new double[numbers.Length];
                for (int i = 0;i < positions.Length; i++)
                {
                    positions[i] = i + 1;
                }

                var bar = formsPlotChartResult_RKN.Plot.Add.Bars(numbers);

                formsPlotChartResult_RKN.Refresh();

                if (numbers.Length == 0)
                {
                    MessageBox.Show("Положительные числа в файле не найдены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch
            {
                MessageBox.Show("Произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();

            }
            catch
            {
                MessageBox.Show("Сбой при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-24-1 Рауш Кирилл Николаевич", "Справка");
        }
        private void buttonResult_RKN_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_RKN.BackColor = Color.Blue;
        }

        private void buttonResult_RKN_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_RKN.BackColor = Color.Red;
        }

        private void buttonResult_RKN_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_RKN.BackColor = Color.Green;
        }
    }
}
