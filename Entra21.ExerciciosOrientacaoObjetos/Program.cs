using Entra21.ExerciciosOrientacaoObjetos.Exercicio01;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio02;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio03;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio04;
using Entra21.ExerciciosOrientacaoObjetos.Exercicio05;

Console.WriteLine(@"Menu
1 - Exercício01
2 - Exercício02
3 - Exercício03
4 - Exercício04a
5 - Exercício05");
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
else if (opcao == 3)
{
    ExemploConversorAscii exemploConversorAscii = new ExemploConversorAscii();
    exemploConversorAscii.Executar();
}
//else if (opcao == 4)
//{
//    ExemploFarmacia exemploFarmacia = new ExemploFarmacia();
//    exemploFarmacia.Executar();
//}
//else if (opcao == 5)
//{
//    ExemploBoletim exemploBoletim = new ExemploBoletim();
//    exemploBoletim.Executar();
//}
