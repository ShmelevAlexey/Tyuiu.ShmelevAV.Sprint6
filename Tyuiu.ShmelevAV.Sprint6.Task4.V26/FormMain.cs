using Tyuiu.ShmelevAV.Sprint6.Task4.V26.Lib;

namespace Tyuiu.ShmelevAV.Sprint6.Task4.V26
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

                this.chartDiagram_SAV.ChartAreas[0].AxisX.Title = "��� X";
                this.chartDiagram_SAV.ChartAreas[0].AxisY.Title = "��� Y";

                textBoxOutput_SAV.Text = "";

                chartDiagram_SAV.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartDiagram_SAV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutput_SAV.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ ����-24-2 ������ ������� ����������", "���������");
        }

        private void buttonSave_SAV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V26.txt");
                File.WriteAllText(path, textBoxOutput_SAV.Text);

                DialogResult dialogResult = MessageBox.Show("���� " + path + " �������� �������!\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }

            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
