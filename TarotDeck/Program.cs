using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<(string, string)> cartasTarot = new List<(string, string)>()
        {
            ("O Louco", "Novos começos, aventura, impulsividade"),
            ("O Mago", "Manifestação, recursos, poder pessoal"),
            ("A Sacerdotisa", "Intuição, mistério, inconsciente"),
            ("A Imperatriz", "Fertilidade, nutrição, abundância"),
            ("O Imperador", "Autoridade, estabilidade, estrutura"),
            ("O Hierofante", "Tradição, ensinamento, conformidade"),
            ("Os Amantes", "Escolhas, relações, dualidade"),
            ("O Carro", "Direção, controle, avanço"),
            ("A Justiça", "Equilíbrio, justiça, discernimento"),
            ("O Eremita", "Solidão, introspecção, sabedoria"),
            ("A Roda da Fortuna", "Sorte, destino, ciclos"),
            ("A Força", "Coragem, força interior, dominação"),
            ("O Enforcado", "Sacrifício, suspensão, aceitação"),
            ("A Morte", "Fim, transformação, renascimento"),
            ("A Temperança", "Equilíbrio, moderação, harmonia"),
            ("O Diabo", "Ilusão, materialismo, tentação"),
            ("A Torre", "Desastre, mudança, libertação"),
            ("A Estrela", "Esperança, inspiração, otimismo"),
            ("A Lua", "Ilusão, confusão, medo"),
            ("O Sol", "Felicidade, sucesso, vitalidade"),
            ("O Julgamento", "Renovação, avaliação, julgamento"),
            ("O Mundo", "Completude, realização, sucesso")
        };

        Random random = new Random();


        List<(string, string)> cartasTiradas = new List<(string, string)>();
        for (int i = 0; i < 3; i++)
        {
            int indiceCarta = random.Next(cartasTarot.Count);
            var carta = cartasTarot[indiceCarta];
            cartasTiradas.Add(carta);
            cartasTarot.RemoveAt(indiceCarta); 
        }

        
        Console.WriteLine("Suas cartas de tarot são:");
        foreach (var carta in cartasTiradas)
        {
            Console.WriteLine($"{carta.Item1}: {carta.Item2}");
        }
    }
}
