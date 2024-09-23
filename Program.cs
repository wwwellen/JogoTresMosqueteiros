using System;
using System.Collections.Generic;
using System.Linq;

class Program // classe principal do programa
{
    private static readonly Random globalRandom = new Random(); // criando um objeto random estático para gerar números aléatorios
    static void Main (string[] args) // criando um método estático main, sendo ele o ponto de partida do programa
    {
        Jogo jogo = new Jogo(globalRandom); // criando uma instância do jogo que inicia ele
        jogo.IniciarJogo();
    }
}