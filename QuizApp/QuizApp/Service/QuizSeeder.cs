using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizApp.Models;
using System.Text.Json;

namespace QuizApp.Service
{
    public static class QuizSeeder
    {
        private const string QuizFilePath = "quizzes.json";

        public static void Seed()
        {
            if (File.Exists(QuizFilePath)) return;

            var quizzes = new List<Quiz>
            {
            new Quiz
            {
                Category = "History",
                Questions = new List<Question>
                {
                        new Question
                        {
                            Text = "When did World War II end?",
                            Options = new List<string> { "1945", "1939", "1918", "1963" },
                            CorrectAnswers = new List<int> { 0 }
                        },
                        new Question
                        {
                            Text = "Who was the first President of the United States?",
                            Options = new List<string> { "George Washington", "Abraham Lincoln", "Thomas Jefferson", "John Adams" },
                            CorrectAnswers = new List<int> { 0 }
                        },
                        new Question
                        {
                            Text = "Which civilizations built pyramids?",
                            Options = new List<string> { "Egyptians", "Mayans", "Romans", "Greeks" },
                            CorrectAnswers = new List<int> { 0, 1 }
                        },
                        new Question
                        {
                            Text = "What year did the Berlin Wall fall?",
                            Options = new List<string> { "1989", "1991", "1975", "1961" },
                            CorrectAnswers = new List<int> { 0 }
                        },
                        new Question
                        {
                            Text = "Who led the Soviet Union during World War II?",
                            Options = new List<string> { "Joseph Stalin", "Vladimir Lenin", "Leon Trotsky", "Nikita Khrushchev" },
                            CorrectAnswers = new List<int> { 0 }
                        },
                        new Question
                        {
                            Text = "Which countries were part of the Axis powers in WWII?",
                            Options = new List<string> { "Germany", "Italy", "United Kingdom", "Japan" },
                            CorrectAnswers = new List<int> { 0, 1, 3 }
                        },
                        new Question
                        {
                            Text = "What ancient civilization invented democracy?",
                            Options = new List<string> { "Romans", "Greeks", "Egyptians", "Persians" },
                            CorrectAnswers = new List<int> { 1 }
                        },
                        new Question
                        {
                            Text = "In what year did the American Civil War begin?",
                            Options = new List<string> { "1861", "1776", "1812", "1865" },
                            CorrectAnswers = new List<int> { 0 }
                        },
                        new Question
                        {
                            Text = "Who was Napoleon Bonaparte?",
                            Options = new List<string> { "French Emperor", "Italian King", "Spanish General", "Russian Tsar" },
                            CorrectAnswers = new List<int> { 0 }
                        },
                        new Question
                        {
                            Text = "Which war was fought between the North and South regions in the USA?",
                            Options = new List<string> { "World War I", "American Civil War", "Vietnam War", "Revolutionary War" },
                            CorrectAnswers = new List<int> { 1 }
                        },
                        new Question
                        {
                            Text = "Which empires existed in South America before European colonization?",
                            Options = new List<string> { "Inca", "Aztec", "Mayan", "Mongol" },
                            CorrectAnswers = new List<int> { 0, 1, 2 }
                        },
                        new Question
                        {
                            Text = "When did the French Revolution begin?",
                            Options = new List<string> { "1789", "1804", "1776", "1815" },
                            CorrectAnswers = new List<int> { 0 }
                        },
                        new Question
                        {
                            Text = "Which countries were part of the Allied Powers during WWII?",
                            Options = new List<string> { "United Kingdom", "Germany", "Soviet Union", "USA" },
                            CorrectAnswers = new List<int> { 0, 2, 3 }
                        },
                        new Question
                        {
                            Text = "Who was the leader of the civil rights movement in the USA?",
                            Options = new List<string> { "Martin Luther King Jr.", "Malcolm X", "Nelson Mandela", "Barack Obama" },
                            CorrectAnswers = new List<int> { 0 }
                        },
                        new Question
                        {
                            Text = "What was the primary cause of the Cold War?",
                            Options = new List<string> { "Ideological conflict between USA and USSR", "World War I", "Colonial rivalry", "Space Race" },
                            CorrectAnswers = new List<int> { 0 }
                        },
                        new Question
                        {
                            Text = "Which historical documents influenced modern democracy?",
                            Options = new List<string> { "Magna Carta", "Declaration of Independence", "Code of Hammurabi", "UN Charter" },
                            CorrectAnswers = new List<int> { 0, 1, 3 }
                        },
                        new Question
                        {
                            Text = "Who was Cleopatra?",
                            Options = new List<string> { "Queen of Egypt", "Roman Senator", "Greek Goddess", "Mesopotamian Ruler" },
                            CorrectAnswers = new List<int> { 0 }
                        },
                        new Question
                        {
                            Text = "What empire was ruled by Genghis Khan?",
                            Options = new List<string> { "Ottoman Empire", "Mongol Empire", "Persian Empire", "Chinese Empire" },
                            CorrectAnswers = new List<int> { 1 }
                        },
                        new Question
                        {
                            Text = "What triggered the start of World War II?",
                            Options = new List<string> { "Germany invaded Poland", "Assassination of Archduke", "Attack on Pearl Harbor", "Fall of France" },
                            CorrectAnswers = new List<int> { 0 }
                        },
                        new Question
                        {
                            Text = "What were major inventions of the Industrial Revolution?",
                            Options = new List<string> { "Steam engine", "Printing press", "Spinning jenny", "Electric light" },
                            CorrectAnswers = new List<int> { 0, 2, 3 }
                        }

                }
            },
            new Quiz
            {
                Category = "Geography",
                Questions = new List<Question>
                {
                    new Question
                    {
                        Text = "What is the capital of France?",
                        Options = new List<string> { "Paris", "London", "Berlin", "Madrid" },
                        CorrectAnswers = new List<int> { 0 }
                    },
                    new Question
                    {
                        Text = "Which river runs through Egypt?",
                        Options = new List<string> { "Nile", "Amazon", "Danube", "Mississippi" },
                        CorrectAnswers = new List<int> { 0 }
                    },
                    new Question
                    {
                        Text = "Which continents does the equator pass through?",
                        Options = new List<string> { "South America", "Africa", "Asia", "Australia" },
                        CorrectAnswers = new List<int> { 0, 1, 2 }
                    },
                    new Question
                    {
                        Text = "What is the largest desert in the world?",
                        Options = new List<string> { "Sahara", "Gobi", "Kalahari", "Arctic" },
                        CorrectAnswers = new List<int> { 0 }
                    },
                    new Question
                    {
                        Text = "Which countries share a border with Germany?",
                        Options = new List<string> { "France", "Austria", "Spain", "Poland" },
                        CorrectAnswers = new List<int> { 0, 1, 3 }
                    },
                    new Question
                    {
                        Text = "What is the tallest mountain in the world?",
                        Options = new List<string> { "K2", "Mount Everest", "Kangchenjunga", "Lhotse" },
                        CorrectAnswers = new List<int> { 1 }
                    },
                    new Question
                    {
                        Text = "Which oceans border the United States?",
                        Options = new List<string> { "Atlantic", "Pacific", "Indian", "Arctic" },
                        CorrectAnswers = new List<int> { 0, 1 }
                    },
                    new Question
                    {
                        Text = "What is the smallest country in the world by area?",
                        Options = new List<string> { "Monaco", "Vatican City", "San Marino", "Liechtenstein" },
                        CorrectAnswers = new List<int> { 1 }
                    },
                    new Question
                    {
                        Text = "Which of the following are US states?",
                        Options = new List<string> { "Alaska", "Quebec", "Texas", "Ontario" },
                        CorrectAnswers = new List<int> { 0, 2 }
                    },
                    new Question
                    {
                        Text = "Which countries are part of the United Kingdom?",
                        Options = new List<string> { "England", "Scotland", "Wales", "Ireland" },
                        CorrectAnswers = new List<int> { 0, 1, 2 }
                    },
                    new Question
                    {
                        Text = "Which city is known as the 'Big Apple'?",
                        Options = new List<string> { "Los Angeles", "New York", "Chicago", "Miami" },
                        CorrectAnswers = new List<int> { 1 }
                    },
                    new Question
                    {
                        Text = "Which countries are located in South America?",
                        Options = new List<string> { "Brazil", "Argentina", "Mexico", "Chile" },
                        CorrectAnswers = new List<int> { 0, 1, 3 }
                    },
                    new Question
                    {
                        Text = "What is the longest river in the world?",
                        Options = new List<string> { "Nile", "Amazon", "Yangtze", "Mississippi" },
                        CorrectAnswers = new List<int> { 0, 1 }
                    },
                    new Question
                    {
                        Text = "Which countries have a Mediterranean coastline?",
                        Options = new List<string> { "Spain", "Portugal", "Italy", "Turkey" },
                        CorrectAnswers = new List<int> { 0, 2, 3 }
                    },
                    new Question
                    {
                        Text = "Which of these are island nations?",
                        Options = new List<string> { "Japan", "Australia", "Iceland", "Germany" },
                        CorrectAnswers = new List<int> { 0, 2 }
                    },
                    new Question
                    {
                        Text = "What is the capital of Canada?",
                        Options = new List<string> { "Toronto", "Ottawa", "Vancouver", "Montreal" },
                        CorrectAnswers = new List<int> { 1 }
                    },
                    new Question
                    {
                        Text = "Which countries are part of Scandinavia?",
                        Options = new List<string> { "Norway", "Denmark", "Finland", "Sweden" },
                        CorrectAnswers = new List<int> { 0, 1, 3 }
                    },
                    new Question
                    {
                        Text = "Which countries use the Euro as their currency?",
                        Options = new List<string> { "Germany", "Switzerland", "France", "Norway" },
                        CorrectAnswers = new List<int> { 0, 2 }
                    },
                    new Question
                    {
                        Text = "What is the largest island in the world?",
                        Options = new List<string> { "Greenland", "New Guinea", "Borneo", "Madagascar" },
                        CorrectAnswers = new List<int> { 0 }
                    },
                    new Question
                    {
                        Text = "Which of these are U.S. territories?",
                        Options = new List<string> { "Puerto Rico", "Guam", "Bermuda", "U.S. Virgin Islands" },
                        CorrectAnswers = new List<int> { 0, 1, 3 }
                    }
                }
            },
            new Quiz
            {
                Category = "Biology",
                Questions = new List<Question>
                {
                    new Question
                    {
                        Text = "What is the basic unit of life?",
                        Options = new List<string> { "Cell", "Atom", "Molecule", "Organ" },
                        CorrectAnswers = new List<int> { 0 }
                    },
                    new Question
                    {
                        Text = "Which of these are mammals?",
                        Options = new List<string> { "Whale", "Shark", "Dolphin", "Turtle" },
                        CorrectAnswers = new List<int> { 0, 2 }
                    },
                    new Question
                    {
                        Text = "What molecule carries genetic information?",
                        Options = new List<string> { "DNA", "RNA", "Protein", "Carbohydrate" },
                        CorrectAnswers = new List<int> { 0 }
                    },
                    new Question
                    {
                        Text = "Which organ is responsible for pumping blood?",
                        Options = new List<string> { "Brain", "Heart", "Liver", "Lungs" },
                        CorrectAnswers = new List<int> { 1 }
                    },
                    new Question
                    {
                        Text = "Which of the following are types of blood cells?",
                        Options = new List<string> { "Red blood cells", "White blood cells", "Platelets", "Neurons" },
                        CorrectAnswers = new List<int> { 0, 1, 2 }
                    },
                    new Question
                    {
                        Text = "Photosynthesis occurs in which organelle?",
                        Options = new List<string> { "Mitochondria", "Chloroplast", "Nucleus", "Ribosome" },
                        CorrectAnswers = new List<int> { 1 }
                    },
                    new Question
                    {
                        Text = "Which of these are examples of invertebrates?",
                        Options = new List<string> { "Spider", "Frog", "Octopus", "Lion" },
                        CorrectAnswers = new List<int> { 0, 2 }
                    },
                    new Question
                    {
                        Text = "What is the process by which cells divide called?",
                        Options = new List<string> { "Mitosis", "Meiosis", "Photosynthesis", "Respiration" },
                        CorrectAnswers = new List<int> { 0, 1 }
                    },
                    new Question
                    {
                        Text = "Which systems are part of the human body?",
                        Options = new List<string> { "Circulatory", "Respiratory", "Digestive", "Solar" },
                        CorrectAnswers = new List<int> { 0, 1, 2 }
                    },
                    new Question
                    {
                        Text = "Which animals are considered reptiles?",
                        Options = new List<string> { "Lizard", "Frog", "Snake", "Turtle" },
                        CorrectAnswers = new List<int> { 0, 2, 3 }
                    },
                    new Question
                    {
                        Text = "What type of blood vessels carry blood away from the heart?",
                        Options = new List<string> { "Veins", "Arteries", "Capillaries", "Venules" },
                        CorrectAnswers = new List<int> { 1 }
                    },
                    new Question
                    {
                        Text = "Which of these are producers in an ecosystem?",
                        Options = new List<string> { "Plants", "Animals", "Fungi", "Algae" },
                        CorrectAnswers = new List<int> { 0, 3 }
                    },
                    new Question
                    {
                        Text = "What do we call animals that eat only plants?",
                        Options = new List<string> { "Carnivores", "Herbivores", "Omnivores", "Detritivores" },
                        CorrectAnswers = new List<int> { 1 }
                    },
                    new Question
                    {
                        Text = "Which organ filters waste from the blood?",
                        Options = new List<string> { "Kidney", "Liver", "Pancreas", "Lungs" },
                        CorrectAnswers = new List<int> { 0 }
                    },
                    new Question
                    {
                        Text = "Which are types of RNA?",
                        Options = new List<string> { "mRNA", "tRNA", "rRNA", "cRNA" },
                        CorrectAnswers = new List<int> { 0, 1, 2 }
                    },
                    new Question
                    {
                        Text = "What kingdom do fungi belong to?",
                        Options = new List<string> { "Plantae", "Animalia", "Fungi", "Protista" },
                        CorrectAnswers = new List<int> { 2 }
                    },
                    new Question
                    {
                        Text = "Which of these are part of the human skeletal system?",
                        Options = new List<string> { "Femur", "Heart", "Skull", "Liver" },
                        CorrectAnswers = new List<int> { 0, 2 }
                    },
                    new Question
                    {
                        Text = "Which are examples of amphibians?",
                        Options = new List<string> { "Salamander", "Frog", "Snake", "Turtle" },
                        CorrectAnswers = new List<int> { 0, 1 }
                    },
                    new Question
                    {
                        Text = "What is the powerhouse of the cell?",
                        Options = new List<string> { "Mitochondria", "Nucleus", "Ribosome", "Golgi apparatus" },
                        CorrectAnswers = new List<int> { 0 }
                    },
                    new Question
                    {
                        Text = "Which processes do plants use to make energy?",
                        Options = new List<string> { "Photosynthesis", "Respiration", "Fermentation", "Decomposition" },
                        CorrectAnswers = new List<int> { 0, 1 }
                    }

                }
            }
        };

            var json = JsonSerializer.Serialize(quizzes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(QuizFilePath, json);
        }
    }
}
