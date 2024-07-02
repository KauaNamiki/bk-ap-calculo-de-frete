namespace JogoDaForca
{
    namespace JogoDaForca
    {
        internal class Program
        {
            public static void Main(string[] args)
            {
                string[] palavras = {
                "ABACATE", "ABACAXI", "ACEROLA", "AÇAI", "ARAÇA", "ABACATE",
                "BACABA", "BACURI", "BANANA", "CAJA", "CAJU", "CARAMBOLA",
                "CUPUACU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO",
                "MACA", "MANGABA", "MANGA", "MARACUJA", "MURICI", "PEQUI",
                "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA",
                "UVAIA"
            };

                Random random = new Random();
                string palavraSecreta = palavras[random.Next(palavras.Length)];

                char[] letrasCorretas = new char[palavraSecreta.Length];
                for (int i = 0; i < letrasCorretas.Length; i++)
                {
                    letrasCorretas[i] = '_';
                }

                List<char> letrasErradas = new List<char>();
                int tentativasErradas = 0;
                int maxTentativas = 5;

                while (tentativasErradas < maxTentativas && !letrasCorretas.SequenceEqual(palavraSecreta.ToCharArray()))
                {
                    Console.WriteLine("Palavra: " + new string(letrasCorretas));
                    Console.WriteLine("Letras erradas: " + string.Join(", ", letrasErradas));
                    Console.WriteLine("Tentativas restantes: " + (maxTentativas - tentativasErradas));

                    Console.Write("Digite uma letra: ");
                    char letra = Console.ReadLine().ToUpper()[0];

                    if (letrasCorretas.Contains(letra) || letrasErradas.Contains(letra))
                    {
                        Console.WriteLine("Você já adivinhou essa letra. Tente outra.");
                        continue;
                    }

                    if (palavraSecreta.Contains(letra))
                    {
                        for (int i = 0; i < palavraSecreta.Length; i++)
                        {
                            if (palavraSecreta[i] == letra)
                            {
                                letrasCorretas[i] = letra;
                            }
                        }
                    }
                    else
                    {
                        letrasErradas.Add(letra);
                        tentativasErradas++;
                    }
                }

                if (letrasCorretas.SequenceEqual(palavraSecreta.ToCharArray()))
                {
                    Console.WriteLine("Parabéns! Você adivinhou a palavra: " + palavraSecreta);
                }
                else
                {
                    Console.WriteLine("Você perdeu! A palavra era: " + palavraSecreta);
                }
            }
        }
    }
}