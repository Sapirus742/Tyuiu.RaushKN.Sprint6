using Tyuiu.RaushKN.Sprint6.Task1.V19.Lib;

namespace Tyuiu.RaushKN.Sprint6.Task1.V19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void bettonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_RKN.Text);
                int stopStep = Convert.ToInt32(textBoxStop_RKN.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_RKN.Text = "";
                textBoxResult_RKN.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_RKN.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_RKN.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0, 5:d}     |  {1, 5:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_RKN.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_RKN.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-24-1 Рауш Кирилл Николаевич", "Справка");
        }
    }
}
