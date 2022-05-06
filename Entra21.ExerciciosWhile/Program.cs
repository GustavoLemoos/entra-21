using Entra21.ExerciciosWhile;

Console.WriteLine(@"---------Menu--------------
1 - Exemplo 01
2 - Exemplo 02
3 - Exemplo 03");

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
