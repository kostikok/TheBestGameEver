namespace TheBestGameEver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы проснулись в комнате, но не можете вспомнить имя, ты оглядываешься и видишь несколько объектов которые можно исследовать");
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            int count = 0;
            int lockpick = 0;
            int bed = 0;
            int key = 0;
            int punch = 0;
            int table = 0;
        Savepoint:
            Console.WriteLine("Куда пойдём?");
            Console.WriteLine("1. Открыть дверь");
            Console.WriteLine("2. Заглянуть под кровать");
            Console.WriteLine("3. Открыть ящик в углу комнаты");
            Console.WriteLine("4. Открыть вентиляцию");
            Console.WriteLine("5. Взглянуть на тумбочку");
            Console.WriteLine("6. Взглянуть на статую рядом с дверью");
            Console.WriteLine(" ");
            string action = Console.ReadLine();
            if (action == "1")
            {
                if (lockpick == 0)
                {
                    Console.WriteLine("Дверь заперта");
                    Console.WriteLine(" ");
                    goto Savepoint;
                }
                else
                {
                    Console.WriteLine("Вы сбежали");
                    Console.WriteLine(" ");
                }
            }
            else if (action == "2")
            {
                if (bed == 0)
                {
                    Console.WriteLine("Вы находите под кроватью артефакт");
                    Console.WriteLine(" ");
                    bed = 1;
                    count = count + 1;
                    goto Savepoint;
                }
                else
                {
                    Console.WriteLine("Вы уже заглядывали сюда");
                    Console.WriteLine(" ");
                    goto Savepoint;
                }
            }
            else if (action == "3")
            {
                if (key == 1 & lockpick == 0)
                {
                    Console.WriteLine("Открыв ящик, вы находите отмычку");
                    Console.WriteLine(" ");
                    lockpick = 1;
                    goto Savepoint;
                }
                else
                {
                    Console.WriteLine("Ящик закрыт на замок");
                    Console.WriteLine(" ");
                    goto Savepoint;
                }
            }
            else if (action == "4")
            {
            Savepoint1:
                if (punch == 3)
                {
                    Console.WriteLine("Вентиляция сломалась и в ней вы находите артефакт");
                    Console.WriteLine(" ");
                    count = count+ 1;
                    goto Savepoint;
                }
                else
                {
                    Console.WriteLine("Вы видите хлипкую ветиляцию, попробовать её открыть?(Да/Нет)");
                    Console.WriteLine(" ");
                    string choice = Console.ReadLine();
                    if (choice == "Да" | choice == "да")
                    {
                        Console.WriteLine("Вы пытаетесь сломать вентиляцию");
                        Console.WriteLine(" ");
                        punch++;
                        goto Savepoint1;
                    }
                    else
                    {
                        goto Savepoint;
                    }
                }

            }
            else if (action == "5")
            {
                if (table == 0)
                {
                    Console.WriteLine("Вы находите на тумбочке артефакт");
                    Console.WriteLine(" ");
                    table = 1;
                    count = count+ 1;
                    goto Savepoint;
                }
                else
                {
                    Console.WriteLine("Вы уже заглядывали сюда");
                    Console.WriteLine(" ");
                    goto Savepoint;
                }

            }
            else if (action == "6")
            {
                if (count == 3 & key == 0) 
                {
                    Console.WriteLine("Вставив все артефакты в пазы, статуя отворяется, и внутри вы находите ключ");
                    Console.WriteLine(" ");
                    key = 1;
                    goto Savepoint;
                }
                else
                {
                    Console.WriteLine("Вы видите статую с тремя пазами для чего-то");
                    Console.WriteLine(" ");
                    goto Savepoint;
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
                goto Savepoint;
            }
        }
    }
}