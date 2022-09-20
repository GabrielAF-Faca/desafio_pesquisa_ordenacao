namespace desafio
{
    public partial class Form1 : Form
    {
        List<Aluno> alunos;

        public Form1()
        {
            InitializeComponent();
            alunos = new List<Aluno>();
        }


        private void button_listar_Click(object sender, EventArgs e)
        {

            textBox_listagem.Text = "";


            foreach (Aluno aluno in alunos)
                textBox_listagem.Text += "Nome: " + aluno.get_nome() + " - Curso: " + aluno.get_curso() + "\r\n";

        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(textBox_nome.Text, textBox_curso.Text);

            alunos.Add(aluno);

            if (alunos.Count > 1)
                Util.bubble_sort(alunos);


            textBox_nome.Text = "";
            textBox_curso.Text = "";


        }

        private void atualizar_button(object sender, EventArgs e)
        {
            if (textBox_nome.Text.Length > 0 && textBox_curso.Text.Length > 0)
                button_cadastrar.Enabled = true;
            else
                button_cadastrar.Enabled = false;


        }

        

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_listagem.Text = "";

        }
    }
}