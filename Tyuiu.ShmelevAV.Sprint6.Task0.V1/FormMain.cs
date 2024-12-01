using Tyuiu.ShmelevAV.Sprint6.Task0.V1.Lib;

namespace Tyuiu.ShmelevAV.Sprint6.Task0.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_SAV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_SAV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxWrite_SAV)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxWrite_SAV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-24-2 Шмелев Алексей Витальевич", "Сообщение");
        }
    }
}
