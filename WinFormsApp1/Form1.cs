using ArmDot.Client;
using ClassLibrary1;

[assembly: EmbedFile(
    SourcePath: "..\\ClassLibrary1\\bin\\Debug\\net9.0\\ClassLibrary1.dll",
    RuntimePath: @"$(AssemblyDirectory)\ClassLibrary1.dll")]

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Class1.Test().ToString());
        }
    }
}
