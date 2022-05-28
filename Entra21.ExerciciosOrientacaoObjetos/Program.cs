using Entra21.ExerciciosOrientacaoObjetos.Exercicio01;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio04;

Console.WriteLine(@"Menu
1 - Exercício01
2 - Exercício02");
Console.Write("Digite a opção desejada: ");
var opcao = Convert.ToInt32(Console.ReadLine());

if (opcao == 1)
{
    ExemploLivro exemploLivro = new ExemploLivro();
    exemploLivro.Executar();
}
else if (opcao == 2)
{
    ExemploTemperatura exemploTemperatura = new ExemploTemperatura();
    exemploTemperatura.Executar();
}
//else if (opcao == 4)
//{
//    ExemploFarmacia exemploFarmacia = new ExemploFarmacia();
//    exemploFarmacia.Executar();
//}
