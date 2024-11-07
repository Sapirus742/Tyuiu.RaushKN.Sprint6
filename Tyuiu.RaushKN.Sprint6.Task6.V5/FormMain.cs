using Tyuiu.RaushKN.Sprint6.Task6.V5.Lib;

namespace Tyuiu.RaushKN.Sprint6.Task6.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        private void buttonDone_Clik(object sender, EventArgs e)
        {
            textBoxResult_RKN.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_RKN.ShowDialog();
            openFilePath = openFileDialogTask_RKN.FileName;
            textBoxLoadFromFile_RKN.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData_RKN.Text = groupBoxOutPutData_RKN.Text + " " + openFileDialogTask_RKN.FileName;
            buttonDone_RKN.Enabled = true;
        }
    }
}
