using QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Service
{
    public class ResultService
    {
        private readonly string _path = "results.json";
        private List<Result> _results;

        public ResultService()
        {
            _results = FileStorage.Load<List<Result>>(_path);
        }

        public void SaveResult(Result result)
        {
            _results.Add(result);
            FileStorage.Save(_path, _results);
        }

        public List<Result> GetUserResults(string username)
        {
            return _results.Where(r => r.Username == username).OrderByDescending(r => r.Date).ToList();
        }

        public List<Result> GetTopResults(string category)
        {
            return _results.Where(r => r.Category == category)
                            .OrderByDescending(r => r.Score)
                            .Take(20)
                            .ToList();
        }
    }
}
