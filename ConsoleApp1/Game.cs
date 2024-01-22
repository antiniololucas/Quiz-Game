using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Game
    {
        int Score = 0;

        internal void ReadQuestions(FirstObject res)
        {
            foreach (var item in res.results)
            {
                Console.WriteLine($"-------------------------------------------Score: {Score} \n{item.question}");
                GiveOptions(item);
            }
            EndGame();
        }

        private void GiveOptions(Questions item)
        {
            foreach (var (index, option) in item.CreateOptions().Select((value, index) => (index, value)))
            {
                Console.WriteLine($"Opcion {index} : {option}");
            }
            ReadAnswer(item, item.CreateOptions());
        }

        private void ReadAnswer(Questions item, List<string> options)
        {
            CheckAnswer(item, options[int.Parse(CheckDigit(Console.ReadLine()))]);
        }

        private string CheckDigit(string resp)
        {
            if (resp == "0" || resp == "1" || resp == "2" || resp == "3")
            {
                return resp;
            }
            Console.WriteLine("¡Formato incorrecto! Vuelva a responder \n");
            resp = Console.ReadLine();
            return CheckDigit(resp);
        }

        private void CheckAnswer(Questions item, string response)
        {
            if (item.correct_answer == response)
            {
                Console.WriteLine("¡Correcto! ¡Vamos con otra! \n");
                Score++;
            }
            else
            {
                Console.WriteLine($"¡Incorrecto!, ¡Vamos con otra! \n La correcta era: {item.correct_answer}");
            }
        }

        private void EndGame()
        {
            Console.WriteLine($"\n\n!!!Fin del juego!!!!!, tu puntaje fue : {Score}\n");
            Console.ReadKey();
        }
    }
}

