using QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Service
{
    public class QuizService
    {
        private readonly string _path = "quizzes.json";
        private List<Quiz> _quizzes;
        private readonly Random _random = new();

        public QuizService()
        {
            _quizzes = FileStorage.Load<List<Quiz>>(_path);
        }

        public List<string> GetCategories() => _quizzes.Select(q => q.Category).Distinct().ToList();

        public Quiz GetQuiz(string category)
        {
            if (category.ToLower() == "mixed")
            {
                var mixedQuestions = _quizzes.SelectMany(q => q.Questions).OrderBy(_ => _random.Next()).Take(20).ToList();
                return new Quiz { Category = "Mixed", Questions = mixedQuestions };
            }
            return _quizzes.First(q => q.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        }
    }
}
