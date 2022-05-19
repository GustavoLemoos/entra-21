using Entra21.Vetor;

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
    Exercicio01Sala exercicio01 = new Exercicio01Sala();
    exercicio01.Executar();
}
