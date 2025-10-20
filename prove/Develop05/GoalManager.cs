using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine($"Score: {_score}\n");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Load Goals");
                Console.WriteLine("6. Exit");
                Console.Write("\nSelect a choice: ");

                switch (choice)
                {
                    case "1": CreateGoal(); break;
                    case "2": ListGoals(); break;
                    case "3": RecordEvent(); break;
                    case "4": SaveGoals(); break;
                    case "5": LoadGoals(); break;
                    case "6": exit = true; break;
                    default: Console.WriteLine("Invaild choice."); break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
        }

        private void CreateGoal()
        {
            Console.Clear();
            Console.WriteLine("Select goal type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Choice: ");
            string type = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Description: ");
            string desc = Console.ReadLine();

            Console.Write("Points: ");
            int points = int.Parse(Console.ReadLine());

            if (type == "1")
                _goals.Add(new SimpleGoal(name, desc, points));
            else if (type == "2")
                _goals.Add(new EternalGoal(name, desc, points));
            else if (type == "3")
            {
                Console.Write("Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());

                Console.Write("Times to Complete: ");
                int total = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, desc, points, bonus, total));
            }

            Console.WriteLine("/nGoal created!");
        }

        private void ListGoals()
        {
            Console.Clear();
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals created yet.");
                return;
            }

            Console.WriteLine("Your Goals:\n");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetInfor()}");
            }
        }

        private void RecordEvent()
        {
            Console.Clear();
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals available.");
                return;
            }

            ListGoals();
            Console.Write("\nWhich goal did you accomplish? ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < _goals.Count)
            {
                _goals[index].RecordEvent();
                _score += _goals[index].GetPoints();
            }
        }

        private void SaveGoals()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(_score);
                foreach (Goal g in _goals)
                {
                    writer.WriteLine(g.GetStringRepresentation());
                }
            }

            Console.WriteLine("Goals saved!");
        }

        private void LoadGoals()
        {
            Console.Write("Enter file name: ");
            string file = Console.ReadLine();

            if (!File.Exists(file))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(file);
            _goals.Clear();
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                if (type == "SimpleGoal")
                {
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);
                    bool done = bool.Parse(parts[4]);
                    _goals.Add(new SimpleGoal(name, desc, points, done));
                }
                else if (type == "EternalGoal")
                {
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);
                    _goals.Add(new EternalGoal(name, desc, points));
                }
                else if (type == "ChecklistGoal")
                {
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);
                    int bonus = int.Parse(parts[4]);
                    int completed = int.Parse(parts[5]);
                    int total = int.Parse(parts[6]);
                    bool done = bool.Parse(parts[7]);
                    _goals.Add(new ChecklistGoal(name, desc, points, bonus, total));
                }
            }

            Console.WriteLine("Goals loaded!");
        }    
    }
}