using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    internal class PacienteServico
    {
        private List<Paciente> pacientes;

        public PacienteServico()
        {
            pacientes = new List<Paciente>();

            LerArquivo();
        }

        // Método que expõe a lista de pacientes que tem o encapsulamento privado

        public List<Paciente> ObterTodos()
        {
            return pacientes;
        }

        private void LerArquivo()
        {
            // Verificar se o arquivo existe
            if (File.Exists("pacientes.json") == false)
                return;

            // Ler arquivo JSON com a lista de pacientes
            var pacientesJson = File.ReadAllText("pacientes.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(pacientesJson);


        }
    }
}
