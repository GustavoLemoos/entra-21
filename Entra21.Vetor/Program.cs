using Entra21.Vetor;

Console.WriteLine(@"---------Menu--------------
1 - Exercício 01 Sala
2 - Exercício 02 Sala
3 - Exercicio 01
4 - Exercicio 02
5 - Exercicio 03
6 - Exercicio 04
7 - Exercicio 05
8 - Exercicio 06
9 - Exercicio 07
10 - ExemploProfessor
11 - Exercicio 08
12 - Exercicio 09
13 - Exercicio 10
14 - Exercicio 11
15 - Exercicio 12
16 - Exercicio 13
17 - Exercicio 14
18 - Exercicio 15");
Console.Write("Digite a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

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
if (opcaoDesejada == 8)
{
    Exercicio06 exercicio06 = new Exercicio06();
    exercicio06.Executar();
}
if (opcaoDesejada == 9)
{
    Exercicio07 exercicio07 = new Exercicio07();
    exercicio07.Executar();
}
if (opcaoDesejada == 10)
{
    ExemploProfessor exercicioprofessor = new ExemploProfessor();
    exercicioprofessor.Executar();
}
if (opcaoDesejada == 11)
{
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();
}
if (opcaoDesejada == 12)
{
    Exercicio09 exercicio09 = new Exercicio09();
    exercicio09.Executar();
}
if (opcaoDesejada == 13)
{
    Exercicio10 exercicio10 = new Exercicio10();
    exercicio10.Executar();
}
if (opcaoDesejada == 14)
{
    Exercicio11 exercicio11 = new Exercicio11();
    exercicio11.Executar();
}
if (opcaoDesejada == 15)
{
    Exercicio12 exercicio12 = new Exercicio12();
    exercicio12.Executar();
}
if (opcaoDesejada == 16)
{
    Exercicio13 exercicio13 = new Exercicio13();
    exercicio13.Executar();
}
if (opcaoDesejada == 17)
{
    Exercicio14 exercicio14 = new Exercicio14();
    exercicio14.Executar();
}
if (opcaoDesejada == 18)
{
    Exercicio15 exercicio15 = new Exercicio15();
    exercicio15.Executar();
}
