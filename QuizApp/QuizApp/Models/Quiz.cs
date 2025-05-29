using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class Quiz
    {
        public string Category { get; set; }
        public List<Question> Questions { get; set; }
    }
}
