using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ListaDeContatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Contato[] contatos = new Contato[1];

        private void Escrever(Contato contato) //Verde é tipo
        //Azul é nome
        {
            StreamWriter escreverEmArquivo = new StreamWriter("Contatos.txt");
            escreverEmArquivo.WriteLine(contatos.Length + 1);
            escreverEmArquivo.WriteLine(contato.Nome);
            escreverEmArquivo.WriteLine(contato.Sobrenome);
            escreverEmArquivo.WriteLine(contato.Telefone);

            for (int x = 0; x < contatos.Length; x++) //++ = 1
            {
                escreverEmArquivo.WriteLine(contatos[x].Nome);
                escreverEmArquivo.WriteLine(contatos[x].Sobrenome);
                escreverEmArquivo.WriteLine(contatos[x].Telefone);

            }
            escreverEmArquivo.Close();


        }
        private void Ler()
        {
            StreamReader lerArquivo = new StreamReader("Contatos.txt");
            contatos = new Contato[Convert.ToInt32(lerArquivo.ReadLine())];

            for (int x = 0;x < contatos.Length; x++)
            {
                contatos[x] = new Contato();
                contatos[x].Nome = lerArquivo.ReadLine();
                contatos[x].Sobrenome = lerArquivo.ReadLine();
                contatos[x].Telefone = lerArquivo.ReadLine();
            }
            lerArquivo.Close();
        }
        //Atualiza a tela do programa com os contatos
        private void Exibir()
        {
            ListBoxContatos.Items.Clear();
            for(int x = 0; x < contatos.Length; x++)
            {
                ListBoxContatos.Items.Add(contatos[x].ToString());
            }
        }
        private void LimparFormulário()
        {
            textBoxNome.Text = String.Empty;
            textBoxSobrenome.Text = String.Empty;
            textBoxTelefone.Text = String.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            Organizar();
            Exibir();
        }

        private void buttonIncluirContato_Click(object sender, EventArgs e)
        {
                //Cria um objeto da classe contato
            Contato contato = new Contato();
            contato.Nome = textBoxNome.Text;
            contato.Sobrenome = textBoxSobrenome.Text;
            contato.Telefone = textBoxTelefone.Text;

            //ListBoxContatos.Items.Add(contato.ToString());

            Escrever(contato);
            Organizar();
            Ler();
            Exibir();
            LimparFormulário();
            
              
        }
        private void Organizar()
        {
            Contato temporario;
            bool troca = true;

            do
            {
                troca = false;

                for( int x = 0; x < contatos.Length -1;)
                {
                    if (contatos[x].Nome.CompareTo(contatos[x + 1].Nome) > 0)
                    {
                        temporario = contatos[x];
                        contatos[x] = contatos[x + 1];
                        contatos[x + 1] = temporario;
                        troca = true;
                    }

                }
            } while ( troca == true );
        }

        private void buttonOrganiza_Click(object sender, EventArgs e)
        {
            Organizar();
            Exibir();
        }
    }
}
