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

string[] palavras = {"ABACATE", "ABACAXI", "ACEROLA", "AÇAÍ", "ARAÇÁ"};
int SeletorAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);
string PalavraSecreta = palavras[SeletorAleatorio];
char[] letrascorretas = new char[PalavraSecreta.Length];

for (int contadorletras = 0; contadorletras < PalavraSecreta.Length; contadorletras++)
{
    letrascorretas[contadorletras] = '_';
}

bool jogadorAcertou = false;

while(jogadorAcertou == false)

{
    Console.Clear();
    for (int contadorletras = 0; contadorletras < PalavraSecreta.Length; contadorletras++)
    {
    Console.Write(letrascorretas[contadorletras]);
    }

    Console.WriteLine();
    
    Console.WriteLine("Digite uma letra: ");
    string input = Console.ReadLine();

    char letra = char.ToUpper(input[0]);

    for(int contadorpalavrasec = 0; contadorpalavrasec < PalavraSecreta.Length; contadorpalavrasec++)
    {
        char letraSecretaAtual = PalavraSecreta[contadorpalavrasec];

        if (letra == letraSecretaAtual)
        {
            letrascorretas[contadorpalavrasec] = letra;
        }
    }
  

    Console.ReadLine();

}