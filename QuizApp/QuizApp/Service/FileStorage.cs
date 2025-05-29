using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuizApp.Service
{
    public static class FileStorage
    {
        public static T Load<T>(string path) where T : new()
        {
            if (!File.Exists(path)) return new T();

            try
            {
                var json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<T>(json) ?? new T();
            }
            catch
            {
                return new T();
            }
        }

        public static void Save<T>(string path, T data)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(data, options);
            File.WriteAllText(path, json);
        }
    }
}
