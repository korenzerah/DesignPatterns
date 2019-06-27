using System;
using System.Collections.Generic;

namespace DesignPatterns.exam.exercise6
{
    public class FlyWeightPower
    {
        public List<Tuple<int, int>> allPowerNumbers {get; set;} = new List<Tuple<int, int>>();

        public void addPowerNumber(int _base, int _power) {
            this.allPowerNumbers.Add(new Tuple<int,int>(_base, _power));
        }
    }
}