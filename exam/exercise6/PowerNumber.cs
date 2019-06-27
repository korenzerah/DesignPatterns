using System;
namespace DesignPatterns.exam.exercise6
{
    public class PowerNumber
    {
        public double calculation {get; set;}
        public PowerNumber(int _base, int _power) {
            this.calculation = Math.Pow(_base, _power);
        }
    }
}