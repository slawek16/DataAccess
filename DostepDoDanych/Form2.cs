using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DostepDoDanych
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Kontroler kontroler = new Kontroler();
        private void button1_Click(object sender, EventArgs e)
        {
            var tabela = kontroler.WyswietlMiejsca().ToList();
            string[] tabela2 = new string[tabela.Count];

            textBox1.Text = listBox1.ValueMember;
            
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_DostepDoDanych_BloggingContextDataSet.Aktors' table. You can move, or remove it, as needed.
            this.aktorsTableAdapter.Fill(this._DostepDoDanych_BloggingContextDataSet.Aktors);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedValue.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
