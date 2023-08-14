using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU; // игрок, компьютер
            int randomInt; // случайное число
            
            bool playAgain = true; // начать игру сначала

            while (playAgain)
            {

                int scorePlayer = 0; // счёт игрока
                int scoreCPU = 0; //счёт компьютера


                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("Выберите КАМЕНЬ, НОЖНИЦЫ или БУМАГА");
                    Console.Write("Игрок выбрал: ");
                    inputPlayer = Console.ReadLine(); //ввод игрока КАМЕНЬ, НОЖНИЦЫ или БУМАГА

                    Random rnd = new Random(); //объект случайных чисел

                    randomInt = rnd.Next(1,4); //генерация случайных чисел от 1 до 3


                    switch (randomInt) // выборка от 1 до 3 для компьютера 
                    {
                        case 1: // 
                            inputCPU = "КАМЕНЬ";
                            Console.WriteLine("Компьютер выбрал КАМЕНЬ");
                            if (inputPlayer == "КАМЕНЬ")
                            {
                                Console.WriteLine("Ничья!!!\n\n");
                            }
                            else if (inputPlayer == "БУМАГА")
                            {
                                Console.WriteLine("Выигрывает игрок!!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "НОЖНИЦЫ")
                            {
                                Console.WriteLine("Выигрывает компьютер!!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "НОЖНИЦЫ";
                            Console.WriteLine("Компьютер выбрал НОЖНИЦЫ");
                            if (inputPlayer == "НОЖНИЦЫ")
                            {
                                Console.WriteLine("Ничья!!!\n\n");
                            }
                            else if (inputPlayer == "КАМЕНЬ")
                            {
                                Console.WriteLine("Выигрывает игрок!!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "БУМАГА")
                            {
                                Console.WriteLine("Выигрывает компьютер!!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "БУМАГА";
                            Console.WriteLine("Компьютер выбрал БУМАГА");
                            if (inputPlayer == "БУМАГА")
                            {
                                Console.WriteLine("Ничья!!!\n\n");
                            }
                            else if (inputPlayer == "КАМЕНЬ")
                            {
                                Console.WriteLine("Выигрывает компьютер!!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "НОЖНИЦЫ")
                            {
                                Console.WriteLine("Выигрывает игрок!!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        default:
                            Console.WriteLine("Ошибка! Неверная запись.");
                            break;
                }

                Console.WriteLine("СЧЁТ:\tИГРОК:\t{0}\tКОМПЬЮТЕР:\t{1}\n\n\n",scorePlayer, scoreCPU);
            }

            if (scorePlayer == 3)
            {
                Console.WriteLine("3 раза выиграл игрок");
            }
            else if (scoreCPU == 3)
            {
                Console.WriteLine("3 раза выиграл компьютер");
            }
            else
            {

            }

            Console.WriteLine("Хотите начать игру снова?(y/n)");
            string loop = Console.ReadLine();
            if (loop == "y")
            {
                playAgain = true;
                Console.Clear();
            }
            else if (loop == "n")
            {
                playAgain = false;
            }
            else
            {
                
            }
            
            }
        }
    }
}
