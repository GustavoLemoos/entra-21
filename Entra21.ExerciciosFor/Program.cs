using Entra21.ExerciciosFor;

var opcaoDesejada = 0;
Console.WriteLine(@"---------Menu--------------
1 - Exercício 01
2 - Exercício 02");
Console.WriteLine("Digite a opção desejada: ");
opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    // MenuDaClasse nomeVariavel = new NomeDaClasse();
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}