using Tyuiu.ShmelevAV.Sprint6.Task5.V8.Lib;

namespace Tyuiu.ShmelevAV.Sprint6.Task5.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutDataFileTask5V8.txt";

        private void buttonStart_SAV_Click(object sender, EventArgs e)
        {
            dataGridViewOutput_SAV.ColumnCount = 2;
            dataGridViewOutput_SAV.Columns[0].Width = 20;
            dataGridViewOutput_SAV.Columns[1].Width = 50;

            this.chartDiagram_SAV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiagram_SAV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiagram_SAV.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutput_SAV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiagram_SAV.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_SAV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-24-2 Шмелев Алексей Витальевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
