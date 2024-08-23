using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LifeList.Classes {
    public class GerenciadorDeTarefas {
        private List<Tarefas> listaDeTarefas = new List<Tarefas>();

        public void AdicionarTarefa(Tarefas tarefa) {
            listaDeTarefas.Add(tarefa);
        }

        public void RemoverTarefa(Tarefas tarefa) {
            listaDeTarefas.Remove(tarefa);
        }

        public List<Tarefas> ListaDeTarefas => listaDeTarefas;

        public void SalvarTarefas(string caminho) {
            var json = JsonConvert.SerializeObject(listaDeTarefas, Formatting.Indented);
            File.WriteAllText(caminho, json);
        }

        public void CarregarTarefas(string caminho) {
            if(File.Exists(caminho)) {
                var json = File.ReadAllText(caminho);
                listaDeTarefas = JsonConvert.DeserializeObject<List<Tarefas>>(json) ?? new List<Tarefas>();
            } else {
                Console.WriteLine("Arquivo de tarefas não encontrado.");
            }
        }

        public Tarefas EncontrarTarefaPorDescricao(string descricao) {
            return listaDeTarefas.Find(t => t.Descricao == descricao);
        }
    }
}
