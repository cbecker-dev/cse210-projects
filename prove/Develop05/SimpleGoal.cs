using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points, bool isComplete = false)
            : base(name, description, points)
        {
            _isComplete = isComplete;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
            Console.WriteLine($"You completed '{_name}' and earned {_points} points!");
        }
        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
        }

        public override string GetInfor()
        {
            string box = _isComplete ? "[X]" : "[ ]";
            return $"{box} {_name} ({_description})";
        }
    }
}