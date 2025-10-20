using System;
using System.Security.Cryptography.X509Certificates;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _bonusPoints;
        private int _completedCount;
        private int _totalCount;
        private bool _isComplete;

        public ChecklistGoal(string name, string description, int points, int bonusPoints, int totalCount)
            : base(name, description, points)
        {
            _bonusPoints = bonusPoints;
            _totalCount = totalCount;
            _completedCount = 0;
            _isComplete = false;
        }

        public override void RecordEvent()
        {
            if (!_isComplete)
            {
                _completedCount++;

                if (_completedCount >= _totalCount)
                {
                    _isComplete = true;
                    Console.WriteLine($"You completed '{_name}' {_totalCount} times and earned {_points + _bonusPoints} points (including bonus)!");
                }
                else
                {
                    Console.WriteLine($"You recorded '{_name}' and earned {_points} points. ({_completedCount}/{_totalCount})");
                }
            }
            else
            {
                Console.WriteLine($"'{_name}' is already fully completed!");
            }
        }
        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonusPoints}|{_completedCount}|{_totalCount}|{_isComplete}";
        }

        public override string GetInfor()
        {
            string box = _isComplete ? "[X]" : "[ ]";
            return $"{box} {_name} ({_description}) -- Completed {_completedCount}/{_totalCount}";
        }
    }
}