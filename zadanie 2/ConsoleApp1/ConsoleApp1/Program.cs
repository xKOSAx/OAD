using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string inputPath = "ranking_raw.txt";
        string outputPath = "ranking_clean.txt";

        List<string> lines = new List<string>();

        if (!File.Exists(inputPath))
        {
            Console.WriteLine($"Brak pliku {inputPath} w katalogu uruchomieniowym!");
            return;
        }

        lines.AddRange(File.ReadAllLines(inputPath));

        if (lines.Count == 0)
        {
            Console.WriteLine("Plik jest pusty.");
            return;
        }

        List<string> clean = new List<string>();

        string header = lines[0];
        clean.Add(header);

        for (int i = 1; i < lines.Count; i++)
        {
            string line = lines[i];

            if (string.IsNullOrWhiteSpace(line))
                continue;

            string[] pola = line.Split(';');

            if (pola.Length != 5)
                continue;

            string nick = pola[0];
            string czas = pola[1];
            string punktyStr = pola[2];
            string status = pola[3];
            string opis = pola[4];

            int punkty;
            if (!int.TryParse(punktyStr, out punkty))
            {
                punkty = 0; 
            }

            bool hacker =
                status.ToUpper() == "HACKER" ||
                czas == "00:00:01" ||
                czas == "0:00:01";

            if (hacker)
            {
                continue;
            }

            string newLine = $"{nick};{czas};{punkty};{status};{opis}";
            clean.Add(newLine);
        }

        File.WriteAllLines(outputPath, clean);
   
        Console.WriteLine("=== NOWY RANKING ===");
        foreach (var line in clean)
            Console.WriteLine(line);
    }
}
