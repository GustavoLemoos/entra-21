using Entra21.ExerciciosWhile;

Console.WriteLine(@"---------Menu--------------
1  - Exercício 08
2  - Exercício 09
3  - Exercício 10
4  - Exercício 13
5  - Exercício 14
6  - Exercício 15
7  - Exercício 16
8  - Exercício 17
9  - Exercício 11
10 - Exercício 12");

Console.Write("Digite a opção desejada: ");
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
else if (opcaoDesejada == 4)
{
    Exercicio13 exercicio13 = new Exercicio13();
    exercicio13.Executar();
}
else if (opcaoDesejada == 5)
{
    Exercício14 exercicio14 = new Exercício14();
    exercicio14.Executar();
}
else if (opcaoDesejada == 6)
{
    Exercício15 exercicio15 = new Exercício15();
    exercicio15.Executar();
}
else if (opcaoDesejada == 7)
{
    Exercício16 exercicio16 = new Exercício16();
    exercicio16.Executar();
}
else if (opcaoDesejada == 8)
{
    Exercício17 exercicio17 = new Exercício17();
    exercicio17.Executar();
}
else if (opcaoDesejada == 9)
{
    Exercício11 exercicio11 = new Exercício11();
    exercicio11.Executar();
}
else if (opcaoDesejada == 10)
{
    Exercício12 exercicio12 = new Exercício12();
    exercicio12.Executar();
}
