using Tyuiu.ShmelevAV.Sprint6.Task3.V15.Lib;

namespace Tyuiu.ShmelevAV.Sprint6.Task3.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix = {
                {  33, 28, 31, 19, 4 },
                {  1, 32, -3, -17, -12 },
                {  24, -19, 26, 31, -3 },
                { 30, -16, 29, 28, 8 },
                { 30, 5, 11, 7, 32 }
            };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dataGridViewMatrix_SAV.ColumnCount = columns;
            dataGridViewMatrix_SAV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SAV.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewMatrix_SAV.Rows[i].Height = 25;
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SAV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonStart_SAV_Click(object sender, EventArgs e)
        {
            int[,] array = ds.Calculate(matrix);
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            dataGridViewMatrix_SAV.ColumnCount = columns;
            dataGridViewMatrix_SAV.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SAV.Rows[i].Cells[j].Value = array[i, j].ToString();
                }
            }
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-24-2 Шмелев Алексей Витальевич", "Сообщение");
        }
    }
}
