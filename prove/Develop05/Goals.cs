using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Develop05
{
    public abstract class Goal
    {
        private string _type;
        private string _name;
        private string _description;
        private int _points;

        public string type
        {
            get{return _type;}
            set{_type = value;}
        }
        public string name
        {
            get {return _name; }
            set {_name = value; }
        }

        public string description
        {
            get {return _description; }
            set {_description = value; }
        }

        public int points
        {
            get {return _points; }
            set {_points = value; }
        }

        public Goal(string type, string name, string description, int points)
        {
            _type = type;
            _name = name;
            _description = description;
            _points = points;
        }

        public abstract void ListGoal(int i);
        public abstract string SaveGoal();
        public abstract string LoadGoal();
        public abstract void RecordGoalEvent(List<Goal> goals);
    }
}
