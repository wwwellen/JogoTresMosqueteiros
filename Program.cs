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

class RoletaDeDuelo
{
    private Random aleatorio;
    public RoletaDeDuelo(Random random) // construtor da RoletaDeDuelo
    {
        aleatorio = random;
    }
    public ResultadoDuelo Girar()
    {
        int resultado = aleatorio.Next(3); // 0, 1 ou 2
        switch (resultado)
        {
            case 0: return ResultadoDuelo.Vitoria; // indica que o jogador venceu
            case 1: return ResultadoDuelo.Empate; // indica que o jogo deu empate
            default: return ResultadoDuelo.Derrota; // indica que o jogador perdeu
        }
    }
}