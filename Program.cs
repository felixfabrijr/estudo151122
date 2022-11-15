using System;

namespace TrabStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var paragrafo = "     C# linguagem moderna e versatil." +
                    "C# desenvole web, desktop, jogos, " +
                    "Mobile, entre outros. ";

            // Length
            var tamanho = paragrafo.Length;

            // Empty
            var vazio = string.Empty;

            // ToLower, ToUpper
            var paragrafoMinuscula = paragrafo.ToLower();
            var paragrafoMaiusculo = paragrafo.ToUpper();

            // Split
            var frases = paragrafo.Split('.');

            // Trim, TrimEnd, TrimStart
            var paragrafoTrim = paragrafo.Trim();
            var paragrafoTrimEnd = paragrafo.TrimEnd();
            var paragrafoTrimStart = paragrafo.TrimStart();

            // IsNullOrWhitespace
            var isNullOrwhiteSpace = string.IsNullOrWhiteSpace(paragrafo);

            // Replace
            var paragrafoCsharp = paragrafo.Replace("C#", "C-sharp");

            Console.ReadKey();

        }
    }
}
