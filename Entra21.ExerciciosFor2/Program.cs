using Entra21.ExerciciosFor;

var opcaoDesejada = 0;
Console.WriteLine(@"---------Menu--------------
1 - Exercício 01
2 - Exercício 02
3 - Exercício 03
4 - Exercício 04
5 - Exercício 05
6 - Exercício 06");
Console.Write("Digite a opção desejada: ");
opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    // MenuDaClasse nomeVariavel = new NomeDaClasse();
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
if (opcaoDesejada == 2)
{
    // MenuDaClasse nomeVariavel = new NomeDaClasse();
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
if (opcaoDesejada == 3)
{
    // MenuDaClasse nomeVariavel = new NomeDaClasse();
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
if (opcaoDesejada == 4)
{
    // MenuDaClasse nomeVariavel = new NomeDaClasse();
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();
}