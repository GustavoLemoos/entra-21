namespace Entra21.ExercicioOrientacaoObjetoComListaMaisEstrutura.ExercicioTriangulo
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();
        private int codigoAtual = 1;

        public bool AdicionarLadosTriangulo(double lado1, double lado2, double lado3)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;

            if (triangulo.ValidarTriangulo() == true)
            {
                triangulo.Codigo = codigoAtual;
                codigoAtual++;
                triangulos.Add(triangulo);
            }
            return false;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                if (trianguloAtual.Codigo == codigo)
                {
                    return trianguloAtual;
                }
            }

            return null;
        }

        public bool Editar(double lado1, double lado2, double lado3, int codigoParaAlterar)
        {
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigoParaAlterar);
            if (trianguloParaAlterar == null)
            {
                return false;
            }
            var isTrianguloParaAlterarValido = false;
            Triangulo triangulo = new Triangulo();
            triangulo.Lado1 = lado1;
            triangulo.Lado2 = lado2;
            triangulo.Lado3 = lado3;
            if (triangulo.ValidarTriangulo() == true)
            {
                trianguloParaAlterar.Lado1 = lado1;
                trianguloParaAlterar.Lado2 = lado2;
                trianguloParaAlterar.Lado3 = lado3;
            }
            else
            {
                while (isTrianguloParaAlterarValido == false)
                {
                    isTrianguloParaAlterarValido = true;

                }

            }
            

            return true;
        }

        public bool Apagar(int codigo)
        {
            for (var i = 0; i < triangulos.Count; i++)
            {
                Triangulo triangulo = triangulos[i];
                if (triangulo.Codigo == codigo)
                {
                    triangulos.Remove(triangulo);
                    return true;
                }
            }

            return false;
        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }
    }
}

