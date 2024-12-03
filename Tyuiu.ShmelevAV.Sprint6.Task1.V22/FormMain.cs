using Tyuiu.ShmelevAV.Sprint6.Task1.V22.Lib;

namespace Tyuiu.ShmelevAV.Sprint6.Task1.V22
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_SAV.Text = "";
                textBoxResult_SAV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_SAV.AppendText("|     X    |   f(x)   |" + Environment.NewLine);
                textBoxResult_SAV.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = string.Format("| {0,5:d}    |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult_SAV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_SAV.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-24-2 Шмелев Алексей Витальевич", "Сообщение");
        }
    }
}
