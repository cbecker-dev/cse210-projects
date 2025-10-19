using System;

namespace EternalQuest
{
    public abstract class Goal
    {
        protected string _name;
        protected string _description;
        protected int _points;

        protected Goal(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
        }

        public abstract bool IsComplete();
        public abstract void RecordEvent();
        public abstract string GetStringRepresentation();

        public virtual string GetInfor()
        {
            return $"{_name} ({_description}) - Worth {_points} points";
        }
        
        public int GetPoints()
        {
            return _points;
        }
    }
}