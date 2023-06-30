using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T31_projetobase
{
    public partial class frmTorre1 : Form
    {
        private char[] arr;
        private int movimentos;

        public frmTorre1()
        {
            InitializeComponent();
            arr = new char[] { 'A', 'B', 'C' };
            movimentos = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            movimentos = 0;
            int discos = (int)numericUpDown1.Value;
            Torre(discos, 'A', 'B', 'C');
            listBox1.Items.Add($"Total de movimentos: {movimentos}");
        }

        private void Torre(int n, char origem, char destino, char auxiliar)
        {
            if (n > 0)
            {
                // Move n-1 discos da origem para o auxiliar usando o destino como auxiliar
                Torre(n - 1, origem, auxiliar, destino);

                // Move o disco restante da origem para o destino
                movimentos++;
                listBox1.Items.Add($"Mover disco {n} da torre {origem} para a torre {destino}");

                // Move os n-1 discos do auxiliar para o destino usando a origem como auxiliar
                Torre(n - 1, auxiliar, destino, origem);
            }
        }
    }
}
