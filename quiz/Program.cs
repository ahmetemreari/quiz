using System;

class Program
{
    static void Main()
    {
        int correctAnswers = 0;

        // Soru 1
        Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir?");
        Console.WriteLine("a) Lama");
        Console.WriteLine("b) Deve");
        string cevap1 = Console.ReadLine().Trim().ToLower();
        if (cevap1 == "a")
        {
            correctAnswers++;
            Console.WriteLine("Doğru!");
        }
        else
        {
            Console.WriteLine("Yanlış! Doğru cevap: a) Lama");
        }

        // Soru 2
        Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir?");
        Console.WriteLine("a) Venüs");
        Console.WriteLine("b) Mars");
        string cevap2 = Console.ReadLine().Trim().ToLower();
        if (cevap2 == "a")
        {
            correctAnswers++;
            Console.WriteLine("Doğru!");
        }
        else
        {
            Console.WriteLine("Yanlış! Doğru cevap: a) Venüs");
        }

        // Eğer ilk iki sorudan en az biri yanlışsa, üçüncü soruyu sormuyoruz
        if (correctAnswers < 2)
        {
            Console.WriteLine("Üzgünüz, büyük ödülü kazanma şansınız kalmadı.");
            return;
        }

        // Soru 3
        Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
        Console.WriteLine("a) 7");
        Console.WriteLine("b) 12");
        string cevap3 = Console.ReadLine().Trim().ToLower();
        if (cevap3 == "b")
        {
            correctAnswers++;
            Console.WriteLine("Doğru!");
        }
        else
        {
            Console.WriteLine("Yanlış! Doğru cevap: b) 12");
        }

        // Sonuç
        if (correctAnswers >= 2)
        {
            Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
        }
        else
        {
            Console.WriteLine("Üzgünüz, büyük ödülü kazanamadınız.");
        }
    }
}
