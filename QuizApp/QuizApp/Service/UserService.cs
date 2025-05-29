using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizApp.Models;

namespace QuizApp.Service
{
    public class UserService
    {
        private readonly string _path = "users.json";
        private List<User> _users;

        public UserService()
        {
            _users = FileStorage.Load<List<User>>(_path);
        }

        public User? Login(string username, string password)
        {
            return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public bool Register(string username, string password, DateTime birthDate)
        {
            if (_users.Any(u => u.Username == username)) 
                return false;

            _users.Add(new User
            {
                Username = username,
                Password = password,
                BirthDate = birthDate
            });
            Save();
            return true;
        }

        public void Update(User user)
        {
            var index = _users.FindIndex(u => u.Username == user.Username);
            if (index != -1)
            {
                _users[index] = user;
                Save();
            }
        }

        private void Save() => FileStorage.Save(_path, _users);
    }
}
