using System.Collections.Generic;

namespace DesignPatterns.exam.exercise6
{
    public class PowerNumberCalculator
    {
        public List<PowerNumber> calculatePowerNumbers(FlyWeightPower powerNumbers) {
            return powerNumbers.allPowerNumbers.ConvertAll(
                (powerNumber) => new PowerNumber(powerNumber.Item1, powerNumber.Item2));
        }
    }
}