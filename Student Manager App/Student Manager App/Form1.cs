using System.Data;
using System.Text;

namespace Student_Manager_App
{    
    public partial class Form1 : Form
    {
     
        GPAx oGPAcal = new GPAx();
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string[] readAlllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);
                //this.textBox2.Text = readAllText;
                //this.dataGridView1.Rows.Add(textBox2);
                

                for (int i = 0; i < readAlllLine.Length; i++)
                {
                    string studentRAW = readAlllLine[i];
                    string[] studentSplited = studentRAW.Split(',');
                    Student student = new Student(studentSplited[0], studentSplited[1], studentSplited[2]);
                    //addDatatoGridView(student);
                    //TODO: Add Student object to DataGridView
                    

                }

                //TODO: Calculator max, min, GPAx
                
            }
        }
        private void addDatatoGridView(string id, string name, string major) {
            this.dataGridView1.Rows.Add(new string[] { id, name, major });
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string strData = string.Empty;            
 
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                if (saveFileDialog.FileName != string.Empty) {


                    int row = this.dataGridView1.Rows.Count;
                    for (int i = 0; i < row; i++)
                    {
                        int column = this.dataGridView1.Columns.Count;
                        for (int j = 0; j < column; j++) {
                            strData = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                            //TODO: get data form datagridView1 to variable
                            strData = dataGridView1.Columns.Count.ToString();
                            



                        }
                    }


                    //save file
                    File.WriteAllText(saveFileDialog.FileName, strData, Encoding.UTF8);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = this.textBox4.Text;
            string name = this.textBox3.Text;

            double dInput = Convert.ToDouble(input);
            oGPAcal.addGPA(dInput, name);

            double gpax = oGPAcal.getGPAx();
            textBoxGPA.Text = gpax.ToString();

            textBoxMAX.Text = oGPAcal.getMax().ToString();
            textBoxMaxName.Text = oGPAcal.getMaxName().ToString();

            textBoxMIN.Text = oGPAcal.getMin().ToString();
            textBoxMinName.Text = oGPAcal.getMinname().ToString();

            textBox3.Text = "";
            textBox3.Text = string.Empty;
            dataGridView1.Text = oGPAcal.getAllData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[0].Value = textBox2.Text;
            dataGridView1.Rows[0].Cells[1].Value = textBox3.Text;
            dataGridView1.Rows[0].Cells[3].Value = textBox4.Text;
            dataGridView1.Rows[0].Cells[2].Value = comboBox1.Text;

            string input = this.textBox4.Text;
            string name = this.textBox3.Text;

            double dInput = Convert.ToDouble(input);
            oGPAcal.addGPA(dInput, name);

            double gpax = oGPAcal.getGPAx();
            textBoxGPA.Text = gpax.ToString();

            textBoxMAX.Text = oGPAcal.getMax().ToString();
            textBoxMaxName.Text = oGPAcal.getMaxName().ToString();

            textBoxMIN.Text = oGPAcal.getMin().ToString();
            textBoxMinName.Text = oGPAcal.getMinname().ToString();

            textBox4.Text = "";
            textBox3.Text = string.Empty;

        }
    }
}