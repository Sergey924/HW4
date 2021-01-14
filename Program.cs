using HW4.Задание_2;
using HW4.Задание_4;
using HW4.Задание_5;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1
            Calculator calculator = new Calculator();

            calculator.Add(1, 2);
            calculator.Subtract(3, 6);
            calculator.Multiplicat(2, 2);
            calculator.Division(5, 5);
            #endregion Задание 1

            #region Задание 2
            List<Car> car = new List<Car>()
            {
               new Car
               {
                   Brand = "BMW",
                   Model = "X5",
                   Colour = "Red",
                   Year = 2006
               },

               new Car
               {
                   Brand = "Mercedes",
                   Model = "W124",
                   Colour = "Black",
                   Year = 1996
               },

               new Car
               {
                   Brand = "Porsche",
                   Model = "997",
                   Colour = "Green",
                   Year = 2012
               }
            };

            List<Buyer> buyers = new List<Buyer>()
            {
                new Buyer
                {
                    Name = "Sergey",
                    Model = "X5",
                    NumPhone = 12414141
                }
            };

            var result1 = from Cars in car
                          join Buyers in buyers
                           on Cars.Model equals Buyers.Model
                          select new { Name = Buyers.Name, NumPhone = Buyers.NumPhone, Model = Cars.Model };

            foreach (var item in result1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Список покупателей:");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{item.Name} - {item.NumPhone} ({item.Model})");
                Console.ResetColor();
                Console.WriteLine();
            }
            #endregion Задание 2

            #region Задание 3
           /* Random rnd = new Random();

            int[] Numbers = new int[30];

            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = rnd.Next(-5000, 5000);
            }

            foreach (var item in Numbers.SkipWhile(x => x < 0))
            {
                Console.WriteLine("Первое положительное число");
                Console.WriteLine(item);

                foreach (var items in Numbers.SkipWhile(x => x > 0))
                {
                    Console.WriteLine("Первое отрицательное число");
                    Console.WriteLine(items);
                    return;
                }

            }*/

            #endregion Задание 3

            #region Задание 4
            Console.ForegroundColor = ConsoleColor.Yellow;
            List<Client> clients = new List<Client>()
            {
    
                new Client
                {
                    ID = 1,
                    Year = 2020,
                    Month_Num = 04,
                    TimeWork = 14124,
                },

                 new Client
                {
                    ID = 2,
                    Year = 2020,
                    Month_Num = 03,
                    TimeWork = 142,
                },

                  new Client
                {
                    ID = 3,
                    Year = 2020,
                    Month_Num = 10,
                    TimeWork = 5224,
                },

                   new Client
                {
                    ID = 4,
                    Year = 2021,
                    Month_Num = 01,
                    TimeWork = 24,
                },

                    new Client
                {
                    ID = 5,
                    Year = 2021,
                    Month_Num = 01,
                    TimeWork = 10,
                },
            };

            var result3 = from client in clients
                         orderby client.TimeWork ascending
                          select new {client.ID, client.Year, client.Month_Num, client.TimeWork };

            var first = result3.First();
            
            Console.WriteLine("Человек с наименьшим временем работы" + "\n" + first);
            Console.ResetColor();
            Console.WriteLine();
            #endregion Задание 4

            #region Задание 5
            List<VocabularyEng> vocabularyeng = new List<VocabularyEng>()
            {
                new VocabularyEng
                {   ID = 1,
                    Word = "Hello",
                },

                new VocabularyEng
                {   ID = 2,
                    Word = "Goodbye",
                },

                new VocabularyEng
                {   ID = 3,
                    Word = "How",
                },

                new VocabularyEng
                {   ID = 4,
                    Word = "When",
                },

                new VocabularyEng
                {   ID = 5,
                    Word = "Where",
                },

                new VocabularyEng
                {   ID = 6,
                    Word = "Large",
                },

                new VocabularyEng
                {   ID = 7,
                    Word = "Small",
                },

                new VocabularyEng
                {   ID = 8,
                    Word = "Red",
                },

                new VocabularyEng
                {   ID = 9,
                    Word = "Blue",
                },

                new VocabularyEng
                {   ID = 10,
                    Word = "Green",
                },
            };

            List<VocabularyRus> vocabularyrus = new List<VocabularyRus>()
            {
                new VocabularyRus
                {
                    ID = 1,
                    Word = "Привет",
                },

                 new VocabularyRus
                {
                    ID = 2,
                    Word = "Прощай",
                },

                  new VocabularyRus
                {
                    ID = 3,
                    Word = "Как",
                },

                   new VocabularyRus
                {
                    ID = 4,
                    Word = "Когда",
                },

                    new VocabularyRus
                {
                    ID = 5,
                    Word = "Где",
                },

                     new VocabularyRus
                {
                    ID = 6,
                    Word = "Большой",
                },

                      new VocabularyRus
                {
                    ID = 7,
                    Word = "Маленький",
                },

                       new VocabularyRus
                {
                    ID = 8 ,
                    Word = "Красный",
                },

                        new VocabularyRus
                {
                    ID = 9,
                    Word = "Синий",
                },

                         new VocabularyRus
                {
                    ID = 10,
                    Word = "Зелёный",
                },
            };

            Console.ForegroundColor = ConsoleColor.Cyan;
            var Vocabular = from WordEng in vocabularyeng
                            join WordRus in vocabularyrus
                            on WordEng.ID equals WordRus.ID
                            select new {Id = WordRus.ID, Word = WordEng.Word + " - " + WordRus.Word };

            foreach (var item in Vocabular)
            {
                Console.WriteLine(item);
            }
            Console.ResetColor();
            #endregion Задание 5

        }
    }
}
