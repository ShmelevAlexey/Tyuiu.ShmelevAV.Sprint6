using Tyuiu.ShmelevAV.Sprint6.Task6.V13.Lib;

namespace Tyuiu.ShmelevAV.Sprint6.Task6.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path;
        string str;

        private void buttonOpen_SAV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SAV.ShowDialog();
            path = openFileDialogTask_SAV.FileName;
            textBoxInput_SAV.Text = File.ReadAllText(path);
            groupInput_SAV.Text = groupInput_SAV.Text + " " + openFileDialogTask_SAV.FileName;
            buttonStart_SAV.Enabled = true;
        }

        private void buttonStart_SAV_Click(object sender, EventArgs e)
        {
            textBoxOutput_SAV.Text = ds.CollectTextFromFile(str, path);
        }

        private void buttonHelp_SAV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
