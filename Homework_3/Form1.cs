using Microsoft.VisualBasic.FileIO;

namespace Homework_3
{
    public partial class Form1 : Form
    {
        private string fileName = "";
        List<List<string>> tables = new List<List<string>>();
        List<string> headers = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(this.fileName == ""))
            {
                using (TextFieldParser parser = new TextFieldParser(@fileName))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    int i = 0;
                    //int j = 0;
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();

                        if (headers.Count == 0)
                        {
                            foreach (string field in fields)
                            {
                                this.tables.Add(new List<string>());
                                this.tables[i].Add(field);
                                this.headers.Add(field);
                                i++;
                            }
                        }
                        else
                        {
                            foreach (string field in fields)
                            {
                                this.tables.Add(new List<string>());
                                this.tables[i].Add(field);
                                i++;
                            }
                        }
                        i = 0;
                        this.richTextBox1.AppendText("riuscito\n");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.fileName = this.openFileDialog1.FileName;
        }
    }
}