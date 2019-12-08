using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.BL.Model
{
    [Serializable]
    public class Activity
    {
        public string Name { get; }

        public double CaloriesPerMinute { get; set; }

        public Activity(string name, double calories)
        {
            //TODO: проверка
            Name = name;
            CaloriesPerMinute = calories;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
