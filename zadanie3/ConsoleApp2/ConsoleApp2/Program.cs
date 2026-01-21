using System;

public class Quest
{
    public string Npc { get; set; }
    public string Goal { get; set; }
    public string Place { get; set; }
    public int Difficulty { get; set; }
    public int Reward { get; set; }

    public Quest(string npc, string goal, string place, int difficulty)
    {
        Npc = npc;
        Goal = goal;
        Place = place;
        Difficulty = difficulty;
        Reward = difficulty * 100; 
    }
    
    public void GenerateStepsRecursively(int step = 1)
    {
        if (step > Difficulty) return; 

        if (step % 2 != 0)
            Console.WriteLine($"Krok {step}: Idź {Place} i rozejrzyj się.");
        else
            Console.WriteLine($"Krok {step}: Zrób akcję: szukaj / walcz / zbierz.");
        
        GenerateStepsRecursively(step + 1);
    }
    
    public void PrintQuest()
    {
        Console.WriteLine($"QUEST: {Npc} {Goal} {Place}.");
        Console.WriteLine("Kroki:");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] NPC = { "Wieśniak", "Rycerz", "Czarodziej" };
        string[] CEL = { "zgubił miecz", "potrzebuje ziół", "szuka mapy" };
        string[] MIEJSCE = { "w lesie", "w jaskini", "na bagnach" };

        Random rand = new Random();
        string npc = NPC[rand.Next(NPC.Length)];
        string goal = CEL[rand.Next(CEL.Length)];
        string place = MIEJSCE[rand.Next(MIEJSCE.Length)];

        int difficulty = 0;
        while (difficulty < 1 || difficulty > 5)
        {
            Console.WriteLine("Podaj trudność questa (1-5): ");
            if (!int.TryParse(Console.ReadLine(), out difficulty) || difficulty < 1 || difficulty > 5)
            {
                Console.WriteLine("Błędna trudność. Wprowadź liczbę od 1 do 5.");
            }
        }

        Quest quest = new Quest(npc, goal, place, difficulty);

        quest.PrintQuest();
        quest.GenerateStepsRecursively();
    }

}