using Tyuiu.ShmelevAV.Sprint6.Task2.V20.Lib;

namespace Tyuiu.ShmelevAV.Sprint6.Task2.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonStart_SAV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStart_SAV.Text);
                int stopStep = Convert.ToInt32(textBoxInputStop_SAV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartDiagram_SAV.Titles.Add("График функции");

                this.chartDiagram_SAV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartDiagram_SAV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewTable_SAV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartDiagram_SAV.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-24-2 Шмелев Алексей Витальевич", "Сообщение");
        }

        private void buttonStart_SAV_MouseEnter(object sender, EventArgs e)
        {
            buttonStart_SAV.BackColor = Color.Red;
        }

        private void buttonStart_SAV_MouseLeave(object sender, EventArgs e)
        {
            buttonStart_SAV.BackColor = Color.Green;
        }

        private void buttonStart_SAV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStart_SAV.BackColor = Color.Blue;
        }
    }
}
