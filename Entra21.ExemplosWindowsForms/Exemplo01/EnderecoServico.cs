using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWindowsForms.Exemplo01
{
    internal class EnderecoServico
    {
        private List<Endereco> enderecos;

        // Construtor
        public EnderecoServico()
        {
            enderecos = new List<Endereco>();
        }

        // Método adicionar recebe como parâmetro o objeto do endereço coompleto do Form(Controller)
        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarArquivo();
        }


    }
}
