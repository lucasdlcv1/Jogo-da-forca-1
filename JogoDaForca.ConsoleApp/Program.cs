/*
Requisitos
1. Ao iniciar o jogo, deve ser selecionada uma palavra aleatória à partir de uma lista.
2. O jogador poderá chutar a palavra secreta letra por letra, cada letra certa deverá ser apresentada,
assim como as letras erradas.
3. O jogador poderá cometer até cinco erros, caso erre pela quinta vez, ou acerte a palavra a partida
acaba.
4. Deve-se apresentar um desenho da forca sendo atualizado a cada erro.
*/

using System.ComponentModel.Design;
using System.Security.Cryptography;

string[] palavras = {"ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA", "ABACATE", "BACABA", "BACURI", "BANANA", "CAJA", "CAJU", "CARAMBOLA", "CUPUACU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MACA", "MANGABA", "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA"};
int SeletorAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);
string PalavraSecreta = palavras[SeletorAleatorio];
char[] letrascorretas = new char[PalavraSecreta.Length];

int tentativas = 5;


for (int contadorletras = 0; contadorletras < PalavraSecreta.Length; contadorletras++)
{
    letrascorretas[contadorletras] = '_';
}

bool jogadorAcertou = false;

while(jogadorAcertou == false)

{
    Console.Clear();
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Jogo da Forca");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Tentativas: " + tentativas);

            if(tentativas == 5)
            {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |               ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
            }
            else if(tentativas == 4)
            {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |              ");
            Console.WriteLine(@" |               ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
            }
            else if(tentativas == 3)
            {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |         |       ");
            Console.WriteLine(@" |               ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
            }
            else if(tentativas == 2)
            {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |        /|\       ");
            Console.WriteLine(@" |                 ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
            }
            else if(tentativas == 1)
            {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |        /|\       ");
            Console.WriteLine(@" |        / \       ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
            }
            else if(tentativas == 0)
            {
            Console.WriteLine(@" ___________        ");
            Console.WriteLine(@" |/        |        ");
            Console.WriteLine(@" |         |        ");
            Console.WriteLine(@" |         o        ");
            Console.WriteLine(@" |        /|\       ");
            Console.WriteLine(@" |        / \       ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@" |                  ");
            Console.WriteLine(@"_|____              ");
            }


    Console.WriteLine("----------------------------------");
    for (int contadorletras = 0; contadorletras < PalavraSecreta.Length; contadorletras++)
    {
    Console.Write(letrascorretas[contadorletras]);
    }
    Console.WriteLine("\n----------------------------------\n");

    
    Console.WriteLine("Digite uma letra: ");
    string input = Console.ReadLine();

    char letra = char.ToUpper(input[0]);

    bool jogadorPontuou = false;
//Programa percorre a palavra secreta, verifica se o input da letra eh igual a palavra secreta e substitui o traco pela letra
    for(int contadorpalavrasec = 0; contadorpalavrasec < PalavraSecreta.Length; contadorpalavrasec++)
    {
        char letraSecretaAtual = PalavraSecreta[contadorpalavrasec];

        if (letra == letraSecretaAtual)
        {
            letrascorretas[contadorpalavrasec] = letra;
            jogadorPontuou=true;
        }
      
    }
    
    string letrascorretascompleta = string.Join("", letrascorretas);

    if (PalavraSecreta == letrascorretascompleta)
    {
        Console.WriteLine("\nParabéns, você ganhou! a palavra era: " + PalavraSecreta);
        Console.ReadLine();
        break;
    }

    if(jogadorPontuou == false)
    {
        tentativas--;
    }

    if (tentativas == 0)
    {
        Console.WriteLine("Suas tentativas acabaram!");
        Console.ReadLine();
        break;
    }

    Console.ReadLine();

}