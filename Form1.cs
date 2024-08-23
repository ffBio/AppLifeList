using System;
using System.Windows.Forms;
using LifeList.Classes;


namespace LifeList {
    public partial class Form1 : Form {
        private GerenciadorDeTarefas gerenciadorDeTarefas;

        public Form1() {
            InitializeComponent();
            gerenciadorDeTarefas = new GerenciadorDeTarefas();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e) {
            var tarefa = new Tarefas(
                textBoxTarefa.Text,
                textBoxDescricao.Text,
                dateTimePicker.Value
            );
            gerenciadorDeTarefas.AdicionarTarefa(tarefa);
            AtualizarListaDeTarefas();
        }

        private void buttonRemover_Click(object sender, EventArgs e) {
            var descricao = textBoxDescricao.Text;
            var tarefaParaRemover = gerenciadorDeTarefas.EncontrarTarefaPorDescricao(descricao);
            if(tarefaParaRemover != null) {
                gerenciadorDeTarefas.RemoverTarefa(tarefaParaRemover);
                AtualizarListaDeTarefas();
            } else {
                MessageBox.Show("Tarefa não encontrada.");
            }
        }

        private void AtualizarListaDeTarefas() {
            listBoxTarefas.Items.Clear();
            foreach(var tarefa in gerenciadorDeTarefas.ListaDeTarefas) {
                listBoxTarefas.Items.Add($"{tarefa.DataHora:dd/MM/yyyy HH:mm} - {tarefa.Tarefa}: {tarefa.Descricao}");
            }
        }


        private void buttonSalvar_Click(object sender, EventArgs e) {
            // Implementar funcionalidade de salvar tarefas
        }

        private void buttonCarregar_Click(object sender, EventArgs e) {
            // Implementar funcionalidade de carregar tarefas
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e) {

        }

        private void textBoxDescricao_TextChanged(object sender, EventArgs e) {

        }
    }
}
