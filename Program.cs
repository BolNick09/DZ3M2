namespace DZ3M2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Перевод из систем исчисления");
            Console.WriteLine("Выберите направление перевода:");
            Console.WriteLine("1. Десятичная -> Двоичная");
            Console.WriteLine("2. Двоичная -> Десятичная");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Введите число в исходной системе исчисления: ");
            string number = Console.ReadLine();

            int result;
            switch (choice)
            {
                case 1:
                    try
                    {
                        result = Convert.ToInt32(number, 10); // Десятичная -> Двоичная
                        Console.WriteLine($"Двоичное представление: {Convert.ToString(result, 2)}");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Число выходит за пределы диапазона int.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неправильный ввод.");
                    }
                    break;

                case 2:
                    try
                    {
                        result = Convert.ToInt32(number, 2); // Двоичная -> Десятичная
                        Console.WriteLine($"Десятичное представление: {result}");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Число выходит за пределы диапазона int.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неправильный ввод.");
                    }
                    break;

                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            */

            /*
            Console.WriteLine("Слово в цифру");
            Dictionary<string, int> numberWords = new Dictionary<string, int>()
            {
                { "zero", 0 },
                { "one", 1 },
                { "two", 2 },
                { "three", 3 },
                { "four", 4 },
                { "five", 5 },
                { "six", 6 },
                { "seven", 7 },
                { "eight", 8 },
                { "nine", 9 }
            };

            Console.Write("Введите цифру словами: ");
            string input = Console.ReadLine().ToLower();

            int num1;
            if (numberWords.TryGetValue(input, out num1))            
                Console.WriteLine($"Цифра: {num1}");            
            else            
                Console.WriteLine("Неверный ввод.");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            */
            /*
            Console.WriteLine("Загран паспорт");
            try
            {
                // Создать заграничный паспорт
                ForeignPassport passport = new ForeignPassport("RU12345678", "Иванов Иван Иванович", new DateTime(2023, 1, 1));

                // Вывести информацию о паспорте
                Console.WriteLine($"Номер паспорта: {passport.Number}");
                Console.WriteLine($"ФИО владельца: {passport.FullName}");
                Console.WriteLine($"Дата выдачи: {passport.IssueDate}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            */
            try
            {
                Console.Write("Введите логическое выражение (например, 3>2 или 7<3): ");
                string input = Console.ReadLine();

                // Разделение входной строки на операнды и операцию
                string[] strChars = input.Split(new char[] { '<', '>', '=', '!' }, StringSplitOptions.RemoveEmptyEntries);
                int operand1 = int.Parse(strChars[0]);
                int operand2 = int.Parse(strChars[1]);

                // Определение оператора
                string operationString = input.Substring(strChars[0].Length, 2);

                // Вычисление и вывод результата
                bool result = operationString switch
                {
                    "<" => operand1 < operand2,
                    ">" => operand1 > operand2,
                    "<=" => operand1 <= operand2,
                    ">=" => operand1 >= operand2,
                    "==" => operand1 == operand2,
                    "!=" => operand1 != operand2,
                    _ => throw new ArgumentException("Некорректный оператор"),
                };

                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

    
    }
}
