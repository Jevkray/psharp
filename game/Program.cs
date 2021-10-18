using System;
using System.Threading;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
///Метка на переход
Start:
///Метка на переход
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите число от 1 до 100, это число будут отгадывать\n");
                var StartUnknownNumber = Console.ReadLine();

                int num;   //num - простое int                                  // Проверка -         (1)
                bool isNum = int.TryParse(StartUnknownNumber, out num);         // является
                if (isNum)                                                      // ли
                {                                                               // вводимое
                }                                                               // значение
                else                                                            // числом,
                {                                                               // а также,
                    Console.Clear();                                            // не равно
                    Console.WriteLine("Проверьте введённые данные\n");          // ли
                    Thread.Sleep(1300);                                         // оно   
                    Console.Clear();                                            // нулю
                    continue;                                                   //
                }                                                               //

                int Unknown_Number = int.Parse(StartUnknownNumber);             // Проверка           (2)
                if (Unknown_Number < 1 || Unknown_Number > 100)                 // диапазона
                {                                                               // вводимого
                    Console.Clear();                                            // числа
                    Console.WriteLine("Проверьте введённые данные\n");          //
                    Thread.Sleep(1300);                                         //
                    Console.Clear();                                            //
                    continue;                                                   //
                }                                                               //



                {
                    Console.Clear();

                    int attemps = 7;

///Метка на переход  
Mid:
///Метка на переход 

                    for (int i = 0; i < attemps;)
                    {
                        Console.WriteLine($"Колличестко оставшихся попыток: {attemps - i}  \n");
                        Console.WriteLine("Введите число от 1 до 100\n");
                        var StartNumber = Console.ReadLine();

                        bool isNum_inFunc = int.TryParse(StartNumber, out num);//(1)
                        if (isNum_inFunc)
                        {
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Проверьте введённые данные\n");
                            Thread.Sleep(1300);
                            Console.Clear();
                            continue;
                        }                                                       

                        int Number = int.Parse(StartNumber);                   //(2)
                        if (Number < 1 || Number > 100)
                        {
                            Console.Clear();
                            Console.WriteLine("Проверьте введённые данные\n");
                            Thread.Sleep(1300);
                            Console.Clear();
                            continue;
                        }                                                      
                        if (Number < Unknown_Number)                           // Проверка расположения вводимого числа
                        {
                            Console.Clear();
                            Console.WriteLine($"Число {Number} меньше загаданного\n");
                            i++;
                        }
                        if (Number > Unknown_Number)
                        {
                            Console.Clear();
                            Console.WriteLine($"Число {Number} больше загаданного\n");
                            i++;
                        }
                        if (Number == Unknown_Number)
                        {
                            Console.Clear();
                            Console.WriteLine($"Вы отгадали загаданное число, поздравляем !\n\nЗагаданное число - {Unknown_Number}");
                            return;
                        }
                    }

//Метка не переход
End:
//Метка не переход

                    Console.Clear();
                    Console.WriteLine("Попытки закончились, а вы так и не смогли отгадать число :(\n\n" +
                        "Желаете начать заного?\n\n" +
                        "Введите 1 - если желаете начать заново, с новым числом\n" +
                        "Введите 2 - если желаете отгадать старое число\n" +
                        "Введите 3 - если хотите завершить программу");

                    var choice1 = Console.ReadLine();

                    bool isNum_inChoice = int.TryParse(choice1, out num);
                    if (isNum_inChoice)
                    {
                    }
                    else
                    {
                        Console.Clear();                                        //(1)
                        Console.WriteLine("Проверьте введённые данные\n");
                        Thread.Sleep(1300);
                        Console.Clear();
                        goto End;
                    }

                    int choice = int.Parse(choice1);                            //(2)
                    if (choice < 1 || choice > 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Проверьте введённые данные\n");
                        Thread.Sleep(1300);
                        Console.Clear();
                        goto End;
                    }


                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            goto Start;

                        case 2:
                            Console.Clear();
                            goto Mid;

                        case 3:
                            return;

                    }
                }
            }
        }
    }
}

