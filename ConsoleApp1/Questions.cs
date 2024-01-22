using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
    public class Questions
    {
        public string type { get; set; }
        public string difficulty { get; set; }
        public string category { get; set; }
        public string question { get; set; }
        public string correct_answer { get; set; }
        public List<string> incorrect_answers { get; set; }


        public List<string> CreateOptions()
        {
            List<string> options = new List<string>();
            options.Add(this.correct_answer);
            options.AddRange(this.incorrect_answers);
            //options = options.OrderBy(x => x.Length).ToList(); //Otra opcion
            options.Sort();//Para que no siempre la correcta sea la 1
            return options;
        }
    }
}
