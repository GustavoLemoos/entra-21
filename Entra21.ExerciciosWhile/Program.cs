using Entra21.ExerciciosWhile;

Console.WriteLine(@"---------Menu--------------
1 - Exercício 01
2 - Exercício 02
3 - Exercício 03");

Console.Write("Digite a opção desejada dasdsa: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    // MenuDaClasse nomeVariavel = new NomeDaClasse();
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicio09 exercicio09 = new Exercicio09();
    exercicio09.Executar();
}
else if (opcaoDesejada == 3)
{
    Exercicio10 exercicio10 = new Exercicio10();
    exercicio10.Executar();
}
