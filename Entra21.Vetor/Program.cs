using Entra21.Vetor;

var opcaoDesejada = 0;
Console.WriteLine(@"---------Menu--------------
1 - Exercício 01 Sala
2 - Exercício 02 Sala
3 - Exercicio 01
4 - Exercicio 02
5 - Exercicio 03
6 - Exercicio 04
7 - Exercicio 05
8 - Exercicio 06
9 - Exercicio 07");
Console.Write("Digite a opção desejada: ");
opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01Sala exercicio01Sala = new Exercicio01Sala();
    exercicio01Sala.Executar();
}
if (opcaoDesejada == 2)
{
    Exercicio02Sala exercicio02Sala = new Exercicio02Sala();
    exercicio02Sala.Executar();
}
if (opcaoDesejada == 3)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
if (opcaoDesejada == 4)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
if (opcaoDesejada == 5)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
if (opcaoDesejada == 6)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();
}
if (opcaoDesejada == 7)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
