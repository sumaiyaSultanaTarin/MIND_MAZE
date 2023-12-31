using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MIND_MAZE
{
    public partial class Q1UserControl: UserControl
    {
        private DataAccess Da { get; set; }
        public Q1UserControl()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

       
        
        private void PopulateGridView(String sql = "Select * from INSERT_Q;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvInsertQuestions.AutoGenerateColumns = false;
            this.dgvInsertQuestions.DataSource = ds.Tables[0];
        }

        private void AutoIdGenerate()
        {

            var sql = "Select TestId from Tests order by TestId desc";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldID = dt.Rows[0][0].ToString();
            string[] s = oldID.Split('-');
            int temp = Convert.ToInt32(s[1]);
            var newID = "t-" + (++temp).ToString("d3");
            this.TestIdLabel.Text = newID;
        }

        private void ClearContent()
        {

            this.TestIdLabel.Text = " ";
            this.TestNametxt.Clear();
            this.TestDepartmentTxt.Clear();
            this.TestISOtxt.Clear();
            this.TestPricetxt.Clear();

            this.AutoIdGenerate();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Q1UserControl_Load(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.TYPES_TXT.Text) || String.IsNullOrEmpty(this.Qtext.Text) || String.IsNullOrEmpty(this.O1txt.Text) || String.IsNullOrEmpty(this.O2txt.Text) || String.IsNullOrEmpty(this.O3txt.Text) || String.IsNullOrEmpty(this.Atxt.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToAdd())
                {
                
                    var sql = "Insert into INSERT_Q values('" + this.TYPES_TXT.Text + "' , '" + this.Qtext.Text + "','" + this.O1txt.Text + "'," + this.O2txt.Text + "'," + this.O3txt.Text + "'," + this.Atxt.Text + "'," + ");";

                    var flag = this.Da.ExecuteDMLQuery(sql);

                    if (flag == 1)
                    {
                        MessageBox.Show("New Test Added!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new Test");
                    }
                    this.ClearContent();

                    this.PopulateGridView();

                }
                else
                {
                    MessageBox.Show("Please fill all the required fields");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error Occured");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
