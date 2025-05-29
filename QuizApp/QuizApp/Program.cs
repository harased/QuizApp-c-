using QuizApp.Models;
using QuizApp.Service;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        QuizSeeder.Seed();

        UserService userService = new();
        QuizService quizService = new();
        ResultService resultService = new();
        User? currentUser = null;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("0. Exit");
            Console.Write("Choose :: ");
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Username: ");
                string username = Console.ReadLine() ?? "";
                Console.Write("Password: ");
                string password = Console.ReadLine() ?? "";
                Console.Write("Birthdate (yyyy-mm-dd): ");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime birthdate))
                {
                    Console.WriteLine("Invalid date format.");
                    Console.ReadKey();
                    continue;
                }

                if (userService.Register(username, password, birthdate))
                    Console.WriteLine("Registered successfully!");
                else
                    Console.WriteLine("Username already exists.");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.Write("Username: ");
                string username = Console.ReadLine() ?? "";
                Console.Write("Password: ");
                string password = Console.ReadLine() ?? "";

                var user = userService.Login(username, password);
                if (user != null)
                {
                    currentUser = user;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid credentials.");
                    Console.ReadKey();
                }
            }
            else if (choice == "0")
            {
                return;
            }
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Welcome, {currentUser.Username}!");
            Console.WriteLine("1. Start Quiz");
            Console.WriteLine("2. My Results");
            Console.WriteLine("3. Top 20");
            Console.WriteLine("4. Settings");
            Console.WriteLine("0. Logout");
            Console.Write("Choose: ");
            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Available categories:");
                var categories = quizService.GetCategories();
                for (int i = 0; i < categories.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {categories[i]}");
                }
                Console.WriteLine($"{categories.Count + 1}. Mixed");
                Console.Write("Choose category: ");
                if (!int.TryParse(Console.ReadLine(), out int catIndex) || catIndex < 1 || catIndex > categories.Count + 1)
                {
                    Console.WriteLine("Invalid category.");
                    Console.ReadKey();
                    continue;
                }

                string selectedCategory = catIndex == categories.Count + 1 ? "mixed" : categories[catIndex - 1];
                var quiz = quizService.GetQuiz(selectedCategory);

                int score = 0;
                for (int i = 0; i < quiz.Questions.Count; i++)
                {
                    var q = quiz.Questions[i];
                    Console.Clear();
                    Console.WriteLine($"{i + 1}. {q.Text}");
                    for (int j = 0; j < q.Options.Count; j++)
                        Console.WriteLine($"{j + 1}) {q.Options[j]}");

                    Console.Write("Enter answer(s) (comma-separated): ");
                    var inputAns = Console.ReadLine()?.Split(',').Select(s =>
                    {
                        bool parsed = int.TryParse(s.Trim(), out int idx);
                        return parsed ? idx - 1 : -1;
                    }).Where(idx => idx >= 0).ToList() ?? new System.Collections.Generic.List<int>();

                    bool isCorrect = q.CorrectAnswers.OrderBy(x => x).SequenceEqual(inputAns.OrderBy(x => x));

                    if (isCorrect)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect.");
                        Console.Write("Correct answer(s): ");
                        var correctOptions = q.CorrectAnswers.Select(index => q.Options[index]);
                        Console.WriteLine(string.Join(", ", correctOptions));
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                Console.WriteLine($"You scored {score}/{quiz.Questions.Count}");
                resultService.SaveResult(new Result
                {
                    Username = currentUser.Username,
                    Category = quiz.Category,
                    Score = score,
                    Date = DateTime.Now
                });
                Console.ReadKey();
            }
            else if (input == "2")
            {
                var results = resultService.GetUserResults(currentUser.Username);
                if (results.Count == 0)
                    Console.WriteLine("No results yet.");
                else
                    foreach (var r in results)
                        Console.WriteLine($"{r.Date:d} - {r.Category} - {r.Score}/20");
                Console.ReadKey();
            }
            else if (input == "3")
            {
                Console.Write("Enter category: ");
                string cat = Console.ReadLine() ?? "";
                var top = resultService.GetTopResults(cat);
                if (top.Count == 0)
                    Console.WriteLine("No results for this category.");
                else
                    foreach (var r in top)
                        Console.WriteLine($"{r.Username} - {r.Score}/20 on {r.Date:d}");
                Console.ReadKey();
            }
            else if (input == "4")
            {
                Console.WriteLine("1. Change Password");
                Console.WriteLine("2. Change Birthdate");
                var opt = Console.ReadLine();

                if (opt == "1")
                {
                    Console.Write("New Password: ");
                    currentUser.Password = Console.ReadLine() ?? currentUser.Password;
                }
                else if (opt == "2")
                {
                    Console.Write("New Birthdate (yyyy-mm-dd): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime newBirthdate))
                        currentUser.BirthDate = newBirthdate;
                    else
                        Console.WriteLine("Invalid date format.");
                }
                userService.Update(currentUser);
                Console.WriteLine("Updated successfully.");
                Console.ReadKey();
            }
            else if (input == "0")
            {
                currentUser = null;
                break;
            }
        }
    }
}