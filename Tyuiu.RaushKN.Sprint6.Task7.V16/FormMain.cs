using System.IO;
using Tyuiu.RaushKN.Sprint6.Task7.V16.Lib;

using Tyuiu.RaushKN.Sprint6.Task7.V16.Lib;

namespace Tyuiu.RaushKN.Sprint6.Task7.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_RKN.Filter = "Значения разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_RKN.Filter = "Значения разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        int rows;
        int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_RKN.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_RKN.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_RKN.ShowDialog();

            string path = saveFileDialogMatrix_RKN.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_RKN.RowCount;
            int columns = dataGridViewOutMatrix_RKN.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_RKN.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_RKN.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arraysValues = new int[rows, columns];
            arraysValues = ds.GetMatrix(openFilePath);

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    try
                    {
                        dataGridViewOutMatrix_RKN.Rows[x].Cells[y].Value = arraysValues[x, y];
                    }
                    catch
                    {
                        MessageBox.Show($"Количество строк: {rows} {x}, количество столбцов: {columns} {y}", "Информация", MessageBoxButtons.OK);
                    }
                }
            }

            buttonSaveFile_RKN.Enabled = true;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_RKN.ShowDialog();
            openFilePath = openFileDialogTask_RKN.FileName;

            rows = 10;
            columns = 10;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInMatrix_RKN.ColumnCount = columns;
            dataGridViewInMatrix_RKN.RowCount = rows;
            dataGridViewOutMatrix_RKN.ColumnCount = columns;
            dataGridViewOutMatrix_RKN.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_RKN.Columns[i].Width = 25;
                dataGridViewOutMatrix_RKN.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInMatrix_RKN.Rows[r].Cells[c].Value = arrayValues[r,c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_RKN.Enabled = true;
        }

        private void FromMain_Load (object sender, EventArgs e)
        {
            dataGridViewInMatrix_RKN.ColumnCount = 50;
            dataGridViewInMatrix_RKN.RowCount = 50;
            dataGridViewOutMatrix_RKN.ColumnCount = 50;
            dataGridViewOutMatrix_RKN.ColumnCount = 50;

            //panelLeft.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInMatrix_RKN.Columns[i].Width = 25;
                dataGridViewOutMatrix_RKN.Columns[i].Width = 25;
            }
        }

        private void buttonHelp_Click (object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();        
        }
    }
}
