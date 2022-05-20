using Entra21.Vetor;

var opcaoDesejada = 0;
Console.WriteLine(@"---------Menu--------------
1 - Exercício 01
2 - Exercício 02");
Console.Write("Digite a opção desejada: ");
opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01Sala exercicio01 = new Exercicio01Sala();
    exercicio01.Executar();
}
if (opcaoDesejada == 2)
{
    Exercicio02Sala exercicio02 = new Exercicio02Sala();
    exercicio02.Executar();
}