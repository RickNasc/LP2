using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace P1LP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string[,] Alunos = new string[10,3];
            string[] Gabarito = { "E", "B", "A", "A", "C", "B", "D", "E", "B", "A" };
            string aux;

            int x = 0;
            int i = 0;

            for (x = 0; x < 10; x++)
            {
                for (i = 0; i < 3; i++)
                {
                    aux = Interaction.InputBox("Digite a resposta da questão " + (x + 1), "Entrada de Dados");
                    if (aux == "A" || aux == "B" || aux == "C" || aux =="D" || aux == "E")
                    {

                        Alunos[x, i] = aux;
                    }
                    else{
                        MessageBox.Show("Valor inválido");
                        i--;
                    }

               }
            }
            
            lstbxRespalunos.Items.Add("O Aluno: " + Alunos + " tem ");

            }
    }
}
               