using System;

namespace Dedok
{
  
    public enum marasm
    {
        Низкий,
        Средний,
        Высокий
    }

  
    public struct Ded
    {
        public string Name;
        public marasm Level;
        public string[] Phrases;
        public int Bruises;

       
        public Ded(string name, marasm level, string[] phrases)
        {
            Name = name;
            Level = level;
            Phrases = phrases;
            Bruises = 0; 
        }

       
        public int CheckForSwearWords(params string[] swearWords)
        {
            foreach (var phrase in Phrases)
            {
                foreach (var swearWord in swearWords)
                {
                    if (phrase.Contains(swearWord, StringComparison.OrdinalIgnoreCase))
                    {
                        Bruises++; 
                    }
                }
            }
            return Bruises; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем 5 дедов с разными фразами
            Ded ded1 = new Ded("Деда Вениамин", marasm.Низкий, new string[] { "Гадиина подлюючая! Утырок то какой...", "Ну а какое качество сейчас?? КАКОЕ?!" });
            Ded ded2 = new Ded("Дед Прохор", marasm.Средний, new string[] { "Проститутки!", "Корсар мой тащи, бабзда бестолковая!" });
            Ded ded3 = new Ded("Дед Жиря", marasm.Высокий, new string[] { "ВОН, ПОДЛОСТЬ, ГАДОСТЬ, ПРЕСТУПНИКИ!!! НЕНАВИЖУ ВАС!", "ПРОПАДИТЕ ПРОПАДОМ!", "Проститутки!" });
            Ded ded4 = new Ded("Бизубый", marasm.Низкий, new string[] { "Я сейчас тебе в рот плюну, утырок!" });
            Ded ded5 = new Ded("Лысый плешь", marasm.Средний, new string[] { "Прохор еще раз повторяю, тварь ты безмозглая...МОРДУ ЖИРНУЮ СНЕСУ!", "РОТ ЗАМОЛЧИ!" });

            // Список матерных слов
            string[] swearWords = { "проститутки", "гад", "ПОДЛОСТЬ", "тварь", "утырок", "безмозглая"};

            // Проверяем каждого деда на матерные слова и выводим результат
            Console.WriteLine($"{ded1.Name} получил {ded1.CheckForSwearWords(swearWords)} синяков.");
            Console.WriteLine($"{ded2.Name} получил {ded2.CheckForSwearWords(swearWords)} синяков.");
            Console.WriteLine($"{ded3.Name} получил {ded3.CheckForSwearWords(swearWords)} синяков.");
            Console.WriteLine($"{ded4.Name} получил {ded4.CheckForSwearWords(swearWords)} синяков.");
            Console.WriteLine($"{ded5.Name} получил {ded5.CheckForSwearWords(swearWords)} синяков.");
        }
    }
}
