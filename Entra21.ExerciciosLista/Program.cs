using Entra21.ExerciciosLista;

//Console.WriteLine(@"---------Menu--------------
//1 - Exemplo 01
//2 - Exemplo 02
//3 - Exemplo 03");

//Console.Write("Digite a opção desejada: ");
//int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

//if (opcaoDesejada == 1)
//{
//    // MenuDaClasse nomeVariavel = new NomeDaClasse();
//    Exercicio01 exercicio01 = new Exercicio01();
//    exercicio01.Executar();
//}
//else if (opcaoDesejada == 2)
//{
//    Exercicio02 exercicio02 = new Exercicio02();
//    exercicio02.Executar();
//}
//else if (opcaoDesejada == 3)
//{
//    Exercicio03 exercicio03 = new Exercicio03();
//    exercicio03.Executar();
//}

using Entra21.ExerciciosLista.ExemplosListasObjetos;

ProdutoControlador controlador = new ProdutoControlador();
controlador.GerenciarMenu();
