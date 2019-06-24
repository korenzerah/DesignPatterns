using System.Linq;
using System;
using System.Collections.Generic;
namespace DesignPatterns.builder
{
    public class Salad
    {
        private List<string> ingredients = new List<string>();

        public void prepareVegg(string vegg) {
            this.ingredients.Add(vegg);
        }

        public void prepareMain(string main) {
            this.ingredients.Add(main);
        }

        public void prepareSauces(string sauces) {
            this.ingredients.Add(sauces);
        }

        public void PrepareTopping(string topping) {
            this.ingredients.Add(topping);
        }

        public void preparePrice(string price) {
            this.ingredients.Add(price);
        }

        public override string ToString() {            
            foreach (string ingredient in this.ingredients) {
                Console.WriteLine(ingredient);
            }

            return string.Join(" ", this.ingredients.ToArray());
        }
    }
}