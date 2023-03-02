int candidato1 = 0;
int candidato2 = 0;
int candidato3 = 0;
int candidato4 = 0;
int total = 0;
int voto = 0;
int controle;
total = 0;

while (voto != 5)
{
    Console.Clear();
    Console.WriteLine("===========================================================");
    Console.WriteLine("============= Urna Eleitoral do Bostil 2023 ===============");
    Console.WriteLine("===========================================================");
    Console.WriteLine("=                                                         =");
    Console.WriteLine("=         Digite 1 para votar em: Ednaldo Pereira         =");
    Console.WriteLine("=         Digite 2 para votar em: Manoel Gomes            =");
    Console.WriteLine("=         Digite 3 para votar em: Tiringa                 =");
    Console.WriteLine("=         Digite 4 para votar em: Aristeu                 =");
    Console.WriteLine("=                                                         =");
    Console.WriteLine("=         Digite 5 para finalizar a votação               =");
    Console.WriteLine("=                                                         =");
    Console.WriteLine("===========================================================");
    Console.WriteLine();
    Console.WriteLine("Digite o candidato escolhido (ou 5 para encerrar a votação)");
    voto = int.Parse(Console.ReadLine());

    switch (voto)
    {
        case 1:
            candidato1++;
            break;

        case 2:
            candidato2++;
            break;

        case 3:
            candidato3++;
            break;

        case 4:
            candidato4++;
            break;

        case 5:
            total = candidato1 + candidato2 + candidato3 + candidato4;
            Console.Clear();
            Console.WriteLine("===============================================================");
            Console.WriteLine("=               Urna Eleitoral do Bostil 2023                 =");
            Console.WriteLine("=                                                             =");
            Console.WriteLine("=                     VOTAÇÃO ENCERRADA!                      =");
            Console.WriteLine("=         Pressione qualquer tecla para continuar...          =");
            Console.WriteLine("=                                                             =");
            Console.WriteLine("===============================================================");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

Console.Clear();
Console.WriteLine("===============================================================");
Console.WriteLine("=               Urna Eleitoral do Bostil 2023                 =");
Console.WriteLine("=                                                             =");
Console.WriteLine("=                  Resultado da votação !                     =");
Console.WriteLine("=                                                             =");
Console.WriteLine("===============================================================");
Console.WriteLine("");
Console.WriteLine("Total de votos (Geral): " + total);
Console.WriteLine("> Votos (Ednaldo Pereira) " + candidato1);
Console.WriteLine("> Votos (Manoel Gomes) " + candidato2);
Console.WriteLine("> Votos (Tiringa) " + candidato3);
Console.WriteLine("> Votos (Aristeu) " + candidato4);
Console.WriteLine();
Console.WriteLine("> % de votos (Ednaldo Pereira): " + (candidato1 * 100) / total + "%");
Console.WriteLine("> % de votos (Manoel Gomes): " + (candidato2 * 100) / total + "%");
Console.WriteLine("> % de votos (Tiringa): " + (candidato3 * 100) / total + "%");
Console.WriteLine("> % de votos (Aristeu): " + (candidato4 * 100) / total + "%");
Console.WriteLine();