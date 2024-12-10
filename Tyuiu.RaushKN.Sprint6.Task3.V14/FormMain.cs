using Tyuiu.RaushKN.Sprint6.Task3.V14.Lib;

namespace Tyuiu.RaushKN.Sprint6.Task3.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix = { {1, 4, -5, -12, -8 },
                          {-7, -20, 11, -13, 6},
                          {2, -12, 1, -12, 3 },
                          {-1, -7, -20, -6, 17 },
                          {-3, 3, 2, 13, -17 }
                                                  };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0)+1;
            int columns = matrix.Length / rows;

            dataGridViewMatrixData_RKN.ColumnCount = columns;
            dataGridViewMatrixData_RKN.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixData_RKN.Columns[i].Width = 25;
            }

            for (int i = 0;i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixData_RKN.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
            dataGridViewMatrixData_RKN.Rows[0].Cells[0].Selected = false;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-24-1 Рауш Кирилл Николаевич", "Справка");
        }

        private void buttonResult_RKN_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(matrix);
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrixResult_RKN.ColumnCount = columns;
            dataGridViewMatrixResult_RKN.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixResult_RKN.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixResult_RKN.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
    }
}
