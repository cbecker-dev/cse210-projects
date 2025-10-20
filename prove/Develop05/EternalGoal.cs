using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }
        public override void RecordEvent()
        {
            Console.WriteLine($"You recorded ' {_name}' and earned {_points} points!");
        }

        public override bool IsComplete()
        {
            return false;
        }
        public override string GetStringRepresentation()
        {
            return $"EternalGoal|{_name}|{_description}|{_points}";
        }

        public override string GetInfor()
        {
            return $"[ ] {_name} ({_description})";
        }
    }
}