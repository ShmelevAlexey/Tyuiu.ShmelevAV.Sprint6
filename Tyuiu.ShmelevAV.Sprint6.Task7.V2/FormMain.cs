using Tyuiu.ShmelevAV.Sprint6.Task7.V2.Lib;

namespace Tyuiu.ShmelevAV.Sprint6.Task7.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_SAV.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_SAV.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

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

        private void buttonOpen_SAV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SAV.ShowDialog();
            openFilePath = openFileDialogTask_SAV.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_SAV.ColumnCount = columns;
            dataGridViewInput_SAV.RowCount = rows;
            dataGridViewOutput_SAV.ColumnCount = columns;
            dataGridViewOutput_SAV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_SAV.Columns[i].Width = 25;
                dataGridViewOutput_SAV.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_SAV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonStart_SAV.Enabled = true;
        }

        private void buttonStart_SAV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_SAV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_SAV.Enabled = true;
        }

        private void buttonSave_SAV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SAV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SAV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SAV.ShowDialog();

            string path = saveFileDialogMatrix_SAV.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_SAV.RowCount;
            int columns = dataGridViewOutput_SAV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput_SAV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_SAV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpen_SAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAV.ToolTipTitle = "Открыть файл";
        }

        private void buttonStart_SAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAV.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_SAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAV.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_SAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_SAV.ToolTipTitle = "Справка";
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
