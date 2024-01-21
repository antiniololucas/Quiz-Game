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

        void GiveOptions(Questions item)
        {
            foreach (var (index, option) in item.crearOptions().Select((value, index) => (index, value)))
            {
                Console.WriteLine($"Opcion {index} : {option}");
            }
            ReadAnswer(item, item.crearOptions());
        }

        private void ReadAnswer(Questions item, List<string> options)
        {
            string resp = Console.ReadLine();
            while (!resp.Any(c => c == '0' || c == '1' || c == '2' || c == '3'))
            {
                Console.WriteLine("Formato incorrecto, vuelva a responder \n");
                resp = Console.ReadLine();
            }

            CheckAnswer(item, options[int.Parse(resp)]);
        }

        private void CheckAnswer(Questions item, string response)
        {
            if (item.correct_answer == response)
            {
                Console.WriteLine("Correcto, vamos con otra! \n");
                Score++;
            }
            else
            {
                Console.WriteLine($"Incorrecto, vamos con otra! \n La correcta era: {item.correct_answer}");
            }
        }

        private void EndGame()
        {
            Console.WriteLine($"\n\nFin del juego, tu puntaje fue : {Score}\n");
        }
    }
}

