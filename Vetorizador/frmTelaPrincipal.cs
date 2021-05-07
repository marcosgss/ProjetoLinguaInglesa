using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vetorizador
{
    public partial class frmTelaPrincipal : Form
    {
        #region Construtores

        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region Atributos



        #endregion

        #region Eventos

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTexto_Click(object sender, EventArgs e)
        {
            if(txtTexto.Text == "Insira seu texto")
                txtTexto.Text = string.Empty;
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "Insira seu texto" || txtTexto.Text == string.Empty || txtTexto.Text == null)
            {
                MessageBox.Show("Informe o texto a ser inserido no banco de dados", "Atenção", MessageBoxButtons.OK);
                return;
            }

            string[] vet = txtTexto.Text.Split(' ');
            int count = 0;
            string receptor = string.Empty;

            for (int i = 0; i < vet.Length; i++)
            {
                receptor = vet[i].Replace(".", string.Empty).Replace(",", string.Empty)
                    .Replace(";", string.Empty).Replace("!", string.Empty).Replace("?", string.Empty)
                    .Replace("(", string.Empty).Replace(")", string.Empty).Replace("[", string.Empty)
                    .Replace("]", string.Empty).Replace("'", string.Empty).Replace("\"", string.Empty)
                    .Replace(" ", string.Empty).Trim().ToLower();                

                if (receptor != null && receptor != string.Empty && receptor != " " && receptor != "")
                {
                    count++; // count = 1 
                }                
            }

            MessageBox.Show(count + " palavras!", "Opa!", MessageBoxButtons.OK);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "Insira seu texto";
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text == "Insira seu texto" || txtTexto.Text == string.Empty || txtTexto.Text == null)
            {
                MessageBox.Show("Informe o texto a ser inserido no banco de dados", "Atenção", MessageBoxButtons.OK);
                return;
            }

            string[] vet = txtTexto.Text.Split(" ");
            string receptor = string.Empty;

            for (int i = 0; i < vet.Length; i++)
            {
                receptor = vet[i].Replace(".", string.Empty).Replace(",", string.Empty)
                    .Replace(";", string.Empty).Replace("!", string.Empty).Replace("?", string.Empty)
                    .Replace("(", string.Empty).Replace(")", string.Empty).Replace("[", string.Empty)
                    .Replace("]", string.Empty).Replace("'", string.Empty).Replace("\"", string.Empty)
                    .Replace(" ", string.Empty).Trim().ToLower();

                if (receptor != null && receptor != string.Empty && receptor != " " && receptor != "")
                {
                    MessageBox.Show(i+1 + "ª palavra: " + receptor, "Opa!", MessageBoxButtons.OK);
                }
            }

        }

        #endregion
    }
}
